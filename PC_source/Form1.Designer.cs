namespace HID_PnP_Demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ReadWriteThread = new System.ComponentModel.BackgroundWorker();
            this.FormUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.txtbx_KB_Val_01 = new System.Windows.Forms.TextBox();
            this.StatusBox_lbl = new System.Windows.Forms.Label();
            this.lbl_FW_Version = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.colum_lbl = new System.Windows.Forms.Label();
            this.debug01_lbl = new System.Windows.Forms.Label();
            this.debug02_lbl = new System.Windows.Forms.Label();
            this.debug03_lbl = new System.Windows.Forms.Label();
            this.txtbx_KB_Val_02 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_03 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_06 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_05 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_04 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_09 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_08 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_07 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_12 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_11 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_10 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_15 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_14 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_13 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_18 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_17 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_16 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_21 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_20 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_19 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_24 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_23 = new System.Windows.Forms.TextBox();
            this.txtbx_KB_Val_22 = new System.Windows.Forms.TextBox();
            this.cmbbx_Set_01 = new System.Windows.Forms.ComboBox();
            this.cmbbx_Set_02 = new System.Windows.Forms.ComboBox();
            this.cmbbx_Set_03 = new System.Windows.Forms.ComboBox();
            this.cmbbx_Set_04 = new System.Windows.Forms.ComboBox();
            this.cmbbx_Set_05 = new System.Windows.Forms.ComboBox();
            this.cmbbx_Set_06 = new System.Windows.Forms.ComboBox();
            this.cmbbx_Set_07 = new System.Windows.Forms.ComboBox();
            this.cmbbx_Set_08 = new System.Windows.Forms.ComboBox();
            this.nud_Set_Val_01 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_02 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_03 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_04 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_05 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_06 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_07 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_08 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_10 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_09 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_12 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_11 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_14 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_13 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_16 = new System.Windows.Forms.NumericUpDown();
            this.nud_Set_Val_15 = new System.Windows.Forms.NumericUpDown();
            this.lbl_title_01 = new System.Windows.Forms.Label();
            this.lbl_title_02 = new System.Windows.Forms.Label();
            this.lbl_title_03 = new System.Windows.Forms.Label();
            this.lbl_title_04 = new System.Windows.Forms.Label();
            this.lbl_title_05 = new System.Windows.Forms.Label();
            this.lbl_title_06 = new System.Windows.Forms.Label();
            this.lbl_title_07 = new System.Windows.Forms.Label();
            this.lbl_title_08 = new System.Windows.Forms.Label();
            this.btn_load_A = new System.Windows.Forms.Button();
            this.ilist_loadsave_btn = new System.Windows.Forms.ImageList(this.components);
            this.btn_save_A = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_reset = new System.Windows.Forms.Button();
            this.ilist_reset_btn = new System.Windows.Forms.ImageList(this.components);
            this.btn_soft_reset = new System.Windows.Forms.Button();
            this.btn_key_clr_01 = new System.Windows.Forms.Button();
            this.btn_key_clr_02 = new System.Windows.Forms.Button();
            this.btn_key_clr_03 = new System.Windows.Forms.Button();
            this.btn_key_clr_04 = new System.Windows.Forms.Button();
            this.btn_key_clr_05 = new System.Windows.Forms.Button();
            this.btn_key_clr_06 = new System.Windows.Forms.Button();
            this.btn_key_clr_07 = new System.Windows.Forms.Button();
            this.btn_key_clr_08 = new System.Windows.Forms.Button();
            this.chkbx_key_modifier_01 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_02 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_03 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_04 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_05 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_06 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_12 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_11 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_10 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_09 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_08 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_07 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_18 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_17 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_16 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_15 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_14 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_13 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_24 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_23 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_22 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_21 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_20 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_19 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_30 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_29 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_28 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_27 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_26 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_25 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_36 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_35 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_34 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_33 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_32 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_31 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_42 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_41 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_40 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_39 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_38 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_37 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_48 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_47 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_46 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_45 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_44 = new System.Windows.Forms.CheckBox();
            this.chkbx_key_modifier_43 = new System.Windows.Forms.CheckBox();
            this.btn_eeprom_init = new System.Windows.Forms.Button();
            this.Status_NC_pb = new System.Windows.Forms.PictureBox();
            this.Status_C_pb = new System.Windows.Forms.PictureBox();
            this.btn_set_A = new System.Windows.Forms.Button();
            this.ilist_set_btn = new System.Windows.Forms.ImageList(this.components);
            this.BackGround_pb = new System.Windows.Forms.PictureBox();
            this.nud_sensitivity_01 = new System.Windows.Forms.NumericUpDown();
            this.nud_sensitivity_02 = new System.Windows.Forms.NumericUpDown();
            this.nud_sensitivity_03 = new System.Windows.Forms.NumericUpDown();
            this.nud_sensitivity_04 = new System.Windows.Forms.NumericUpDown();
            this.nud_sensitivity_dummy = new System.Windows.Forms.NumericUpDown();
            this.lbl_sensivity1 = new System.Windows.Forms.Label();
            this.lbl_sensivity2 = new System.Windows.Forms.Label();
            this.lbl_sensivity3 = new System.Windows.Forms.Label();
            this.lbl_sensivity4 = new System.Windows.Forms.Label();
            this.btn_set_B = new System.Windows.Forms.Button();
            this.btn_save_B = new System.Windows.Forms.Button();
            this.btn_load_B = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_NC_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_C_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_dummy)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadWriteThread
            // 
            this.ReadWriteThread.WorkerReportsProgress = true;
            this.ReadWriteThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ReadWriteThread_DoWork);
            // 
            // FormUpdateTimer
            // 
            this.FormUpdateTimer.Enabled = true;
            this.FormUpdateTimer.Interval = 6;
            this.FormUpdateTimer.Tick += new System.EventHandler(this.FormUpdateTimer_Tick);
            // 
            // txtbx_KB_Val_01
            // 
            this.txtbx_KB_Val_01.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_01, "txtbx_KB_Val_01");
            this.txtbx_KB_Val_01.Name = "txtbx_KB_Val_01";
            this.txtbx_KB_Val_01.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_01.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // StatusBox_lbl
            // 
            resources.ApplyResources(this.StatusBox_lbl, "StatusBox_lbl");
            this.StatusBox_lbl.BackColor = System.Drawing.Color.Transparent;
            this.StatusBox_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.StatusBox_lbl.Name = "StatusBox_lbl";
            // 
            // lbl_FW_Version
            // 
            resources.ApplyResources(this.lbl_FW_Version, "lbl_FW_Version");
            this.lbl_FW_Version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FW_Version.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_FW_Version.Name = "lbl_FW_Version";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colum_lbl);
            this.groupBox1.Controls.Add(this.debug01_lbl);
            this.groupBox1.Controls.Add(this.debug02_lbl);
            this.groupBox1.Controls.Add(this.debug03_lbl);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // colum_lbl
            // 
            resources.ApplyResources(this.colum_lbl, "colum_lbl");
            this.colum_lbl.Name = "colum_lbl";
            // 
            // debug01_lbl
            // 
            resources.ApplyResources(this.debug01_lbl, "debug01_lbl");
            this.debug01_lbl.Name = "debug01_lbl";
            // 
            // debug02_lbl
            // 
            resources.ApplyResources(this.debug02_lbl, "debug02_lbl");
            this.debug02_lbl.Name = "debug02_lbl";
            // 
            // debug03_lbl
            // 
            resources.ApplyResources(this.debug03_lbl, "debug03_lbl");
            this.debug03_lbl.Name = "debug03_lbl";
            // 
            // txtbx_KB_Val_02
            // 
            this.txtbx_KB_Val_02.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_02, "txtbx_KB_Val_02");
            this.txtbx_KB_Val_02.Name = "txtbx_KB_Val_02";
            this.txtbx_KB_Val_02.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_02.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_03
            // 
            this.txtbx_KB_Val_03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_03, "txtbx_KB_Val_03");
            this.txtbx_KB_Val_03.Name = "txtbx_KB_Val_03";
            this.txtbx_KB_Val_03.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_03.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_03.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_06
            // 
            this.txtbx_KB_Val_06.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_06, "txtbx_KB_Val_06");
            this.txtbx_KB_Val_06.Name = "txtbx_KB_Val_06";
            this.txtbx_KB_Val_06.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_06.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_06.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_05
            // 
            this.txtbx_KB_Val_05.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_05, "txtbx_KB_Val_05");
            this.txtbx_KB_Val_05.Name = "txtbx_KB_Val_05";
            this.txtbx_KB_Val_05.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_05.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_05.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_04
            // 
            this.txtbx_KB_Val_04.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_04, "txtbx_KB_Val_04");
            this.txtbx_KB_Val_04.Name = "txtbx_KB_Val_04";
            this.txtbx_KB_Val_04.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_04.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_04.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_09
            // 
            this.txtbx_KB_Val_09.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_09, "txtbx_KB_Val_09");
            this.txtbx_KB_Val_09.Name = "txtbx_KB_Val_09";
            this.txtbx_KB_Val_09.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_09.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_09.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_08
            // 
            this.txtbx_KB_Val_08.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_08, "txtbx_KB_Val_08");
            this.txtbx_KB_Val_08.Name = "txtbx_KB_Val_08";
            this.txtbx_KB_Val_08.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_08.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_08.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_07
            // 
            this.txtbx_KB_Val_07.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_07, "txtbx_KB_Val_07");
            this.txtbx_KB_Val_07.Name = "txtbx_KB_Val_07";
            this.txtbx_KB_Val_07.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_07.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_07.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_12
            // 
            this.txtbx_KB_Val_12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_12, "txtbx_KB_Val_12");
            this.txtbx_KB_Val_12.Name = "txtbx_KB_Val_12";
            this.txtbx_KB_Val_12.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_11
            // 
            this.txtbx_KB_Val_11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_11, "txtbx_KB_Val_11");
            this.txtbx_KB_Val_11.Name = "txtbx_KB_Val_11";
            this.txtbx_KB_Val_11.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_10
            // 
            this.txtbx_KB_Val_10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_10, "txtbx_KB_Val_10");
            this.txtbx_KB_Val_10.Name = "txtbx_KB_Val_10";
            this.txtbx_KB_Val_10.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_15
            // 
            this.txtbx_KB_Val_15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_15, "txtbx_KB_Val_15");
            this.txtbx_KB_Val_15.Name = "txtbx_KB_Val_15";
            this.txtbx_KB_Val_15.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_15.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_14
            // 
            this.txtbx_KB_Val_14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_14, "txtbx_KB_Val_14");
            this.txtbx_KB_Val_14.Name = "txtbx_KB_Val_14";
            this.txtbx_KB_Val_14.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_14.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_13
            // 
            this.txtbx_KB_Val_13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_13, "txtbx_KB_Val_13");
            this.txtbx_KB_Val_13.Name = "txtbx_KB_Val_13";
            this.txtbx_KB_Val_13.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_13.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_18
            // 
            this.txtbx_KB_Val_18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_18, "txtbx_KB_Val_18");
            this.txtbx_KB_Val_18.Name = "txtbx_KB_Val_18";
            this.txtbx_KB_Val_18.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_18.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_18.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_17
            // 
            this.txtbx_KB_Val_17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_17, "txtbx_KB_Val_17");
            this.txtbx_KB_Val_17.Name = "txtbx_KB_Val_17";
            this.txtbx_KB_Val_17.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_17.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_17.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_16
            // 
            this.txtbx_KB_Val_16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_16, "txtbx_KB_Val_16");
            this.txtbx_KB_Val_16.Name = "txtbx_KB_Val_16";
            this.txtbx_KB_Val_16.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_16.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_16.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_21
            // 
            this.txtbx_KB_Val_21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_21, "txtbx_KB_Val_21");
            this.txtbx_KB_Val_21.Name = "txtbx_KB_Val_21";
            this.txtbx_KB_Val_21.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_21.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_21.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_20
            // 
            this.txtbx_KB_Val_20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_20, "txtbx_KB_Val_20");
            this.txtbx_KB_Val_20.Name = "txtbx_KB_Val_20";
            this.txtbx_KB_Val_20.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_20.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_19
            // 
            this.txtbx_KB_Val_19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_19, "txtbx_KB_Val_19");
            this.txtbx_KB_Val_19.Name = "txtbx_KB_Val_19";
            this.txtbx_KB_Val_19.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_19.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_19.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_24
            // 
            this.txtbx_KB_Val_24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_24, "txtbx_KB_Val_24");
            this.txtbx_KB_Val_24.Name = "txtbx_KB_Val_24";
            this.txtbx_KB_Val_24.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_24.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_24.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_23
            // 
            this.txtbx_KB_Val_23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_23, "txtbx_KB_Val_23");
            this.txtbx_KB_Val_23.Name = "txtbx_KB_Val_23";
            this.txtbx_KB_Val_23.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_23.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_23.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // txtbx_KB_Val_22
            // 
            this.txtbx_KB_Val_22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            resources.ApplyResources(this.txtbx_KB_Val_22, "txtbx_KB_Val_22");
            this.txtbx_KB_Val_22.Name = "txtbx_KB_Val_22";
            this.txtbx_KB_Val_22.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtbx_KeyboardValue_PreviewKeyDown);
            this.txtbx_KB_Val_22.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyDown);
            this.txtbx_KB_Val_22.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbx_KeyboardValue_KeyUp);
            // 
            // cmbbx_Set_01
            // 
            this.cmbbx_Set_01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Set_01.FormattingEnabled = true;
            resources.ApplyResources(this.cmbbx_Set_01, "cmbbx_Set_01");
            this.cmbbx_Set_01.Name = "cmbbx_Set_01";
            this.cmbbx_Set_01.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Set_SelectedIndexChanged);
            // 
            // cmbbx_Set_02
            // 
            this.cmbbx_Set_02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Set_02.FormattingEnabled = true;
            resources.ApplyResources(this.cmbbx_Set_02, "cmbbx_Set_02");
            this.cmbbx_Set_02.Name = "cmbbx_Set_02";
            this.cmbbx_Set_02.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Set_SelectedIndexChanged);
            // 
            // cmbbx_Set_03
            // 
            this.cmbbx_Set_03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Set_03.FormattingEnabled = true;
            resources.ApplyResources(this.cmbbx_Set_03, "cmbbx_Set_03");
            this.cmbbx_Set_03.Name = "cmbbx_Set_03";
            this.cmbbx_Set_03.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Set_SelectedIndexChanged);
            // 
            // cmbbx_Set_04
            // 
            this.cmbbx_Set_04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Set_04.FormattingEnabled = true;
            resources.ApplyResources(this.cmbbx_Set_04, "cmbbx_Set_04");
            this.cmbbx_Set_04.Name = "cmbbx_Set_04";
            this.cmbbx_Set_04.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Set_SelectedIndexChanged);
            // 
            // cmbbx_Set_05
            // 
            this.cmbbx_Set_05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Set_05.FormattingEnabled = true;
            resources.ApplyResources(this.cmbbx_Set_05, "cmbbx_Set_05");
            this.cmbbx_Set_05.Name = "cmbbx_Set_05";
            this.cmbbx_Set_05.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Set_SelectedIndexChanged);
            // 
            // cmbbx_Set_06
            // 
            this.cmbbx_Set_06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Set_06.FormattingEnabled = true;
            resources.ApplyResources(this.cmbbx_Set_06, "cmbbx_Set_06");
            this.cmbbx_Set_06.Name = "cmbbx_Set_06";
            this.cmbbx_Set_06.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Set_SelectedIndexChanged);
            // 
            // cmbbx_Set_07
            // 
            this.cmbbx_Set_07.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Set_07.FormattingEnabled = true;
            resources.ApplyResources(this.cmbbx_Set_07, "cmbbx_Set_07");
            this.cmbbx_Set_07.Name = "cmbbx_Set_07";
            this.cmbbx_Set_07.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Set_SelectedIndexChanged);
            // 
            // cmbbx_Set_08
            // 
            this.cmbbx_Set_08.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Set_08.FormattingEnabled = true;
            resources.ApplyResources(this.cmbbx_Set_08, "cmbbx_Set_08");
            this.cmbbx_Set_08.Name = "cmbbx_Set_08";
            this.cmbbx_Set_08.SelectedIndexChanged += new System.EventHandler(this.cmbbx_Set_SelectedIndexChanged);
            // 
            // nud_Set_Val_01
            // 
            resources.ApplyResources(this.nud_Set_Val_01, "nud_Set_Val_01");
            this.nud_Set_Val_01.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_01.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_01.Name = "nud_Set_Val_01";
            // 
            // nud_Set_Val_02
            // 
            resources.ApplyResources(this.nud_Set_Val_02, "nud_Set_Val_02");
            this.nud_Set_Val_02.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_02.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_02.Name = "nud_Set_Val_02";
            // 
            // nud_Set_Val_03
            // 
            resources.ApplyResources(this.nud_Set_Val_03, "nud_Set_Val_03");
            this.nud_Set_Val_03.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_03.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_03.Name = "nud_Set_Val_03";
            // 
            // nud_Set_Val_04
            // 
            resources.ApplyResources(this.nud_Set_Val_04, "nud_Set_Val_04");
            this.nud_Set_Val_04.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_04.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_04.Name = "nud_Set_Val_04";
            // 
            // nud_Set_Val_05
            // 
            resources.ApplyResources(this.nud_Set_Val_05, "nud_Set_Val_05");
            this.nud_Set_Val_05.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_05.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_05.Name = "nud_Set_Val_05";
            // 
            // nud_Set_Val_06
            // 
            resources.ApplyResources(this.nud_Set_Val_06, "nud_Set_Val_06");
            this.nud_Set_Val_06.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_06.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_06.Name = "nud_Set_Val_06";
            // 
            // nud_Set_Val_07
            // 
            resources.ApplyResources(this.nud_Set_Val_07, "nud_Set_Val_07");
            this.nud_Set_Val_07.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_07.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_07.Name = "nud_Set_Val_07";
            // 
            // nud_Set_Val_08
            // 
            resources.ApplyResources(this.nud_Set_Val_08, "nud_Set_Val_08");
            this.nud_Set_Val_08.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_08.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_08.Name = "nud_Set_Val_08";
            // 
            // nud_Set_Val_10
            // 
            resources.ApplyResources(this.nud_Set_Val_10, "nud_Set_Val_10");
            this.nud_Set_Val_10.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_10.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_10.Name = "nud_Set_Val_10";
            // 
            // nud_Set_Val_09
            // 
            resources.ApplyResources(this.nud_Set_Val_09, "nud_Set_Val_09");
            this.nud_Set_Val_09.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_09.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_09.Name = "nud_Set_Val_09";
            // 
            // nud_Set_Val_12
            // 
            resources.ApplyResources(this.nud_Set_Val_12, "nud_Set_Val_12");
            this.nud_Set_Val_12.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_12.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_12.Name = "nud_Set_Val_12";
            // 
            // nud_Set_Val_11
            // 
            resources.ApplyResources(this.nud_Set_Val_11, "nud_Set_Val_11");
            this.nud_Set_Val_11.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_11.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_11.Name = "nud_Set_Val_11";
            // 
            // nud_Set_Val_14
            // 
            resources.ApplyResources(this.nud_Set_Val_14, "nud_Set_Val_14");
            this.nud_Set_Val_14.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_14.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_14.Name = "nud_Set_Val_14";
            // 
            // nud_Set_Val_13
            // 
            resources.ApplyResources(this.nud_Set_Val_13, "nud_Set_Val_13");
            this.nud_Set_Val_13.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_13.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_13.Name = "nud_Set_Val_13";
            // 
            // nud_Set_Val_16
            // 
            resources.ApplyResources(this.nud_Set_Val_16, "nud_Set_Val_16");
            this.nud_Set_Val_16.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_16.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_16.Name = "nud_Set_Val_16";
            // 
            // nud_Set_Val_15
            // 
            resources.ApplyResources(this.nud_Set_Val_15, "nud_Set_Val_15");
            this.nud_Set_Val_15.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.nud_Set_Val_15.Minimum = new decimal(new int[] {
            127,
            0,
            0,
            -2147483648});
            this.nud_Set_Val_15.Name = "nud_Set_Val_15";
            // 
            // lbl_title_01
            // 
            resources.ApplyResources(this.lbl_title_01, "lbl_title_01");
            this.lbl_title_01.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_01.ForeColor = System.Drawing.Color.White;
            this.lbl_title_01.Name = "lbl_title_01";
            // 
            // lbl_title_02
            // 
            resources.ApplyResources(this.lbl_title_02, "lbl_title_02");
            this.lbl_title_02.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_02.ForeColor = System.Drawing.Color.White;
            this.lbl_title_02.Name = "lbl_title_02";
            // 
            // lbl_title_03
            // 
            resources.ApplyResources(this.lbl_title_03, "lbl_title_03");
            this.lbl_title_03.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_03.ForeColor = System.Drawing.Color.White;
            this.lbl_title_03.Name = "lbl_title_03";
            // 
            // lbl_title_04
            // 
            resources.ApplyResources(this.lbl_title_04, "lbl_title_04");
            this.lbl_title_04.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_04.ForeColor = System.Drawing.Color.White;
            this.lbl_title_04.Name = "lbl_title_04";
            // 
            // lbl_title_05
            // 
            resources.ApplyResources(this.lbl_title_05, "lbl_title_05");
            this.lbl_title_05.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_05.ForeColor = System.Drawing.Color.White;
            this.lbl_title_05.Name = "lbl_title_05";
            // 
            // lbl_title_06
            // 
            resources.ApplyResources(this.lbl_title_06, "lbl_title_06");
            this.lbl_title_06.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_06.ForeColor = System.Drawing.Color.White;
            this.lbl_title_06.Name = "lbl_title_06";
            // 
            // lbl_title_07
            // 
            resources.ApplyResources(this.lbl_title_07, "lbl_title_07");
            this.lbl_title_07.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_07.ForeColor = System.Drawing.Color.White;
            this.lbl_title_07.Name = "lbl_title_07";
            // 
            // lbl_title_08
            // 
            resources.ApplyResources(this.lbl_title_08, "lbl_title_08");
            this.lbl_title_08.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_08.ForeColor = System.Drawing.Color.White;
            this.lbl_title_08.Name = "lbl_title_08";
            // 
            // btn_load_A
            // 
            this.btn_load_A.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_load_A, "btn_load_A");
            this.btn_load_A.ImageList = this.ilist_loadsave_btn;
            this.btn_load_A.Name = "btn_load_A";
            this.btn_load_A.Tag = "0";
            this.btn_load_A.UseVisualStyleBackColor = true;
            this.btn_load_A.MouseLeave += new System.EventHandler(this.btn_load_MouseLeave);
            this.btn_load_A.Click += new System.EventHandler(this.btn_load_Click);
            this.btn_load_A.MouseEnter += new System.EventHandler(this.btn_load_MouseEnter);
            // 
            // ilist_loadsave_btn
            // 
            this.ilist_loadsave_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilist_loadsave_btn.ImageStream")));
            this.ilist_loadsave_btn.TransparentColor = System.Drawing.Color.Transparent;
            this.ilist_loadsave_btn.Images.SetKeyName(0, "A_LOAD_active.png");
            this.ilist_loadsave_btn.Images.SetKeyName(1, "A_LOAD_mouseon.png");
            this.ilist_loadsave_btn.Images.SetKeyName(2, "A_SAVE_active.png");
            this.ilist_loadsave_btn.Images.SetKeyName(3, "A_SAVE_mouseon.png");
            this.ilist_loadsave_btn.Images.SetKeyName(4, "B_LOAD_active.png");
            this.ilist_loadsave_btn.Images.SetKeyName(5, "B_LOAD_mouseon.png");
            this.ilist_loadsave_btn.Images.SetKeyName(6, "B_SAVE_active .png");
            this.ilist_loadsave_btn.Images.SetKeyName(7, "B_SAVE_mouseon.png");
            // 
            // btn_save_A
            // 
            this.btn_save_A.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_save_A, "btn_save_A");
            this.btn_save_A.ImageList = this.ilist_loadsave_btn;
            this.btn_save_A.Name = "btn_save_A";
            this.btn_save_A.Tag = "0";
            this.btn_save_A.UseVisualStyleBackColor = true;
            this.btn_save_A.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            this.btn_save_A.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save_A.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            // 
            // btn_reset
            // 
            this.btn_reset.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_reset, "btn_reset");
            this.btn_reset.ImageList = this.ilist_reset_btn;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.MouseLeave += new System.EventHandler(this.btn_reset_MouseLeave);
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.MouseEnter += new System.EventHandler(this.btn_reset_MouseEnter);
            // 
            // ilist_reset_btn
            // 
            this.ilist_reset_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilist_reset_btn.ImageStream")));
            this.ilist_reset_btn.TransparentColor = System.Drawing.Color.Transparent;
            this.ilist_reset_btn.Images.SetKeyName(0, "RESET_active.png");
            this.ilist_reset_btn.Images.SetKeyName(1, "RESET_mouseon.png");
            // 
            // btn_soft_reset
            // 
            resources.ApplyResources(this.btn_soft_reset, "btn_soft_reset");
            this.btn_soft_reset.Name = "btn_soft_reset";
            this.btn_soft_reset.UseVisualStyleBackColor = true;
            this.btn_soft_reset.Click += new System.EventHandler(this.btn_soft_reset_Click);
            // 
            // btn_key_clr_01
            // 
            resources.ApplyResources(this.btn_key_clr_01, "btn_key_clr_01");
            this.btn_key_clr_01.Name = "btn_key_clr_01";
            this.btn_key_clr_01.UseVisualStyleBackColor = true;
            this.btn_key_clr_01.Click += new System.EventHandler(this.btn_key_clr_Click);
            // 
            // btn_key_clr_02
            // 
            resources.ApplyResources(this.btn_key_clr_02, "btn_key_clr_02");
            this.btn_key_clr_02.Name = "btn_key_clr_02";
            this.btn_key_clr_02.UseVisualStyleBackColor = true;
            this.btn_key_clr_02.Click += new System.EventHandler(this.btn_key_clr_Click);
            // 
            // btn_key_clr_03
            // 
            resources.ApplyResources(this.btn_key_clr_03, "btn_key_clr_03");
            this.btn_key_clr_03.Name = "btn_key_clr_03";
            this.btn_key_clr_03.UseVisualStyleBackColor = true;
            this.btn_key_clr_03.Click += new System.EventHandler(this.btn_key_clr_Click);
            // 
            // btn_key_clr_04
            // 
            resources.ApplyResources(this.btn_key_clr_04, "btn_key_clr_04");
            this.btn_key_clr_04.Name = "btn_key_clr_04";
            this.btn_key_clr_04.UseVisualStyleBackColor = true;
            this.btn_key_clr_04.Click += new System.EventHandler(this.btn_key_clr_Click);
            // 
            // btn_key_clr_05
            // 
            resources.ApplyResources(this.btn_key_clr_05, "btn_key_clr_05");
            this.btn_key_clr_05.Name = "btn_key_clr_05";
            this.btn_key_clr_05.UseVisualStyleBackColor = true;
            this.btn_key_clr_05.Click += new System.EventHandler(this.btn_key_clr_Click);
            // 
            // btn_key_clr_06
            // 
            resources.ApplyResources(this.btn_key_clr_06, "btn_key_clr_06");
            this.btn_key_clr_06.Name = "btn_key_clr_06";
            this.btn_key_clr_06.UseVisualStyleBackColor = true;
            this.btn_key_clr_06.Click += new System.EventHandler(this.btn_key_clr_Click);
            // 
            // btn_key_clr_07
            // 
            resources.ApplyResources(this.btn_key_clr_07, "btn_key_clr_07");
            this.btn_key_clr_07.Name = "btn_key_clr_07";
            this.btn_key_clr_07.UseVisualStyleBackColor = true;
            this.btn_key_clr_07.Click += new System.EventHandler(this.btn_key_clr_Click);
            // 
            // btn_key_clr_08
            // 
            resources.ApplyResources(this.btn_key_clr_08, "btn_key_clr_08");
            this.btn_key_clr_08.Name = "btn_key_clr_08";
            this.btn_key_clr_08.UseVisualStyleBackColor = true;
            this.btn_key_clr_08.Click += new System.EventHandler(this.btn_key_clr_Click);
            // 
            // chkbx_key_modifier_01
            // 
            resources.ApplyResources(this.chkbx_key_modifier_01, "chkbx_key_modifier_01");
            this.chkbx_key_modifier_01.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_01.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_01.Name = "chkbx_key_modifier_01";
            this.chkbx_key_modifier_01.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_02
            // 
            resources.ApplyResources(this.chkbx_key_modifier_02, "chkbx_key_modifier_02");
            this.chkbx_key_modifier_02.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_02.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_02.Name = "chkbx_key_modifier_02";
            this.chkbx_key_modifier_02.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_03
            // 
            resources.ApplyResources(this.chkbx_key_modifier_03, "chkbx_key_modifier_03");
            this.chkbx_key_modifier_03.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_03.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_03.Name = "chkbx_key_modifier_03";
            this.chkbx_key_modifier_03.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_04
            // 
            resources.ApplyResources(this.chkbx_key_modifier_04, "chkbx_key_modifier_04");
            this.chkbx_key_modifier_04.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_04.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_04.Name = "chkbx_key_modifier_04";
            this.chkbx_key_modifier_04.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_05
            // 
            resources.ApplyResources(this.chkbx_key_modifier_05, "chkbx_key_modifier_05");
            this.chkbx_key_modifier_05.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_05.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_05.Name = "chkbx_key_modifier_05";
            this.chkbx_key_modifier_05.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_06
            // 
            resources.ApplyResources(this.chkbx_key_modifier_06, "chkbx_key_modifier_06");
            this.chkbx_key_modifier_06.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_06.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_06.Name = "chkbx_key_modifier_06";
            this.chkbx_key_modifier_06.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_12
            // 
            resources.ApplyResources(this.chkbx_key_modifier_12, "chkbx_key_modifier_12");
            this.chkbx_key_modifier_12.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_12.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_12.Name = "chkbx_key_modifier_12";
            this.chkbx_key_modifier_12.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_11
            // 
            resources.ApplyResources(this.chkbx_key_modifier_11, "chkbx_key_modifier_11");
            this.chkbx_key_modifier_11.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_11.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_11.Name = "chkbx_key_modifier_11";
            this.chkbx_key_modifier_11.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_10
            // 
            resources.ApplyResources(this.chkbx_key_modifier_10, "chkbx_key_modifier_10");
            this.chkbx_key_modifier_10.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_10.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_10.Name = "chkbx_key_modifier_10";
            this.chkbx_key_modifier_10.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_09
            // 
            resources.ApplyResources(this.chkbx_key_modifier_09, "chkbx_key_modifier_09");
            this.chkbx_key_modifier_09.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_09.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_09.Name = "chkbx_key_modifier_09";
            this.chkbx_key_modifier_09.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_08
            // 
            resources.ApplyResources(this.chkbx_key_modifier_08, "chkbx_key_modifier_08");
            this.chkbx_key_modifier_08.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_08.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_08.Name = "chkbx_key_modifier_08";
            this.chkbx_key_modifier_08.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_07
            // 
            resources.ApplyResources(this.chkbx_key_modifier_07, "chkbx_key_modifier_07");
            this.chkbx_key_modifier_07.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_07.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_07.Name = "chkbx_key_modifier_07";
            this.chkbx_key_modifier_07.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_18
            // 
            resources.ApplyResources(this.chkbx_key_modifier_18, "chkbx_key_modifier_18");
            this.chkbx_key_modifier_18.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_18.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_18.Name = "chkbx_key_modifier_18";
            this.chkbx_key_modifier_18.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_17
            // 
            resources.ApplyResources(this.chkbx_key_modifier_17, "chkbx_key_modifier_17");
            this.chkbx_key_modifier_17.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_17.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_17.Name = "chkbx_key_modifier_17";
            this.chkbx_key_modifier_17.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_16
            // 
            resources.ApplyResources(this.chkbx_key_modifier_16, "chkbx_key_modifier_16");
            this.chkbx_key_modifier_16.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_16.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_16.Name = "chkbx_key_modifier_16";
            this.chkbx_key_modifier_16.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_15
            // 
            resources.ApplyResources(this.chkbx_key_modifier_15, "chkbx_key_modifier_15");
            this.chkbx_key_modifier_15.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_15.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_15.Name = "chkbx_key_modifier_15";
            this.chkbx_key_modifier_15.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_14
            // 
            resources.ApplyResources(this.chkbx_key_modifier_14, "chkbx_key_modifier_14");
            this.chkbx_key_modifier_14.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_14.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_14.Name = "chkbx_key_modifier_14";
            this.chkbx_key_modifier_14.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_13
            // 
            resources.ApplyResources(this.chkbx_key_modifier_13, "chkbx_key_modifier_13");
            this.chkbx_key_modifier_13.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_13.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_13.Name = "chkbx_key_modifier_13";
            this.chkbx_key_modifier_13.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_24
            // 
            resources.ApplyResources(this.chkbx_key_modifier_24, "chkbx_key_modifier_24");
            this.chkbx_key_modifier_24.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_24.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_24.Name = "chkbx_key_modifier_24";
            this.chkbx_key_modifier_24.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_23
            // 
            resources.ApplyResources(this.chkbx_key_modifier_23, "chkbx_key_modifier_23");
            this.chkbx_key_modifier_23.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_23.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_23.Name = "chkbx_key_modifier_23";
            this.chkbx_key_modifier_23.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_22
            // 
            resources.ApplyResources(this.chkbx_key_modifier_22, "chkbx_key_modifier_22");
            this.chkbx_key_modifier_22.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_22.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_22.Name = "chkbx_key_modifier_22";
            this.chkbx_key_modifier_22.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_21
            // 
            resources.ApplyResources(this.chkbx_key_modifier_21, "chkbx_key_modifier_21");
            this.chkbx_key_modifier_21.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_21.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_21.Name = "chkbx_key_modifier_21";
            this.chkbx_key_modifier_21.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_20
            // 
            resources.ApplyResources(this.chkbx_key_modifier_20, "chkbx_key_modifier_20");
            this.chkbx_key_modifier_20.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_20.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_20.Name = "chkbx_key_modifier_20";
            this.chkbx_key_modifier_20.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_19
            // 
            resources.ApplyResources(this.chkbx_key_modifier_19, "chkbx_key_modifier_19");
            this.chkbx_key_modifier_19.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_19.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_19.Name = "chkbx_key_modifier_19";
            this.chkbx_key_modifier_19.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_30
            // 
            resources.ApplyResources(this.chkbx_key_modifier_30, "chkbx_key_modifier_30");
            this.chkbx_key_modifier_30.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_30.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_30.Name = "chkbx_key_modifier_30";
            this.chkbx_key_modifier_30.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_29
            // 
            resources.ApplyResources(this.chkbx_key_modifier_29, "chkbx_key_modifier_29");
            this.chkbx_key_modifier_29.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_29.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_29.Name = "chkbx_key_modifier_29";
            this.chkbx_key_modifier_29.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_28
            // 
            resources.ApplyResources(this.chkbx_key_modifier_28, "chkbx_key_modifier_28");
            this.chkbx_key_modifier_28.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_28.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_28.Name = "chkbx_key_modifier_28";
            this.chkbx_key_modifier_28.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_27
            // 
            resources.ApplyResources(this.chkbx_key_modifier_27, "chkbx_key_modifier_27");
            this.chkbx_key_modifier_27.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_27.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_27.Name = "chkbx_key_modifier_27";
            this.chkbx_key_modifier_27.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_26
            // 
            resources.ApplyResources(this.chkbx_key_modifier_26, "chkbx_key_modifier_26");
            this.chkbx_key_modifier_26.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_26.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_26.Name = "chkbx_key_modifier_26";
            this.chkbx_key_modifier_26.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_25
            // 
            resources.ApplyResources(this.chkbx_key_modifier_25, "chkbx_key_modifier_25");
            this.chkbx_key_modifier_25.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_25.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_25.Name = "chkbx_key_modifier_25";
            this.chkbx_key_modifier_25.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_36
            // 
            resources.ApplyResources(this.chkbx_key_modifier_36, "chkbx_key_modifier_36");
            this.chkbx_key_modifier_36.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_36.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_36.Name = "chkbx_key_modifier_36";
            this.chkbx_key_modifier_36.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_35
            // 
            resources.ApplyResources(this.chkbx_key_modifier_35, "chkbx_key_modifier_35");
            this.chkbx_key_modifier_35.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_35.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_35.Name = "chkbx_key_modifier_35";
            this.chkbx_key_modifier_35.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_34
            // 
            resources.ApplyResources(this.chkbx_key_modifier_34, "chkbx_key_modifier_34");
            this.chkbx_key_modifier_34.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_34.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_34.Name = "chkbx_key_modifier_34";
            this.chkbx_key_modifier_34.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_33
            // 
            resources.ApplyResources(this.chkbx_key_modifier_33, "chkbx_key_modifier_33");
            this.chkbx_key_modifier_33.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_33.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_33.Name = "chkbx_key_modifier_33";
            this.chkbx_key_modifier_33.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_32
            // 
            resources.ApplyResources(this.chkbx_key_modifier_32, "chkbx_key_modifier_32");
            this.chkbx_key_modifier_32.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_32.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_32.Name = "chkbx_key_modifier_32";
            this.chkbx_key_modifier_32.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_31
            // 
            resources.ApplyResources(this.chkbx_key_modifier_31, "chkbx_key_modifier_31");
            this.chkbx_key_modifier_31.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_31.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_31.Name = "chkbx_key_modifier_31";
            this.chkbx_key_modifier_31.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_42
            // 
            resources.ApplyResources(this.chkbx_key_modifier_42, "chkbx_key_modifier_42");
            this.chkbx_key_modifier_42.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_42.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_42.Name = "chkbx_key_modifier_42";
            this.chkbx_key_modifier_42.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_41
            // 
            resources.ApplyResources(this.chkbx_key_modifier_41, "chkbx_key_modifier_41");
            this.chkbx_key_modifier_41.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_41.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_41.Name = "chkbx_key_modifier_41";
            this.chkbx_key_modifier_41.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_40
            // 
            resources.ApplyResources(this.chkbx_key_modifier_40, "chkbx_key_modifier_40");
            this.chkbx_key_modifier_40.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_40.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_40.Name = "chkbx_key_modifier_40";
            this.chkbx_key_modifier_40.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_39
            // 
            resources.ApplyResources(this.chkbx_key_modifier_39, "chkbx_key_modifier_39");
            this.chkbx_key_modifier_39.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_39.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_39.Name = "chkbx_key_modifier_39";
            this.chkbx_key_modifier_39.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_38
            // 
            resources.ApplyResources(this.chkbx_key_modifier_38, "chkbx_key_modifier_38");
            this.chkbx_key_modifier_38.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_38.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_38.Name = "chkbx_key_modifier_38";
            this.chkbx_key_modifier_38.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_37
            // 
            resources.ApplyResources(this.chkbx_key_modifier_37, "chkbx_key_modifier_37");
            this.chkbx_key_modifier_37.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_37.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_37.Name = "chkbx_key_modifier_37";
            this.chkbx_key_modifier_37.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_48
            // 
            resources.ApplyResources(this.chkbx_key_modifier_48, "chkbx_key_modifier_48");
            this.chkbx_key_modifier_48.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_48.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_48.Name = "chkbx_key_modifier_48";
            this.chkbx_key_modifier_48.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_47
            // 
            resources.ApplyResources(this.chkbx_key_modifier_47, "chkbx_key_modifier_47");
            this.chkbx_key_modifier_47.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_47.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_47.Name = "chkbx_key_modifier_47";
            this.chkbx_key_modifier_47.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_46
            // 
            resources.ApplyResources(this.chkbx_key_modifier_46, "chkbx_key_modifier_46");
            this.chkbx_key_modifier_46.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_46.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_46.Name = "chkbx_key_modifier_46";
            this.chkbx_key_modifier_46.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_45
            // 
            resources.ApplyResources(this.chkbx_key_modifier_45, "chkbx_key_modifier_45");
            this.chkbx_key_modifier_45.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_45.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_45.Name = "chkbx_key_modifier_45";
            this.chkbx_key_modifier_45.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_44
            // 
            resources.ApplyResources(this.chkbx_key_modifier_44, "chkbx_key_modifier_44");
            this.chkbx_key_modifier_44.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_44.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_44.Name = "chkbx_key_modifier_44";
            this.chkbx_key_modifier_44.UseVisualStyleBackColor = false;
            // 
            // chkbx_key_modifier_43
            // 
            resources.ApplyResources(this.chkbx_key_modifier_43, "chkbx_key_modifier_43");
            this.chkbx_key_modifier_43.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_key_modifier_43.ForeColor = System.Drawing.Color.White;
            this.chkbx_key_modifier_43.Name = "chkbx_key_modifier_43";
            this.chkbx_key_modifier_43.UseVisualStyleBackColor = false;
            // 
            // btn_eeprom_init
            // 
            resources.ApplyResources(this.btn_eeprom_init, "btn_eeprom_init");
            this.btn_eeprom_init.Name = "btn_eeprom_init";
            this.btn_eeprom_init.UseVisualStyleBackColor = true;
            this.btn_eeprom_init.Click += new System.EventHandler(this.btn_eeprom_init_Click);
            // 
            // Status_NC_pb
            // 
            resources.ApplyResources(this.Status_NC_pb, "Status_NC_pb");
            this.Status_NC_pb.BackColor = System.Drawing.Color.Transparent;
            this.Status_NC_pb.Image = global::HorizontalControllerEX_CT.Properties.Resources.OFF_Black;
            this.Status_NC_pb.Name = "Status_NC_pb";
            this.Status_NC_pb.TabStop = false;
            // 
            // Status_C_pb
            // 
            resources.ApplyResources(this.Status_C_pb, "Status_C_pb");
            this.Status_C_pb.BackColor = System.Drawing.Color.Transparent;
            this.Status_C_pb.Image = global::HorizontalControllerEX_CT.Properties.Resources.ON_Black;
            this.Status_C_pb.Name = "Status_C_pb";
            this.Status_C_pb.TabStop = false;
            // 
            // btn_set_A
            // 
            this.btn_set_A.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_set_A, "btn_set_A");
            this.btn_set_A.FlatAppearance.BorderSize = 0;
            this.btn_set_A.ImageList = this.ilist_set_btn;
            this.btn_set_A.Name = "btn_set_A";
            this.btn_set_A.Tag = "0";
            this.btn_set_A.UseVisualStyleBackColor = false;
            this.btn_set_A.MouseLeave += new System.EventHandler(this.btn_set_MouseLeave);
            this.btn_set_A.Click += new System.EventHandler(this.btn_set_Click);
            this.btn_set_A.MouseEnter += new System.EventHandler(this.btn_set_MouseEnter);
            // 
            // ilist_set_btn
            // 
            this.ilist_set_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilist_set_btn.ImageStream")));
            this.ilist_set_btn.TransparentColor = System.Drawing.Color.Transparent;
            this.ilist_set_btn.Images.SetKeyName(0, "A_SET_active.png");
            this.ilist_set_btn.Images.SetKeyName(1, "A_SET_mouseon.png");
            this.ilist_set_btn.Images.SetKeyName(2, "B_SET_active.png");
            this.ilist_set_btn.Images.SetKeyName(3, "B_SET_mouseon.png");
            // 
            // BackGround_pb
            // 
            resources.ApplyResources(this.BackGround_pb, "BackGround_pb");
            this.BackGround_pb.Name = "BackGround_pb";
            this.BackGround_pb.TabStop = false;
            // 
            // nud_sensitivity_01
            // 
            resources.ApplyResources(this.nud_sensitivity_01, "nud_sensitivity_01");
            this.nud_sensitivity_01.Name = "nud_sensitivity_01";
            // 
            // nud_sensitivity_02
            // 
            resources.ApplyResources(this.nud_sensitivity_02, "nud_sensitivity_02");
            this.nud_sensitivity_02.Name = "nud_sensitivity_02";
            // 
            // nud_sensitivity_03
            // 
            resources.ApplyResources(this.nud_sensitivity_03, "nud_sensitivity_03");
            this.nud_sensitivity_03.Name = "nud_sensitivity_03";
            // 
            // nud_sensitivity_04
            // 
            resources.ApplyResources(this.nud_sensitivity_04, "nud_sensitivity_04");
            this.nud_sensitivity_04.Name = "nud_sensitivity_04";
            // 
            // nud_sensitivity_dummy
            // 
            resources.ApplyResources(this.nud_sensitivity_dummy, "nud_sensitivity_dummy");
            this.nud_sensitivity_dummy.Name = "nud_sensitivity_dummy";
            // 
            // lbl_sensivity1
            // 
            this.lbl_sensivity1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_sensivity1, "lbl_sensivity1");
            this.lbl_sensivity1.Name = "lbl_sensivity1";
            // 
            // lbl_sensivity2
            // 
            this.lbl_sensivity2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_sensivity2, "lbl_sensivity2");
            this.lbl_sensivity2.Name = "lbl_sensivity2";
            // 
            // lbl_sensivity3
            // 
            this.lbl_sensivity3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_sensivity3, "lbl_sensivity3");
            this.lbl_sensivity3.Name = "lbl_sensivity3";
            // 
            // lbl_sensivity4
            // 
            this.lbl_sensivity4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbl_sensivity4, "lbl_sensivity4");
            this.lbl_sensivity4.Name = "lbl_sensivity4";
            // 
            // btn_set_B
            // 
            this.btn_set_B.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_set_B, "btn_set_B");
            this.btn_set_B.FlatAppearance.BorderSize = 0;
            this.btn_set_B.ImageList = this.ilist_set_btn;
            this.btn_set_B.Name = "btn_set_B";
            this.btn_set_B.Tag = "1";
            this.btn_set_B.UseVisualStyleBackColor = false;
            this.btn_set_B.MouseLeave += new System.EventHandler(this.btn_set_MouseLeave);
            this.btn_set_B.Click += new System.EventHandler(this.btn_set_Click);
            this.btn_set_B.MouseEnter += new System.EventHandler(this.btn_set_MouseEnter);
            // 
            // btn_save_B
            // 
            this.btn_save_B.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_save_B, "btn_save_B");
            this.btn_save_B.ImageList = this.ilist_loadsave_btn;
            this.btn_save_B.Name = "btn_save_B";
            this.btn_save_B.Tag = "1";
            this.btn_save_B.UseVisualStyleBackColor = true;
            this.btn_save_B.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            this.btn_save_B.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save_B.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            // 
            // btn_load_B
            // 
            this.btn_load_B.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_load_B, "btn_load_B");
            this.btn_load_B.ImageList = this.ilist_loadsave_btn;
            this.btn_load_B.Name = "btn_load_B";
            this.btn_load_B.Tag = "1";
            this.btn_load_B.UseVisualStyleBackColor = true;
            this.btn_load_B.MouseLeave += new System.EventHandler(this.btn_load_MouseLeave);
            this.btn_load_B.Click += new System.EventHandler(this.btn_load_Click);
            this.btn_load_B.MouseEnter += new System.EventHandler(this.btn_load_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btn_save_B);
            this.Controls.Add(this.btn_load_B);
            this.Controls.Add(this.btn_set_B);
            this.Controls.Add(this.lbl_sensivity4);
            this.Controls.Add(this.lbl_sensivity3);
            this.Controls.Add(this.lbl_sensivity2);
            this.Controls.Add(this.lbl_sensivity1);
            this.Controls.Add(this.nud_sensitivity_dummy);
            this.Controls.Add(this.nud_sensitivity_04);
            this.Controls.Add(this.nud_sensitivity_03);
            this.Controls.Add(this.nud_sensitivity_02);
            this.Controls.Add(this.nud_sensitivity_01);
            this.Controls.Add(this.StatusBox_lbl);
            this.Controls.Add(this.lbl_FW_Version);
            this.Controls.Add(this.btn_eeprom_init);
            this.Controls.Add(this.chkbx_key_modifier_48);
            this.Controls.Add(this.chkbx_key_modifier_47);
            this.Controls.Add(this.chkbx_key_modifier_46);
            this.Controls.Add(this.chkbx_key_modifier_45);
            this.Controls.Add(this.chkbx_key_modifier_44);
            this.Controls.Add(this.chkbx_key_modifier_43);
            this.Controls.Add(this.chkbx_key_modifier_42);
            this.Controls.Add(this.chkbx_key_modifier_41);
            this.Controls.Add(this.chkbx_key_modifier_40);
            this.Controls.Add(this.chkbx_key_modifier_39);
            this.Controls.Add(this.chkbx_key_modifier_38);
            this.Controls.Add(this.chkbx_key_modifier_37);
            this.Controls.Add(this.chkbx_key_modifier_36);
            this.Controls.Add(this.chkbx_key_modifier_35);
            this.Controls.Add(this.chkbx_key_modifier_34);
            this.Controls.Add(this.chkbx_key_modifier_33);
            this.Controls.Add(this.chkbx_key_modifier_32);
            this.Controls.Add(this.chkbx_key_modifier_31);
            this.Controls.Add(this.chkbx_key_modifier_30);
            this.Controls.Add(this.chkbx_key_modifier_29);
            this.Controls.Add(this.chkbx_key_modifier_28);
            this.Controls.Add(this.chkbx_key_modifier_27);
            this.Controls.Add(this.chkbx_key_modifier_26);
            this.Controls.Add(this.chkbx_key_modifier_25);
            this.Controls.Add(this.chkbx_key_modifier_24);
            this.Controls.Add(this.chkbx_key_modifier_23);
            this.Controls.Add(this.chkbx_key_modifier_22);
            this.Controls.Add(this.chkbx_key_modifier_21);
            this.Controls.Add(this.chkbx_key_modifier_20);
            this.Controls.Add(this.chkbx_key_modifier_19);
            this.Controls.Add(this.chkbx_key_modifier_18);
            this.Controls.Add(this.chkbx_key_modifier_17);
            this.Controls.Add(this.chkbx_key_modifier_16);
            this.Controls.Add(this.chkbx_key_modifier_15);
            this.Controls.Add(this.chkbx_key_modifier_14);
            this.Controls.Add(this.chkbx_key_modifier_13);
            this.Controls.Add(this.chkbx_key_modifier_12);
            this.Controls.Add(this.chkbx_key_modifier_11);
            this.Controls.Add(this.chkbx_key_modifier_10);
            this.Controls.Add(this.chkbx_key_modifier_09);
            this.Controls.Add(this.chkbx_key_modifier_08);
            this.Controls.Add(this.chkbx_key_modifier_07);
            this.Controls.Add(this.chkbx_key_modifier_06);
            this.Controls.Add(this.chkbx_key_modifier_05);
            this.Controls.Add(this.chkbx_key_modifier_04);
            this.Controls.Add(this.chkbx_key_modifier_03);
            this.Controls.Add(this.chkbx_key_modifier_02);
            this.Controls.Add(this.chkbx_key_modifier_01);
            this.Controls.Add(this.btn_key_clr_08);
            this.Controls.Add(this.btn_key_clr_07);
            this.Controls.Add(this.btn_key_clr_06);
            this.Controls.Add(this.btn_key_clr_05);
            this.Controls.Add(this.btn_key_clr_04);
            this.Controls.Add(this.btn_key_clr_03);
            this.Controls.Add(this.btn_key_clr_02);
            this.Controls.Add(this.btn_key_clr_01);
            this.Controls.Add(this.btn_soft_reset);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save_A);
            this.Controls.Add(this.btn_load_A);
            this.Controls.Add(this.lbl_title_08);
            this.Controls.Add(this.lbl_title_07);
            this.Controls.Add(this.lbl_title_06);
            this.Controls.Add(this.lbl_title_05);
            this.Controls.Add(this.lbl_title_04);
            this.Controls.Add(this.lbl_title_03);
            this.Controls.Add(this.lbl_title_02);
            this.Controls.Add(this.lbl_title_01);
            this.Controls.Add(this.nud_Set_Val_16);
            this.Controls.Add(this.nud_Set_Val_15);
            this.Controls.Add(this.nud_Set_Val_14);
            this.Controls.Add(this.nud_Set_Val_13);
            this.Controls.Add(this.nud_Set_Val_12);
            this.Controls.Add(this.nud_Set_Val_11);
            this.Controls.Add(this.nud_Set_Val_10);
            this.Controls.Add(this.nud_Set_Val_09);
            this.Controls.Add(this.Status_NC_pb);
            this.Controls.Add(this.Status_C_pb);
            this.Controls.Add(this.nud_Set_Val_08);
            this.Controls.Add(this.nud_Set_Val_07);
            this.Controls.Add(this.nud_Set_Val_06);
            this.Controls.Add(this.nud_Set_Val_05);
            this.Controls.Add(this.nud_Set_Val_04);
            this.Controls.Add(this.nud_Set_Val_03);
            this.Controls.Add(this.nud_Set_Val_02);
            this.Controls.Add(this.nud_Set_Val_01);
            this.Controls.Add(this.cmbbx_Set_08);
            this.Controls.Add(this.cmbbx_Set_07);
            this.Controls.Add(this.cmbbx_Set_06);
            this.Controls.Add(this.cmbbx_Set_05);
            this.Controls.Add(this.cmbbx_Set_04);
            this.Controls.Add(this.cmbbx_Set_03);
            this.Controls.Add(this.cmbbx_Set_02);
            this.Controls.Add(this.cmbbx_Set_01);
            this.Controls.Add(this.txtbx_KB_Val_24);
            this.Controls.Add(this.txtbx_KB_Val_23);
            this.Controls.Add(this.txtbx_KB_Val_22);
            this.Controls.Add(this.txtbx_KB_Val_21);
            this.Controls.Add(this.txtbx_KB_Val_20);
            this.Controls.Add(this.txtbx_KB_Val_19);
            this.Controls.Add(this.txtbx_KB_Val_18);
            this.Controls.Add(this.txtbx_KB_Val_17);
            this.Controls.Add(this.txtbx_KB_Val_16);
            this.Controls.Add(this.txtbx_KB_Val_15);
            this.Controls.Add(this.txtbx_KB_Val_14);
            this.Controls.Add(this.txtbx_KB_Val_13);
            this.Controls.Add(this.txtbx_KB_Val_12);
            this.Controls.Add(this.txtbx_KB_Val_11);
            this.Controls.Add(this.txtbx_KB_Val_10);
            this.Controls.Add(this.txtbx_KB_Val_09);
            this.Controls.Add(this.txtbx_KB_Val_08);
            this.Controls.Add(this.txtbx_KB_Val_07);
            this.Controls.Add(this.txtbx_KB_Val_06);
            this.Controls.Add(this.txtbx_KB_Val_05);
            this.Controls.Add(this.txtbx_KB_Val_04);
            this.Controls.Add(this.txtbx_KB_Val_03);
            this.Controls.Add(this.txtbx_KB_Val_02);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbx_KB_Val_01);
            this.Controls.Add(this.btn_set_A);
            this.Controls.Add(this.BackGround_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Set_Val_15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_NC_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Status_C_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackGround_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sensitivity_dummy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker ReadWriteThread;
        private System.Windows.Forms.Timer FormUpdateTimer;
        private System.Windows.Forms.TextBox txtbx_KB_Val_01;
        private System.Windows.Forms.PictureBox Status_C_pb;
        private System.Windows.Forms.PictureBox Status_NC_pb;
        private System.Windows.Forms.Label StatusBox_lbl;
        private System.Windows.Forms.Button btn_set_A;
        private System.Windows.Forms.PictureBox BackGround_pb;
        private System.Windows.Forms.Label lbl_FW_Version;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label colum_lbl;
        private System.Windows.Forms.Label debug01_lbl;
        private System.Windows.Forms.Label debug02_lbl;
        private System.Windows.Forms.Label debug03_lbl;
        private System.Windows.Forms.TextBox txtbx_KB_Val_02;
        private System.Windows.Forms.TextBox txtbx_KB_Val_03;
        private System.Windows.Forms.TextBox txtbx_KB_Val_06;
        private System.Windows.Forms.TextBox txtbx_KB_Val_05;
        private System.Windows.Forms.TextBox txtbx_KB_Val_04;
        private System.Windows.Forms.TextBox txtbx_KB_Val_09;
        private System.Windows.Forms.TextBox txtbx_KB_Val_08;
        private System.Windows.Forms.TextBox txtbx_KB_Val_07;
        private System.Windows.Forms.TextBox txtbx_KB_Val_12;
        private System.Windows.Forms.TextBox txtbx_KB_Val_11;
        private System.Windows.Forms.TextBox txtbx_KB_Val_10;
        private System.Windows.Forms.TextBox txtbx_KB_Val_15;
        private System.Windows.Forms.TextBox txtbx_KB_Val_14;
        private System.Windows.Forms.TextBox txtbx_KB_Val_13;
        private System.Windows.Forms.TextBox txtbx_KB_Val_18;
        private System.Windows.Forms.TextBox txtbx_KB_Val_17;
        private System.Windows.Forms.TextBox txtbx_KB_Val_16;
        private System.Windows.Forms.TextBox txtbx_KB_Val_21;
        private System.Windows.Forms.TextBox txtbx_KB_Val_20;
        private System.Windows.Forms.TextBox txtbx_KB_Val_19;
        private System.Windows.Forms.TextBox txtbx_KB_Val_24;
        private System.Windows.Forms.TextBox txtbx_KB_Val_23;
        private System.Windows.Forms.TextBox txtbx_KB_Val_22;
        private System.Windows.Forms.ComboBox cmbbx_Set_01;
        private System.Windows.Forms.ComboBox cmbbx_Set_02;
        private System.Windows.Forms.ComboBox cmbbx_Set_03;
        private System.Windows.Forms.ComboBox cmbbx_Set_04;
        private System.Windows.Forms.ComboBox cmbbx_Set_05;
        private System.Windows.Forms.ComboBox cmbbx_Set_06;
        private System.Windows.Forms.ComboBox cmbbx_Set_07;
        private System.Windows.Forms.ComboBox cmbbx_Set_08;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_01;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_02;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_03;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_04;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_05;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_06;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_07;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_08;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_10;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_09;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_12;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_11;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_14;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_13;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_16;
        private System.Windows.Forms.NumericUpDown nud_Set_Val_15;
        private System.Windows.Forms.Label lbl_title_01;
        private System.Windows.Forms.Label lbl_title_02;
        private System.Windows.Forms.Label lbl_title_03;
        private System.Windows.Forms.Label lbl_title_04;
        private System.Windows.Forms.Label lbl_title_05;
        private System.Windows.Forms.Label lbl_title_06;
        private System.Windows.Forms.Label lbl_title_07;
        private System.Windows.Forms.Label lbl_title_08;
        private System.Windows.Forms.Button btn_load_A;
        private System.Windows.Forms.Button btn_save_A;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_soft_reset;
        private System.Windows.Forms.Button btn_key_clr_01;
        private System.Windows.Forms.Button btn_key_clr_02;
        private System.Windows.Forms.Button btn_key_clr_03;
        private System.Windows.Forms.Button btn_key_clr_04;
        private System.Windows.Forms.Button btn_key_clr_05;
        private System.Windows.Forms.Button btn_key_clr_06;
        private System.Windows.Forms.Button btn_key_clr_07;
        private System.Windows.Forms.Button btn_key_clr_08;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_01;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_02;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_03;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_04;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_05;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_06;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_12;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_11;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_10;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_09;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_08;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_07;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_18;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_17;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_16;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_15;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_14;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_13;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_24;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_23;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_22;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_21;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_20;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_19;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_30;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_29;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_28;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_27;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_26;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_25;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_36;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_35;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_34;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_33;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_32;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_31;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_42;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_41;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_40;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_39;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_38;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_37;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_48;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_47;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_46;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_45;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_44;
        private System.Windows.Forms.CheckBox chkbx_key_modifier_43;
        private System.Windows.Forms.Button btn_eeprom_init;
        private System.Windows.Forms.ImageList ilist_set_btn;
        private System.Windows.Forms.ImageList ilist_loadsave_btn;
        private System.Windows.Forms.ImageList ilist_reset_btn;
        private System.Windows.Forms.NumericUpDown nud_sensitivity_01;
        private System.Windows.Forms.NumericUpDown nud_sensitivity_02;
        private System.Windows.Forms.NumericUpDown nud_sensitivity_03;
        private System.Windows.Forms.NumericUpDown nud_sensitivity_04;
        private System.Windows.Forms.NumericUpDown nud_sensitivity_dummy;
        private System.Windows.Forms.Label lbl_sensivity1;
        private System.Windows.Forms.Label lbl_sensivity2;
        private System.Windows.Forms.Label lbl_sensivity3;
        private System.Windows.Forms.Label lbl_sensivity4;
        private System.Windows.Forms.Button btn_set_B;
        private System.Windows.Forms.Button btn_save_B;
        private System.Windows.Forms.Button btn_load_B;
    }
}

