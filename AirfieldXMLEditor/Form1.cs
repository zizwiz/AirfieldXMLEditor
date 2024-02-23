using CenteredMessagebox;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace AirfieldXMLEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number

            cmbobx_airport_info.Visible = lbl_choose_airfield.Visible = true;
            cmbobx_icao.Visible = lbl_choose_icao.Visible = false;
            lbl_file_name.Visible = false;

            Directory.CreateDirectory("backups");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string filePath = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "..\\test_data";
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    lbl_file_name.Text = filePath;

                    PopulateICAOCmboBx(filePath);
                    cmbobx_icao.SelectedIndex = 0;

                    PopulateAirfieldCmboBx(filePath);
                    cmbobx_airport_info.SelectedIndex = 0;
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }




        void PopulateAirfieldCmboBx(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList airportList = doc.SelectNodes("uk_airports/airport_info/airport_name");
            foreach (XmlNode Name in airportList)
            {
                cmbobx_airport_info.Items.Add(Name.InnerText);
            }
        }

        void PopulateICAOCmboBx(string filename)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            XmlNodeList icaoList = doc.SelectNodes("uk_airports/airport_info/icao_code");
            foreach (XmlNode Name in icaoList)
            {
                cmbobx_icao.Items.Add(Name.InnerText);
            }
        }

        private void chkbx_icao_file_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_icao_file.Checked)
            {
                cmbobx_airport_info.Visible = lbl_choose_airfield.Visible = false;
                cmbobx_icao.Visible = lbl_choose_icao.Visible = true;
            }
            else
            {
                cmbobx_airport_info.Visible = lbl_choose_airfield.Visible = true;
                cmbobx_icao.Visible = lbl_choose_icao.Visible = false;
            }

        }

        private void cmbobx_airport_info_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbobx_airport_info.Items.Count > 0) GetData(true, cmbobx_airport_info.Text);
        }

        private void cmbobx_icao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbobx_icao.Items.Count > 0) GetData(false, cmbobx_icao.Text);
        }

        private void GetData(bool flag, string myData)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(lbl_file_name.Text);

            XmlNodeList nodeList;
            XmlNode root = doc.DocumentElement;

            if (flag)
            {
                nodeList = root.SelectNodes("descendant::airport_info[airport_name ='" + myData + "']");
            }
            else
            {
                nodeList = root.SelectNodes("descendant::airport_info[icao_code ='" + myData + "']");
            }

            foreach (XmlNode node in nodeList)
            {
                txtbx_icao_code.Text = node["icao_code"].InnerText;
                txtbx_airport_name.Text = node["airport_name"].InnerText;
                txtbx_latitude_deg.Text = node["latitude_deg"].InnerText;
                txtbx_latitude_dec.Text = node["latitude_dec"].InnerText;
                txtbx_longitude_deg.Text = node["longitude_deg"].InnerText;
                txtbx_longitude_dec.Text = node["longitude_dec"].InnerText;
                txtbx_elevation_m.Text = node["elevation_m"].InnerText;
                txtbx_elevation_ft.Text = node["elevation_ft"].InnerText;
                txtbx_iata_code.Text = node["iata_code"].InnerText;
                txtbx_alternate_name.Text = node["alternate_name"].InnerText;
                txtbx_fir.Text = node["fir"].InnerText;
                txtbx_city.Text = node["city"].InnerText;
                txtbx_type.Text = node["type"].InnerText;
            }

            cmbobx_icao.SelectedItem = txtbx_icao_code.Text;
            cmbobx_airport_info.SelectedItem = txtbx_airport_name.Text;
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            // Get hold of the data because we will delete this node next
            string icao_code = txtbx_icao_code.Text;
            string airport_name = txtbx_airport_name.Text;
            string latitude_deg = txtbx_latitude_deg.Text;
            string latitude_dec = txtbx_latitude_dec.Text;
            string longitude_deg = txtbx_longitude_deg.Text;
            string longitude_dec = txtbx_longitude_dec.Text;
            string elevation_m = txtbx_elevation_m.Text;
            string elevation_ft = txtbx_elevation_ft.Text;
            string iata_code = txtbx_iata_code.Text;
            string alternate_name = txtbx_alternate_name.Text;
            string fir = txtbx_fir.Text;
            string city = txtbx_city.Text;
            string type = txtbx_type.Text;

            if (DeleteData(txtbx_airport_name.Text)) //Delete the node
            {
                //Re-add the node with stored information
                XDocument doc = XDocument.Load(lbl_file_name.Text);
                XElement root = new XElement("airport_info");

                root.Add(new XElement("icao_code", icao_code));
                root.Add(new XElement("airport_name", airport_name));
                root.Add(new XElement("latitude_deg", latitude_deg));
                root.Add(new XElement("latitude_dec", latitude_dec));
                root.Add(new XElement("longitude_deg", longitude_deg));
                root.Add(new XElement("longitude_dec", longitude_dec));
                root.Add(new XElement("elevation_m", elevation_m));
                root.Add(new XElement("elevation_ft", elevation_ft));
                root.Add(new XElement("iata_code", iata_code));
                root.Add(new XElement("alternate_name", alternate_name));
                root.Add(new XElement("fir", fir));
                root.Add(new XElement("city", city));
                root.Add(new XElement("type", type));

                doc.Element("uk_airports").Add(root);
                doc.Save(lbl_file_name.Text);

                cmbobx_airport_info.Items.Clear();
                PopulateAirfieldCmboBx(lbl_file_name.Text);
                cmbobx_airport_info.SelectedItem = airport_name;

                cmbobx_icao.Items.Clear();
                PopulateICAOCmboBx(lbl_file_name.Text);
                cmbobx_icao.SelectedItem = icao_code;

            }
        }

        private bool DeleteData(string myAirportName)
        {
            if (chkbx_backup.Checked) //Backup existing file when we update anything if box is checked.
            {
                File.Copy(lbl_file_name.Text,
                    "backups\\" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xml");
            }

            // create the XML, load the contents
            XmlDocument doc = new XmlDocument();
            doc.Load(lbl_file_name.Text);

            string xQryStr = "//airport_info[airport_name ='" + myAirportName + "']";

            XmlNode node = doc.SelectSingleNode(xQryStr);

            // if found....
            if (node != null)
            {
                // get its parent node
                XmlNode parent = node.ParentNode;

                // remove the child node
                parent.RemoveChild(node);

                // verify the new XML structure
                string newXML = doc.OuterXml;

                // save to file
                doc.Save(lbl_file_name.Text);
            }
            return true;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MsgBox.Show("Build with Jetbrains Rider\rhttps://www.jetbrains.com/rider/", "About", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
