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
            ClearData();
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
                if (node["icao_code"] != null) txtbx_icao_code.Text = node["icao_code"].InnerText;
                if (node["airport_name"] != null) txtbx_airport_name.Text = node["airport_name"].InnerText;
                if (node["latitude_deg"] != null) txtbx_latitude_deg.Text = node["latitude_deg"].InnerText;
                if (node["latitude_dec"] != null) txtbx_latitude_dec.Text = node["latitude_dec"].InnerText;
                if (node["longitude_deg"] != null) txtbx_longitude_deg.Text = node["longitude_deg"].InnerText;
                if (node["longitude_dec"] != null) txtbx_longitude_dec.Text = node["longitude_dec"].InnerText;
                if (node["elevation_m"] != null) txtbx_elevation_m.Text = node["elevation_m"].InnerText;
                if (node["elevation_ft"] != null) txtbx_elevation_ft.Text = node["elevation_ft"].InnerText;
                if (node["iata_code"] != null) txtbx_iata_code.Text = node["iata_code"].InnerText;
                if (node["alternate_name"] != null) txtbx_alternate_name.Text = node["alternate_name"].InnerText;
                if (node["fir"] != null) txtbx_fir.Text = node["fir"].InnerText;
                if (node["city"] != null) txtbx_city.Text = node["city"].InnerText;
                if (node["type"] != null) txtbx_type.Text = node["type"].InnerText;

                if (node["radio"] != null) txtbx_radio.Text = node["radio"].InnerText;

                if (node["runway1_headings"] != null) txtbx_runway1_headings.Text = node["runway1_headings"].InnerText;
                if (node["runway1_surface"] != null) txtbx_runway1_surface.Text = node["runway1_surface"].InnerText;
                if (node["runway1_length"] != null) txtbx_runway1_length.Text = node["runway1_length"].InnerText;
                if (node["runway1_width"] != null) txtbx_runway1_width.Text = node["runway1_width"].InnerText;

                if (node["runway2_headings"] != null) txtbx_runway2_headings.Text = node["runway2_headings"].InnerText;
                if (node["runway2_surface"] != null) txtbx_runway2_surface.Text = node["runway2_surface"].InnerText;
                if (node["runway2_length"] != null) txtbx_runway2_length.Text = node["runway2_length"].InnerText;
                if (node["runway2_width"] != null) txtbx_runway2_width.Text = node["runway2_width"].InnerText;

                if (node["runway3_headings"] != null) txtbx_runway3_headings.Text = node["runway3_headings"].InnerText;
                if (node["runway3_surface"] != null) txtbx_runway3_surface.Text = node["runway3_surface"].InnerText;
                if (node["runway3_length"] != null) txtbx_runway3_length.Text = node["runway3_length"].InnerText;
                if (node["runway3_width"] != null) txtbx_runway3_width.Text = node["runway3_width"].InnerText;

                if (node["runway4_headings"] != null) txtbx_runway4_headings.Text = node["runway4_headings"].InnerText;
                if (node["runway4_surface"] != null) txtbx_runway4_surface.Text = node["runway4_surface"].InnerText;
                if (node["runway4_length"] != null) txtbx_runway4_length.Text = node["runway4_length"].InnerText;
                if (node["runway4_width"] != null) txtbx_runway4_width.Text = node["runway4_width"].InnerText;

            }

            cmbobx_icao.SelectedItem = txtbx_icao_code.Text;
            cmbobx_airport_info.SelectedItem = txtbx_airport_name.Text;
        }


        private void ClearData()
        {
            txtbx_icao_code.Text = txtbx_airport_name.Text = txtbx_latitude_deg.Text = txtbx_latitude_dec.Text = 
                txtbx_longitude_deg.Text = txtbx_longitude_dec.Text = txtbx_elevation_m.Text = 
                    txtbx_elevation_ft.Text = txtbx_iata_code.Text = txtbx_alternate_name.Text = txtbx_fir.Text = 
                        txtbx_city.Text = txtbx_type.Text = txtbx_radio.Text = txtbx_runway1_headings.Text = 
                            txtbx_runway1_surface.Text = txtbx_runway1_length.Text = txtbx_runway1_width.Text = 
                                txtbx_runway2_headings.Text = txtbx_runway2_surface.Text = 
                                    txtbx_runway2_length.Text = txtbx_runway2_width.Text = 
                                        txtbx_runway3_headings.Text = txtbx_runway3_surface.Text = 
                                            txtbx_runway3_length.Text = txtbx_runway3_width.Text = 
                                                txtbx_runway4_headings.Text = txtbx_runway4_surface.Text = 
                                                    txtbx_runway4_length.Text = txtbx_runway4_width.Text = " ";

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (chkbx_backup.Checked) //Backup existing file when we update anything if box is checked.
            {
                File.Copy(lbl_file_name.Text,
                    "backups\\" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xml");
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(lbl_file_name.Text);

            XmlNode node = doc.SelectSingleNode("//airport_info[airport_name ='" + cmbobx_airport_info.Text + "']");

            
            // if found....
            if (node != null)
            {
                ///////////////////////////////////////////////////////////////////////
                // We do not allow the updating of the ICAO code or the airport name.
                ///////////////////////////////////////////////////////////////////////

                if (node["icao_code"] == null)
                {
                    XmlElement elem = doc.CreateElement("icao_code");
                    node.InsertAfter(elem, node.FirstChild);
                }
                node["icao_code"].InnerText = txtbx_icao_code.Text;

                if (node["latitude_dec"] == null)
                {
                    XmlElement elem = doc.CreateElement("latitude_dec");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["latitude_dec"].InnerText = txtbx_latitude_dec.Text;

                if (node["longitude_deg"] == null)
                {
                    XmlElement elem = doc.CreateElement("longitude_deg");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["longitude_deg"].InnerText = txtbx_longitude_deg.Text;

                if (node["longitude_dec"] == null)
                {
                    XmlElement elem = doc.CreateElement("longitude_dec");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["longitude_dec"].InnerText = txtbx_longitude_dec.Text;


                if (node["elevation_m"] == null)
                {
                    XmlElement elem = doc.CreateElement("elevation_m");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["elevation_m"].InnerText = txtbx_elevation_m.Text;

                if (node["elevation_ft"] == null)
                {
                    XmlElement elem = doc.CreateElement("elevation_ft");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["elevation_ft"].InnerText = txtbx_elevation_ft.Text;

                if (node["iata_code"] == null)
                {
                    XmlElement elem = doc.CreateElement("iata_code");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["iata_code"].InnerText = txtbx_iata_code.Text;

                if (node["alternate_name"] == null)
                {
                    XmlElement elem = doc.CreateElement("alternate_name");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["alternate_name"].InnerText = txtbx_alternate_name.Text;


                if (node["fir"] == null)
                {
                    XmlElement elem = doc.CreateElement("fir");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["fir"].InnerText = txtbx_fir.Text;

                if (node["city"] == null)
                {
                    XmlElement elem = doc.CreateElement("city");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["city"].InnerText = txtbx_city.Text;

                if (node["type"] == null)
                {
                    XmlElement elem = doc.CreateElement("type");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["type"].InnerText = txtbx_type.Text;

                if (node["radio"] == null)
                {
                    XmlElement elem = doc.CreateElement("radio");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["radio"].InnerText = txtbx_radio.Text;

                if (node["runway1_headings"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway1_headings");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway1_headings"].InnerText = txtbx_runway1_headings.Text;

                if (node["runway1_surface"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway1_surface");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway1_surface"].InnerText = txtbx_runway1_surface.Text;

                if (node["runway1_length"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway1_length");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway1_length"].InnerText = txtbx_runway1_length.Text;

                if (node["runway1_width"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway1_width");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway1_width"].InnerText = txtbx_runway1_width.Text;

                if (node["runway2_headings"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway2_headings");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway2_headings"].InnerText = txtbx_runway2_headings.Text;

                if (node["runway2_surface"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway2_surface");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway2_surface"].InnerText = txtbx_runway2_surface.Text;

                if (node["runway2_length"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway2_length");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway2_length"].InnerText = txtbx_runway2_length.Text;

                if (node["runway2_width"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway2_width");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway2_width"].InnerText = txtbx_runway2_width.Text;
                
                if (node["runway3_headings"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway3_headings");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway3_headings"].InnerText = txtbx_runway3_headings.Text;

                if (node["runway3_surface"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway3_surface");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway3_surface"].InnerText = txtbx_runway3_surface.Text;

                if (node["runway3_length"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway3_length");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway3_length"].InnerText = txtbx_runway3_length.Text;

                if (node["runway3_width"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway3_width");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway3_width"].InnerText = txtbx_runway3_width.Text;
                
                if (node["runway4_headings"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway4_headings");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway4_headings"].InnerText = txtbx_runway4_headings.Text;

                if (node["runway4_surface"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway4_surface");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway4_surface"].InnerText = txtbx_runway4_surface.Text;

                if (node["runway4_length"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway4_length");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway4_length"].InnerText = txtbx_runway4_length.Text;

                if (node["runway4_width"] == null)
                {
                    XmlElement elem = doc.CreateElement("runway4_width");
                    node.InsertAfter(elem, node.LastChild);
                }
                node["runway4_width"].InnerText = txtbx_runway4_width.Text;
                

                doc.Save(lbl_file_name.Text);

                cmbobx_airport_info.Items.Clear();
                PopulateAirfieldCmboBx(lbl_file_name.Text);
                cmbobx_airport_info.SelectedItem = txtbx_airport_name.Text;

                cmbobx_icao.Items.Clear();
                PopulateICAOCmboBx(lbl_file_name.Text);
                cmbobx_icao.SelectedItem = txtbx_icao_code.Text;

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
