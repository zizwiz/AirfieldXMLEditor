
namespace AirfieldXMLEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_icao_code = new System.Windows.Forms.TextBox();
            this.txtbx_airport_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbx_latitude_dec = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbx_latitude_deg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_elevation_ft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_elevation_m = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_longitude_dec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_longitude_deg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_type = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbx_city = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtbx_fir = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbx_alternate_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbx_iata_code = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkbx_backup = new System.Windows.Forms.CheckBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.cmbobx_airport_info = new System.Windows.Forms.ComboBox();
            this.lbl_choose_airfield = new System.Windows.Forms.Label();
            this.lbl_choose_icao = new System.Windows.Forms.Label();
            this.cmbobx_icao = new System.Windows.Forms.ComboBox();
            this.chkbx_icao_file = new System.Windows.Forms.CheckBox();
            this.lbl_file_name = new System.Windows.Forms.Label();
            this.btn_about = new System.Windows.Forms.Button();
            this.txtbx_runway1_headings = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbx_runway1_surface = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbx_runway1_width = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbx_runway1_length = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtbx_runway2_surface = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtbx_runway2_headings = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtbx_runway2_width = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtbx_runway2_length = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtbx_radio = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtbx_runway4_surface = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_runway4_headings = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbx_runway3_width = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbx_runway3_length = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtbx_runway3_surface = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtbx_runway3_headings = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtbx_runway4_width = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtbx_runway4_length = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(12, 583);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(145, 59);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(939, 583);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(145, 59);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(396, 583);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 59);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ICAO Code";
            // 
            // txtbx_icao_code
            // 
            this.txtbx_icao_code.Location = new System.Drawing.Point(192, 88);
            this.txtbx_icao_code.Name = "txtbx_icao_code";
            this.txtbx_icao_code.Size = new System.Drawing.Size(349, 26);
            this.txtbx_icao_code.TabIndex = 4;
            // 
            // txtbx_airport_name
            // 
            this.txtbx_airport_name.Location = new System.Drawing.Point(192, 120);
            this.txtbx_airport_name.Name = "txtbx_airport_name";
            this.txtbx_airport_name.Size = new System.Drawing.Size(349, 26);
            this.txtbx_airport_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Airport Name";
            // 
            // txtbx_latitude_dec
            // 
            this.txtbx_latitude_dec.Location = new System.Drawing.Point(707, 152);
            this.txtbx_latitude_dec.Name = "txtbx_latitude_dec";
            this.txtbx_latitude_dec.Size = new System.Drawing.Size(349, 26);
            this.txtbx_latitude_dec.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Latitude Decimal";
            // 
            // txtbx_latitude_deg
            // 
            this.txtbx_latitude_deg.Location = new System.Drawing.Point(192, 152);
            this.txtbx_latitude_deg.Name = "txtbx_latitude_deg";
            this.txtbx_latitude_deg.Size = new System.Drawing.Size(349, 26);
            this.txtbx_latitude_deg.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Latitude Degrees";
            // 
            // txtbx_elevation_ft
            // 
            this.txtbx_elevation_ft.Location = new System.Drawing.Point(707, 216);
            this.txtbx_elevation_ft.Name = "txtbx_elevation_ft";
            this.txtbx_elevation_ft.Size = new System.Drawing.Size(349, 26);
            this.txtbx_elevation_ft.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Elevation ft";
            // 
            // txtbx_elevation_m
            // 
            this.txtbx_elevation_m.Location = new System.Drawing.Point(192, 216);
            this.txtbx_elevation_m.Name = "txtbx_elevation_m";
            this.txtbx_elevation_m.Size = new System.Drawing.Size(349, 26);
            this.txtbx_elevation_m.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Elevation m";
            // 
            // txtbx_longitude_dec
            // 
            this.txtbx_longitude_dec.Location = new System.Drawing.Point(707, 184);
            this.txtbx_longitude_dec.Name = "txtbx_longitude_dec";
            this.txtbx_longitude_dec.Size = new System.Drawing.Size(349, 26);
            this.txtbx_longitude_dec.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Longitude Decimal";
            // 
            // txtbx_longitude_deg
            // 
            this.txtbx_longitude_deg.Location = new System.Drawing.Point(192, 184);
            this.txtbx_longitude_deg.Name = "txtbx_longitude_deg";
            this.txtbx_longitude_deg.Size = new System.Drawing.Size(349, 26);
            this.txtbx_longitude_deg.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Longitude Degrees";
            // 
            // txtbx_type
            // 
            this.txtbx_type.Location = new System.Drawing.Point(707, 248);
            this.txtbx_type.Name = "txtbx_type";
            this.txtbx_type.Size = new System.Drawing.Size(349, 26);
            this.txtbx_type.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(547, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Airport Type";
            // 
            // txtbx_city
            // 
            this.txtbx_city.Location = new System.Drawing.Point(192, 280);
            this.txtbx_city.Name = "txtbx_city";
            this.txtbx_city.Size = new System.Drawing.Size(349, 26);
            this.txtbx_city.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 283);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "City";
            // 
            // txtbx_fir
            // 
            this.txtbx_fir.Location = new System.Drawing.Point(192, 248);
            this.txtbx_fir.Name = "txtbx_fir";
            this.txtbx_fir.Size = new System.Drawing.Size(349, 26);
            this.txtbx_fir.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "FIR";
            // 
            // txtbx_alternate_name
            // 
            this.txtbx_alternate_name.Location = new System.Drawing.Point(707, 120);
            this.txtbx_alternate_name.Name = "txtbx_alternate_name";
            this.txtbx_alternate_name.Size = new System.Drawing.Size(349, 26);
            this.txtbx_alternate_name.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(547, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Alternate Name";
            // 
            // txtbx_iata_code
            // 
            this.txtbx_iata_code.Location = new System.Drawing.Point(707, 88);
            this.txtbx_iata_code.Name = "txtbx_iata_code";
            this.txtbx_iata_code.Size = new System.Drawing.Size(349, 26);
            this.txtbx_iata_code.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(547, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "IATA Code";
            // 
            // chkbx_backup
            // 
            this.chkbx_backup.AutoSize = true;
            this.chkbx_backup.Checked = true;
            this.chkbx_backup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_backup.Location = new System.Drawing.Point(249, 601);
            this.chkbx_backup.Name = "chkbx_backup";
            this.chkbx_backup.Size = new System.Drawing.Size(113, 24);
            this.chkbx_backup.TabIndex = 35;
            this.chkbx_backup.Text = "Backup file";
            this.chkbx_backup.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(788, 583);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(145, 59);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cmbobx_airport_info
            // 
            this.cmbobx_airport_info.FormattingEnabled = true;
            this.cmbobx_airport_info.Location = new System.Drawing.Point(154, 17);
            this.cmbobx_airport_info.Name = "cmbobx_airport_info";
            this.cmbobx_airport_info.Size = new System.Drawing.Size(305, 28);
            this.cmbobx_airport_info.Sorted = true;
            this.cmbobx_airport_info.TabIndex = 37;
            this.cmbobx_airport_info.SelectedIndexChanged += new System.EventHandler(this.cmbobx_airport_info_SelectedIndexChanged);
            // 
            // lbl_choose_airfield
            // 
            this.lbl_choose_airfield.AutoSize = true;
            this.lbl_choose_airfield.Location = new System.Drawing.Point(32, 20);
            this.lbl_choose_airfield.Name = "lbl_choose_airfield";
            this.lbl_choose_airfield.Size = new System.Drawing.Size(116, 20);
            this.lbl_choose_airfield.TabIndex = 38;
            this.lbl_choose_airfield.Text = "Choose Airfield";
            // 
            // lbl_choose_icao
            // 
            this.lbl_choose_icao.AutoSize = true;
            this.lbl_choose_icao.Location = new System.Drawing.Point(744, 20);
            this.lbl_choose_icao.Name = "lbl_choose_icao";
            this.lbl_choose_icao.Size = new System.Drawing.Size(107, 20);
            this.lbl_choose_icao.TabIndex = 40;
            this.lbl_choose_icao.Text = "Choose ICAO";
            // 
            // cmbobx_icao
            // 
            this.cmbobx_icao.FormattingEnabled = true;
            this.cmbobx_icao.Location = new System.Drawing.Point(866, 17);
            this.cmbobx_icao.Name = "cmbobx_icao";
            this.cmbobx_icao.Size = new System.Drawing.Size(190, 28);
            this.cmbobx_icao.Sorted = true;
            this.cmbobx_icao.TabIndex = 39;
            this.cmbobx_icao.SelectedIndexChanged += new System.EventHandler(this.cmbobx_icao_SelectedIndexChanged);
            // 
            // chkbx_icao_file
            // 
            this.chkbx_icao_file.AutoSize = true;
            this.chkbx_icao_file.Location = new System.Drawing.Point(551, 19);
            this.chkbx_icao_file.Name = "chkbx_icao_file";
            this.chkbx_icao_file.Size = new System.Drawing.Size(98, 24);
            this.chkbx_icao_file.TabIndex = 41;
            this.chkbx_icao_file.Text = "ICAO file";
            this.chkbx_icao_file.UseVisualStyleBackColor = true;
            this.chkbx_icao_file.CheckedChanged += new System.EventHandler(this.chkbx_icao_file_CheckedChanged);
            // 
            // lbl_file_name
            // 
            this.lbl_file_name.AutoSize = true;
            this.lbl_file_name.Location = new System.Drawing.Point(652, 605);
            this.lbl_file_name.Name = "lbl_file_name";
            this.lbl_file_name.Size = new System.Drawing.Size(78, 20);
            this.lbl_file_name.TabIndex = 42;
            this.lbl_file_name.Text = "file_name";
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(589, 587);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(46, 55);
            this.btn_about.TabIndex = 43;
            this.btn_about.Text = "?";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // txtbx_runway1_headings
            // 
            this.txtbx_runway1_headings.Location = new System.Drawing.Point(192, 312);
            this.txtbx_runway1_headings.Name = "txtbx_runway1_headings";
            this.txtbx_runway1_headings.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway1_headings.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 20);
            this.label17.TabIndex = 44;
            this.label17.Text = "Runway 1";
            // 
            // txtbx_runway1_surface
            // 
            this.txtbx_runway1_surface.Location = new System.Drawing.Point(707, 312);
            this.txtbx_runway1_surface.Name = "txtbx_runway1_surface";
            this.txtbx_runway1_surface.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway1_surface.TabIndex = 47;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(547, 315);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(132, 20);
            this.label18.TabIndex = 46;
            this.label18.Text = "Runway1 surface";
            // 
            // txtbx_runway1_width
            // 
            this.txtbx_runway1_width.Location = new System.Drawing.Point(707, 344);
            this.txtbx_runway1_width.Name = "txtbx_runway1_width";
            this.txtbx_runway1_width.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway1_width.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(547, 347);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 20);
            this.label19.TabIndex = 50;
            this.label19.Text = "Runway1 Width";
            // 
            // txtbx_runway1_length
            // 
            this.txtbx_runway1_length.Location = new System.Drawing.Point(192, 344);
            this.txtbx_runway1_length.Name = "txtbx_runway1_length";
            this.txtbx_runway1_length.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway1_length.TabIndex = 49;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(32, 347);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 20);
            this.label20.TabIndex = 48;
            this.label20.Text = "Runway1 Length";
            // 
            // txtbx_runway2_surface
            // 
            this.txtbx_runway2_surface.Location = new System.Drawing.Point(707, 376);
            this.txtbx_runway2_surface.Name = "txtbx_runway2_surface";
            this.txtbx_runway2_surface.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway2_surface.TabIndex = 55;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(547, 379);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 20);
            this.label21.TabIndex = 54;
            this.label21.Text = "Runway2 surface";
            // 
            // txtbx_runway2_headings
            // 
            this.txtbx_runway2_headings.Location = new System.Drawing.Point(192, 376);
            this.txtbx_runway2_headings.Name = "txtbx_runway2_headings";
            this.txtbx_runway2_headings.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway2_headings.TabIndex = 53;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(32, 379);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 20);
            this.label22.TabIndex = 52;
            this.label22.Text = "Runway 2";
            // 
            // txtbx_runway2_width
            // 
            this.txtbx_runway2_width.Location = new System.Drawing.Point(707, 408);
            this.txtbx_runway2_width.Name = "txtbx_runway2_width";
            this.txtbx_runway2_width.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway2_width.TabIndex = 59;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(547, 411);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 20);
            this.label23.TabIndex = 58;
            this.label23.Text = "Runway2 Width";
            // 
            // txtbx_runway2_length
            // 
            this.txtbx_runway2_length.Location = new System.Drawing.Point(192, 408);
            this.txtbx_runway2_length.Name = "txtbx_runway2_length";
            this.txtbx_runway2_length.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway2_length.TabIndex = 57;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(32, 411);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 20);
            this.label24.TabIndex = 56;
            this.label24.Text = "Runway2 Length";
            // 
            // txtbx_radio
            // 
            this.txtbx_radio.Location = new System.Drawing.Point(707, 280);
            this.txtbx_radio.Name = "txtbx_radio";
            this.txtbx_radio.Size = new System.Drawing.Size(349, 26);
            this.txtbx_radio.TabIndex = 61;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(547, 283);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 20);
            this.label25.TabIndex = 60;
            this.label25.Text = "Radio";
            // 
            // txtbx_runway4_surface
            // 
            this.txtbx_runway4_surface.Location = new System.Drawing.Point(707, 504);
            this.txtbx_runway4_surface.Name = "txtbx_runway4_surface";
            this.txtbx_runway4_surface.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway4_surface.TabIndex = 73;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "Runway4 surface";
            // 
            // txtbx_runway4_headings
            // 
            this.txtbx_runway4_headings.Location = new System.Drawing.Point(192, 504);
            this.txtbx_runway4_headings.Name = "txtbx_runway4_headings";
            this.txtbx_runway4_headings.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway4_headings.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Runway 4";
            // 
            // txtbx_runway3_width
            // 
            this.txtbx_runway3_width.Location = new System.Drawing.Point(707, 472);
            this.txtbx_runway3_width.Name = "txtbx_runway3_width";
            this.txtbx_runway3_width.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway3_width.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 68;
            this.label11.Text = "Runway3 Width";
            // 
            // txtbx_runway3_length
            // 
            this.txtbx_runway3_length.Location = new System.Drawing.Point(192, 472);
            this.txtbx_runway3_length.Name = "txtbx_runway3_length";
            this.txtbx_runway3_length.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway3_length.TabIndex = 67;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(32, 475);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(129, 20);
            this.label26.TabIndex = 66;
            this.label26.Text = "Runway3 Length";
            // 
            // txtbx_runway3_surface
            // 
            this.txtbx_runway3_surface.Location = new System.Drawing.Point(707, 440);
            this.txtbx_runway3_surface.Name = "txtbx_runway3_surface";
            this.txtbx_runway3_surface.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway3_surface.TabIndex = 65;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(547, 443);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(132, 20);
            this.label27.TabIndex = 64;
            this.label27.Text = "Runway3 surface";
            // 
            // txtbx_runway3_headings
            // 
            this.txtbx_runway3_headings.Location = new System.Drawing.Point(192, 440);
            this.txtbx_runway3_headings.Name = "txtbx_runway3_headings";
            this.txtbx_runway3_headings.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway3_headings.TabIndex = 63;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(32, 443);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 20);
            this.label28.TabIndex = 62;
            this.label28.Text = "Runway 3";
            // 
            // txtbx_runway4_width
            // 
            this.txtbx_runway4_width.Location = new System.Drawing.Point(707, 536);
            this.txtbx_runway4_width.Name = "txtbx_runway4_width";
            this.txtbx_runway4_width.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway4_width.TabIndex = 77;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(547, 539);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(120, 20);
            this.label29.TabIndex = 76;
            this.label29.Text = "Runway4 Width";
            // 
            // txtbx_runway4_length
            // 
            this.txtbx_runway4_length.Location = new System.Drawing.Point(192, 536);
            this.txtbx_runway4_length.Name = "txtbx_runway4_length";
            this.txtbx_runway4_length.Size = new System.Drawing.Size(349, 26);
            this.txtbx_runway4_length.TabIndex = 75;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(32, 539);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(129, 20);
            this.label30.TabIndex = 74;
            this.label30.Text = "Runway4 Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 654);
            this.Controls.Add(this.txtbx_runway4_width);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.txtbx_runway4_length);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtbx_runway4_surface);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbx_runway4_headings);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbx_runway3_width);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbx_runway3_length);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtbx_runway3_surface);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtbx_runway3_headings);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.txtbx_radio);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtbx_runway2_width);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtbx_runway2_length);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtbx_runway2_surface);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtbx_runway2_headings);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtbx_runway1_width);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtbx_runway1_length);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtbx_runway1_surface);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtbx_runway1_headings);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.lbl_file_name);
            this.Controls.Add(this.chkbx_icao_file);
            this.Controls.Add(this.lbl_choose_icao);
            this.Controls.Add(this.cmbobx_icao);
            this.Controls.Add(this.lbl_choose_airfield);
            this.Controls.Add(this.cmbobx_airport_info);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.chkbx_backup);
            this.Controls.Add(this.txtbx_type);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbx_city);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtbx_fir);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtbx_alternate_name);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtbx_iata_code);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtbx_elevation_ft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_elevation_m);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx_longitude_dec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_longitude_deg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbx_latitude_dec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_latitude_deg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_airport_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_icao_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airfield XML Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_icao_code;
        private System.Windows.Forms.TextBox txtbx_airport_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbx_latitude_dec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbx_latitude_deg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_elevation_ft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_elevation_m;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_longitude_dec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_longitude_deg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbx_city;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtbx_fir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbx_alternate_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtbx_iata_code;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkbx_backup;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cmbobx_airport_info;
        private System.Windows.Forms.Label lbl_choose_airfield;
        private System.Windows.Forms.Label lbl_choose_icao;
        private System.Windows.Forms.ComboBox cmbobx_icao;
        private System.Windows.Forms.CheckBox chkbx_icao_file;
        private System.Windows.Forms.Label lbl_file_name;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.TextBox txtbx_runway1_headings;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbx_runway1_surface;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbx_runway1_width;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbx_runway1_length;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtbx_runway2_surface;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtbx_runway2_headings;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtbx_runway2_width;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtbx_runway2_length;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtbx_radio;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtbx_runway4_surface;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbx_runway4_headings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbx_runway3_width;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtbx_runway3_length;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtbx_runway3_surface;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtbx_runway3_headings;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtbx_runway4_width;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtbx_runway4_length;
        private System.Windows.Forms.Label label30;
    }
}

