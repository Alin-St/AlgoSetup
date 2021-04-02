
namespace AlgoSetup
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.setup_tempSetupGB = new System.Windows.Forms.GroupBox();
            this.setup_temp_cppL = new System.Windows.Forms.Label();
            this.setup_temp_cppFilenameTB = new System.Windows.Forms.TextBox();
            this.setup_temp_cppFilenameL = new System.Windows.Forms.Label();
            this.setup_temp_openB = new System.Windows.Forms.Button();
            this.setup_temp_inOutL = new System.Windows.Forms.Label();
            this.setup_temp_inOutFilesCB = new System.Windows.Forms.CheckBox();
            this.setup_temp_createB = new System.Windows.Forms.Button();
            this.setup_temp_inOutFilenameL = new System.Windows.Forms.Label();
            this.setup_temp_inOutFilenameTB = new System.Windows.Forms.TextBox();
            this.setup_archiveSetupGB = new System.Windows.Forms.GroupBox();
            this.setup_archive_openB = new System.Windows.Forms.Button();
            this.setup_archive_createB = new System.Windows.Forms.Button();
            this.setup_archive_cppL = new System.Windows.Forms.Label();
            this.setup_archive_folderTB = new System.Windows.Forms.TextBox();
            this.setup_archive_folderL = new System.Windows.Forms.Label();
            this.setup_archive_inOutFilesCB = new System.Windows.Forms.CheckBox();
            this.setup_archive_cppFilenameTB = new System.Windows.Forms.TextBox();
            this.setup_archive_cppFilenameL = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.setupTP = new System.Windows.Forms.TabPage();
            this.setup_splitContainer = new System.Windows.Forms.SplitContainer();
            this.preferencesTP = new System.Windows.Forms.TabPage();
            this.pref_editCodeOpenPrefSC = new System.Windows.Forms.SplitContainer();
            this.pref_editStartCodeB = new System.Windows.Forms.Button();
            this.pref_openPrefFolderB = new System.Windows.Forms.Button();
            this.pref_saveDataForAutocompleteCB = new System.Windows.Forms.CheckBox();
            this.pref_openFilesWithTB = new System.Windows.Forms.TextBox();
            this.pref_openFilesWithL = new System.Windows.Forms.Label();
            this.pref_exitAfterOpenCreateCB = new System.Windows.Forms.CheckBox();
            this.pref_openAfterCreateCB = new System.Windows.Forms.CheckBox();
            this.pref_archiveSetupFolderB = new System.Windows.Forms.Button();
            this.pref_archiveSetupFolderL = new System.Windows.Forms.Label();
            this.pref_tempSetupFolderB = new System.Windows.Forms.Button();
            this.pref_tempSetupFolderL = new System.Windows.Forms.Label();
            this.pref_tempSetupFolderTT = new System.Windows.Forms.ToolTip(this.components);
            this.setup_tempSetupGB.SuspendLayout();
            this.setup_archiveSetupGB.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.setupTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setup_splitContainer)).BeginInit();
            this.setup_splitContainer.Panel1.SuspendLayout();
            this.setup_splitContainer.Panel2.SuspendLayout();
            this.setup_splitContainer.SuspendLayout();
            this.preferencesTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pref_editCodeOpenPrefSC)).BeginInit();
            this.pref_editCodeOpenPrefSC.Panel1.SuspendLayout();
            this.pref_editCodeOpenPrefSC.Panel2.SuspendLayout();
            this.pref_editCodeOpenPrefSC.SuspendLayout();
            this.SuspendLayout();
            // 
            // setup_tempSetupGB
            // 
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_cppL);
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_cppFilenameTB);
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_cppFilenameL);
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_openB);
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_inOutL);
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_inOutFilesCB);
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_createB);
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_inOutFilenameL);
            this.setup_tempSetupGB.Controls.Add(this.setup_temp_inOutFilenameTB);
            this.setup_tempSetupGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setup_tempSetupGB.Location = new System.Drawing.Point(0, 0);
            this.setup_tempSetupGB.Name = "setup_tempSetupGB";
            this.setup_tempSetupGB.Size = new System.Drawing.Size(381, 231);
            this.setup_tempSetupGB.TabIndex = 0;
            this.setup_tempSetupGB.TabStop = false;
            this.setup_tempSetupGB.Text = "Temp Setup";
            // 
            // setup_temp_cppL
            // 
            this.setup_temp_cppL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.setup_temp_cppL.AutoSize = true;
            this.setup_temp_cppL.Location = new System.Drawing.Point(337, 44);
            this.setup_temp_cppL.Name = "setup_temp_cppL";
            this.setup_temp_cppL.Size = new System.Drawing.Size(38, 18);
            this.setup_temp_cppL.TabIndex = 9;
            this.setup_temp_cppL.Text = ".cpp";
            // 
            // setup_temp_cppFilenameTB
            // 
            this.setup_temp_cppFilenameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setup_temp_cppFilenameTB.Location = new System.Drawing.Point(113, 41);
            this.setup_temp_cppFilenameTB.Name = "setup_temp_cppFilenameTB";
            this.setup_temp_cppFilenameTB.Size = new System.Drawing.Size(218, 26);
            this.setup_temp_cppFilenameTB.TabIndex = 8;
            this.setup_temp_cppFilenameTB.Text = "main";
            this.setup_temp_cppFilenameTB.TextChanged += new System.EventHandler(this.Setup_temp_cppFilenameTB_TextChanged);
            // 
            // setup_temp_cppFilenameL
            // 
            this.setup_temp_cppFilenameL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setup_temp_cppFilenameL.AutoSize = true;
            this.setup_temp_cppFilenameL.Location = new System.Drawing.Point(6, 44);
            this.setup_temp_cppFilenameL.Name = "setup_temp_cppFilenameL";
            this.setup_temp_cppFilenameL.Size = new System.Drawing.Size(101, 18);
            this.setup_temp_cppFilenameL.TabIndex = 7;
            this.setup_temp_cppFilenameL.Text = "cpp filename:";
            // 
            // setup_temp_openB
            // 
            this.setup_temp_openB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setup_temp_openB.Enabled = false;
            this.setup_temp_openB.Location = new System.Drawing.Point(45, 170);
            this.setup_temp_openB.Name = "setup_temp_openB";
            this.setup_temp_openB.Size = new System.Drawing.Size(142, 26);
            this.setup_temp_openB.TabIndex = 5;
            this.setup_temp_openB.Text = "Open";
            this.setup_temp_openB.UseVisualStyleBackColor = true;
            this.setup_temp_openB.Click += new System.EventHandler(this.Setup_temp_openB_Click);
            // 
            // setup_temp_inOutL
            // 
            this.setup_temp_inOutL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.setup_temp_inOutL.AutoSize = true;
            this.setup_temp_inOutL.Location = new System.Drawing.Point(322, 116);
            this.setup_temp_inOutL.Name = "setup_temp_inOutL";
            this.setup_temp_inOutL.Size = new System.Drawing.Size(53, 18);
            this.setup_temp_inOutL.TabIndex = 4;
            this.setup_temp_inOutL.Text = ".in/.out";
            // 
            // setup_temp_inOutFilesCB
            // 
            this.setup_temp_inOutFilesCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setup_temp_inOutFilesCB.Checked = true;
            this.setup_temp_inOutFilesCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setup_temp_inOutFilesCB.Location = new System.Drawing.Point(9, 81);
            this.setup_temp_inOutFilesCB.Name = "setup_temp_inOutFilesCB";
            this.setup_temp_inOutFilesCB.Size = new System.Drawing.Size(366, 26);
            this.setup_temp_inOutFilesCB.TabIndex = 3;
            this.setup_temp_inOutFilesCB.Text = "in/out files";
            this.setup_temp_inOutFilesCB.UseVisualStyleBackColor = true;
            this.setup_temp_inOutFilesCB.CheckedChanged += new System.EventHandler(this.Setup_temp_inOutFilesCB_CheckedChanged);
            // 
            // setup_temp_createB
            // 
            this.setup_temp_createB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setup_temp_createB.Location = new System.Drawing.Point(193, 170);
            this.setup_temp_createB.Name = "setup_temp_createB";
            this.setup_temp_createB.Size = new System.Drawing.Size(142, 26);
            this.setup_temp_createB.TabIndex = 2;
            this.setup_temp_createB.Text = "Create";
            this.setup_temp_createB.UseVisualStyleBackColor = true;
            this.setup_temp_createB.Click += new System.EventHandler(this.Setup_temp_createB_Click);
            // 
            // setup_temp_inOutFilenameL
            // 
            this.setup_temp_inOutFilenameL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setup_temp_inOutFilenameL.AutoSize = true;
            this.setup_temp_inOutFilenameL.Location = new System.Drawing.Point(6, 116);
            this.setup_temp_inOutFilenameL.Name = "setup_temp_inOutFilenameL";
            this.setup_temp_inOutFilenameL.Size = new System.Drawing.Size(112, 18);
            this.setup_temp_inOutFilenameL.TabIndex = 1;
            this.setup_temp_inOutFilenameL.Text = "in/out filename:";
            // 
            // setup_temp_inOutFilenameTB
            // 
            this.setup_temp_inOutFilenameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setup_temp_inOutFilenameTB.Location = new System.Drawing.Point(124, 113);
            this.setup_temp_inOutFilenameTB.Name = "setup_temp_inOutFilenameTB";
            this.setup_temp_inOutFilenameTB.Size = new System.Drawing.Size(192, 26);
            this.setup_temp_inOutFilenameTB.TabIndex = 0;
            this.setup_temp_inOutFilenameTB.Text = "problem";
            this.setup_temp_inOutFilenameTB.TextChanged += new System.EventHandler(this.Setup_temp_inOutFilenameTB_TextChanged);
            // 
            // setup_archiveSetupGB
            // 
            this.setup_archiveSetupGB.Controls.Add(this.setup_archive_openB);
            this.setup_archiveSetupGB.Controls.Add(this.setup_archive_createB);
            this.setup_archiveSetupGB.Controls.Add(this.setup_archive_cppL);
            this.setup_archiveSetupGB.Controls.Add(this.setup_archive_folderTB);
            this.setup_archiveSetupGB.Controls.Add(this.setup_archive_folderL);
            this.setup_archiveSetupGB.Controls.Add(this.setup_archive_inOutFilesCB);
            this.setup_archiveSetupGB.Controls.Add(this.setup_archive_cppFilenameTB);
            this.setup_archiveSetupGB.Controls.Add(this.setup_archive_cppFilenameL);
            this.setup_archiveSetupGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setup_archiveSetupGB.Location = new System.Drawing.Point(0, 0);
            this.setup_archiveSetupGB.Name = "setup_archiveSetupGB";
            this.setup_archiveSetupGB.Size = new System.Drawing.Size(380, 231);
            this.setup_archiveSetupGB.TabIndex = 0;
            this.setup_archiveSetupGB.TabStop = false;
            this.setup_archiveSetupGB.Text = "Archive Setup";
            // 
            // setup_archive_openB
            // 
            this.setup_archive_openB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setup_archive_openB.Enabled = false;
            this.setup_archive_openB.Location = new System.Drawing.Point(45, 170);
            this.setup_archive_openB.Name = "setup_archive_openB";
            this.setup_archive_openB.Size = new System.Drawing.Size(142, 26);
            this.setup_archive_openB.TabIndex = 7;
            this.setup_archive_openB.Text = "Open";
            this.setup_archive_openB.UseVisualStyleBackColor = true;
            this.setup_archive_openB.Click += new System.EventHandler(this.Setup_archive_openB_Click);
            // 
            // setup_archive_createB
            // 
            this.setup_archive_createB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setup_archive_createB.Location = new System.Drawing.Point(193, 170);
            this.setup_archive_createB.Name = "setup_archive_createB";
            this.setup_archive_createB.Size = new System.Drawing.Size(142, 26);
            this.setup_archive_createB.TabIndex = 6;
            this.setup_archive_createB.Text = "Create";
            this.setup_archive_createB.UseVisualStyleBackColor = true;
            this.setup_archive_createB.Click += new System.EventHandler(this.Setup_archive_createB_Click);
            // 
            // setup_archive_cppL
            // 
            this.setup_archive_cppL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.setup_archive_cppL.AutoSize = true;
            this.setup_archive_cppL.Location = new System.Drawing.Point(336, 44);
            this.setup_archive_cppL.Name = "setup_archive_cppL";
            this.setup_archive_cppL.Size = new System.Drawing.Size(38, 18);
            this.setup_archive_cppL.TabIndex = 5;
            this.setup_archive_cppL.Text = ".cpp";
            // 
            // setup_archive_folderTB
            // 
            this.setup_archive_folderTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setup_archive_folderTB.Location = new System.Drawing.Point(69, 113);
            this.setup_archive_folderTB.Name = "setup_archive_folderTB";
            this.setup_archive_folderTB.Size = new System.Drawing.Size(305, 26);
            this.setup_archive_folderTB.TabIndex = 4;
            this.setup_archive_folderTB.Text = "Problem";
            this.setup_archive_folderTB.TextChanged += new System.EventHandler(this.Setup_archive_folderTB_TextChanged);
            // 
            // setup_archive_folderL
            // 
            this.setup_archive_folderL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setup_archive_folderL.AutoSize = true;
            this.setup_archive_folderL.Location = new System.Drawing.Point(6, 116);
            this.setup_archive_folderL.Name = "setup_archive_folderL";
            this.setup_archive_folderL.Size = new System.Drawing.Size(57, 18);
            this.setup_archive_folderL.TabIndex = 3;
            this.setup_archive_folderL.Text = "Folder:";
            // 
            // setup_archive_inOutFilesCB
            // 
            this.setup_archive_inOutFilesCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setup_archive_inOutFilesCB.Checked = true;
            this.setup_archive_inOutFilesCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.setup_archive_inOutFilesCB.Location = new System.Drawing.Point(9, 81);
            this.setup_archive_inOutFilesCB.Name = "setup_archive_inOutFilesCB";
            this.setup_archive_inOutFilesCB.Size = new System.Drawing.Size(365, 26);
            this.setup_archive_inOutFilesCB.TabIndex = 2;
            this.setup_archive_inOutFilesCB.Text = "in/out files";
            this.setup_archive_inOutFilesCB.UseVisualStyleBackColor = true;
            this.setup_archive_inOutFilesCB.CheckedChanged += new System.EventHandler(this.Setup_archive_inOutFilesCB_CheckedChanged);
            // 
            // setup_archive_cppFilenameTB
            // 
            this.setup_archive_cppFilenameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.setup_archive_cppFilenameTB.Location = new System.Drawing.Point(112, 41);
            this.setup_archive_cppFilenameTB.Name = "setup_archive_cppFilenameTB";
            this.setup_archive_cppFilenameTB.Size = new System.Drawing.Size(218, 26);
            this.setup_archive_cppFilenameTB.TabIndex = 1;
            this.setup_archive_cppFilenameTB.Text = "problem";
            this.setup_archive_cppFilenameTB.TextChanged += new System.EventHandler(this.Setup_archive_cppFilenameTB_TextChanged);
            // 
            // setup_archive_cppFilenameL
            // 
            this.setup_archive_cppFilenameL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.setup_archive_cppFilenameL.AutoSize = true;
            this.setup_archive_cppFilenameL.Location = new System.Drawing.Point(5, 44);
            this.setup_archive_cppFilenameL.Name = "setup_archive_cppFilenameL";
            this.setup_archive_cppFilenameL.Size = new System.Drawing.Size(101, 18);
            this.setup_archive_cppFilenameL.TabIndex = 0;
            this.setup_archive_cppFilenameL.Text = "cpp filename:";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.setupTP);
            this.tabControl.Controls.Add(this.preferencesTP);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 268);
            this.tabControl.TabIndex = 0;
            // 
            // setupTP
            // 
            this.setupTP.Controls.Add(this.setup_splitContainer);
            this.setupTP.Location = new System.Drawing.Point(4, 27);
            this.setupTP.Name = "setupTP";
            this.setupTP.Padding = new System.Windows.Forms.Padding(3);
            this.setupTP.Size = new System.Drawing.Size(768, 237);
            this.setupTP.TabIndex = 0;
            this.setupTP.Text = "Setup";
            this.setupTP.UseVisualStyleBackColor = true;
            // 
            // setup_splitContainer
            // 
            this.setup_splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setup_splitContainer.IsSplitterFixed = true;
            this.setup_splitContainer.Location = new System.Drawing.Point(3, 3);
            this.setup_splitContainer.Name = "setup_splitContainer";
            // 
            // setup_splitContainer.Panel1
            // 
            this.setup_splitContainer.Panel1.Controls.Add(this.setup_tempSetupGB);
            // 
            // setup_splitContainer.Panel2
            // 
            this.setup_splitContainer.Panel2.Controls.Add(this.setup_archiveSetupGB);
            this.setup_splitContainer.Size = new System.Drawing.Size(762, 231);
            this.setup_splitContainer.SplitterDistance = 381;
            this.setup_splitContainer.SplitterWidth = 1;
            this.setup_splitContainer.TabIndex = 1;
            // 
            // preferencesTP
            // 
            this.preferencesTP.AutoScroll = true;
            this.preferencesTP.Controls.Add(this.pref_editCodeOpenPrefSC);
            this.preferencesTP.Controls.Add(this.pref_saveDataForAutocompleteCB);
            this.preferencesTP.Controls.Add(this.pref_openFilesWithTB);
            this.preferencesTP.Controls.Add(this.pref_openFilesWithL);
            this.preferencesTP.Controls.Add(this.pref_exitAfterOpenCreateCB);
            this.preferencesTP.Controls.Add(this.pref_openAfterCreateCB);
            this.preferencesTP.Controls.Add(this.pref_archiveSetupFolderB);
            this.preferencesTP.Controls.Add(this.pref_archiveSetupFolderL);
            this.preferencesTP.Controls.Add(this.pref_tempSetupFolderB);
            this.preferencesTP.Controls.Add(this.pref_tempSetupFolderL);
            this.preferencesTP.Location = new System.Drawing.Point(4, 27);
            this.preferencesTP.Name = "preferencesTP";
            this.preferencesTP.Padding = new System.Windows.Forms.Padding(3);
            this.preferencesTP.Size = new System.Drawing.Size(768, 237);
            this.preferencesTP.TabIndex = 1;
            this.preferencesTP.Text = "Preferences";
            this.preferencesTP.UseVisualStyleBackColor = true;
            // 
            // pref_editCodeOpenPrefSC
            // 
            this.pref_editCodeOpenPrefSC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pref_editCodeOpenPrefSC.IsSplitterFixed = true;
            this.pref_editCodeOpenPrefSC.Location = new System.Drawing.Point(21, 190);
            this.pref_editCodeOpenPrefSC.Name = "pref_editCodeOpenPrefSC";
            // 
            // pref_editCodeOpenPrefSC.Panel1
            // 
            this.pref_editCodeOpenPrefSC.Panel1.Controls.Add(this.pref_editStartCodeB);
            this.pref_editCodeOpenPrefSC.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            // 
            // pref_editCodeOpenPrefSC.Panel2
            // 
            this.pref_editCodeOpenPrefSC.Panel2.Controls.Add(this.pref_openPrefFolderB);
            this.pref_editCodeOpenPrefSC.Panel2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.pref_editCodeOpenPrefSC.Size = new System.Drawing.Size(684, 26);
            this.pref_editCodeOpenPrefSC.SplitterDistance = 335;
            this.pref_editCodeOpenPrefSC.SplitterWidth = 1;
            this.pref_editCodeOpenPrefSC.TabIndex = 10;
            // 
            // pref_editStartCodeB
            // 
            this.pref_editStartCodeB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pref_editStartCodeB.Location = new System.Drawing.Point(0, 0);
            this.pref_editStartCodeB.Name = "pref_editStartCodeB";
            this.pref_editStartCodeB.Size = new System.Drawing.Size(329, 26);
            this.pref_editStartCodeB.TabIndex = 6;
            this.pref_editStartCodeB.Text = "Edit Start Code";
            this.pref_editStartCodeB.UseVisualStyleBackColor = true;
            this.pref_editStartCodeB.Click += new System.EventHandler(this.Pref_editStartCodeB_Click);
            // 
            // pref_openPrefFolderB
            // 
            this.pref_openPrefFolderB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pref_openPrefFolderB.Location = new System.Drawing.Point(6, 0);
            this.pref_openPrefFolderB.Name = "pref_openPrefFolderB";
            this.pref_openPrefFolderB.Size = new System.Drawing.Size(342, 26);
            this.pref_openPrefFolderB.TabIndex = 11;
            this.pref_openPrefFolderB.Text = "Open Preferences Folder";
            this.pref_openPrefFolderB.UseVisualStyleBackColor = true;
            this.pref_openPrefFolderB.Click += new System.EventHandler(this.Pref_openPrefFolderB_Click);
            // 
            // pref_saveDataForAutocompleteCB
            // 
            this.pref_saveDataForAutocompleteCB.AutoSize = true;
            this.pref_saveDataForAutocompleteCB.Enabled = false;
            this.pref_saveDataForAutocompleteCB.Location = new System.Drawing.Point(21, 291);
            this.pref_saveDataForAutocompleteCB.Name = "pref_saveDataForAutocompleteCB";
            this.pref_saveDataForAutocompleteCB.Size = new System.Drawing.Size(218, 22);
            this.pref_saveDataForAutocompleteCB.TabIndex = 9;
            this.pref_saveDataForAutocompleteCB.Text = "Save data for autocomplete";
            this.pref_saveDataForAutocompleteCB.UseVisualStyleBackColor = true;
            this.pref_saveDataForAutocompleteCB.CheckedChanged += new System.EventHandler(this.Pref_saveDataForAutocompleteCB_CheckedChanged);
            // 
            // pref_openFilesWithTB
            // 
            this.pref_openFilesWithTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pref_openFilesWithTB.Location = new System.Drawing.Point(137, 241);
            this.pref_openFilesWithTB.Name = "pref_openFilesWithTB";
            this.pref_openFilesWithTB.Size = new System.Drawing.Size(568, 26);
            this.pref_openFilesWithTB.TabIndex = 8;
            this.pref_openFilesWithTB.Text = "explorer";
            this.pref_openFilesWithTB.TextChanged += new System.EventHandler(this.Pref_openFilesWithTB_TextChanged);
            // 
            // pref_openFilesWithL
            // 
            this.pref_openFilesWithL.AutoSize = true;
            this.pref_openFilesWithL.Location = new System.Drawing.Point(18, 244);
            this.pref_openFilesWithL.Name = "pref_openFilesWithL";
            this.pref_openFilesWithL.Size = new System.Drawing.Size(113, 18);
            this.pref_openFilesWithL.TabIndex = 7;
            this.pref_openFilesWithL.Text = "Open files with:";
            // 
            // pref_exitAfterOpenCreateCB
            // 
            this.pref_exitAfterOpenCreateCB.AutoSize = true;
            this.pref_exitAfterOpenCreateCB.Checked = true;
            this.pref_exitAfterOpenCreateCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pref_exitAfterOpenCreateCB.Location = new System.Drawing.Point(21, 146);
            this.pref_exitAfterOpenCreateCB.Name = "pref_exitAfterOpenCreateCB";
            this.pref_exitAfterOpenCreateCB.Size = new System.Drawing.Size(190, 22);
            this.pref_exitAfterOpenCreateCB.TabIndex = 5;
            this.pref_exitAfterOpenCreateCB.Text = "Exit after Open / Create";
            this.pref_exitAfterOpenCreateCB.UseVisualStyleBackColor = true;
            this.pref_exitAfterOpenCreateCB.CheckedChanged += new System.EventHandler(this.Pref_exitAfterOpenCreateCB_CheckedChanged);
            // 
            // pref_openAfterCreateCB
            // 
            this.pref_openAfterCreateCB.AutoSize = true;
            this.pref_openAfterCreateCB.Checked = true;
            this.pref_openAfterCreateCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pref_openAfterCreateCB.Location = new System.Drawing.Point(21, 118);
            this.pref_openAfterCreateCB.Name = "pref_openAfterCreateCB";
            this.pref_openAfterCreateCB.Size = new System.Drawing.Size(152, 22);
            this.pref_openAfterCreateCB.TabIndex = 4;
            this.pref_openAfterCreateCB.Text = "Open after Create";
            this.pref_openAfterCreateCB.UseVisualStyleBackColor = true;
            this.pref_openAfterCreateCB.CheckedChanged += new System.EventHandler(this.Pref_openAfterCreateCB_CheckedChanged);
            // 
            // pref_archiveSetupFolderB
            // 
            this.pref_archiveSetupFolderB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pref_archiveSetupFolderB.Location = new System.Drawing.Point(182, 71);
            this.pref_archiveSetupFolderB.Name = "pref_archiveSetupFolderB";
            this.pref_archiveSetupFolderB.Size = new System.Drawing.Size(523, 26);
            this.pref_archiveSetupFolderB.TabIndex = 3;
            this.pref_archiveSetupFolderB.Text = "C:\\";
            this.pref_archiveSetupFolderB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pref_archiveSetupFolderB.UseVisualStyleBackColor = true;
            this.pref_archiveSetupFolderB.Click += new System.EventHandler(this.Pref_archiveSetupFolderB_Click);
            // 
            // pref_archiveSetupFolderL
            // 
            this.pref_archiveSetupFolderL.AutoSize = true;
            this.pref_archiveSetupFolderL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pref_archiveSetupFolderL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pref_archiveSetupFolderL.ForeColor = System.Drawing.Color.Blue;
            this.pref_archiveSetupFolderL.Location = new System.Drawing.Point(18, 75);
            this.pref_archiveSetupFolderL.Name = "pref_archiveSetupFolderL";
            this.pref_archiveSetupFolderL.Size = new System.Drawing.Size(158, 18);
            this.pref_archiveSetupFolderL.TabIndex = 2;
            this.pref_archiveSetupFolderL.Text = "Archive Setup Folder:";
            this.pref_tempSetupFolderTT.SetToolTip(this.pref_archiveSetupFolderL, "Open the Archive Setup Folder");
            this.pref_archiveSetupFolderL.Click += new System.EventHandler(this.Pref_archiveSetupFolderL_Click);
            // 
            // pref_tempSetupFolderB
            // 
            this.pref_tempSetupFolderB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pref_tempSetupFolderB.Location = new System.Drawing.Point(168, 28);
            this.pref_tempSetupFolderB.Name = "pref_tempSetupFolderB";
            this.pref_tempSetupFolderB.Size = new System.Drawing.Size(537, 26);
            this.pref_tempSetupFolderB.TabIndex = 1;
            this.pref_tempSetupFolderB.Text = "C:\\";
            this.pref_tempSetupFolderB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pref_tempSetupFolderB.UseVisualStyleBackColor = true;
            this.pref_tempSetupFolderB.Click += new System.EventHandler(this.Pref_tempSetupFolderB_Click);
            // 
            // pref_tempSetupFolderL
            // 
            this.pref_tempSetupFolderL.AutoSize = true;
            this.pref_tempSetupFolderL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pref_tempSetupFolderL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pref_tempSetupFolderL.ForeColor = System.Drawing.Color.Blue;
            this.pref_tempSetupFolderL.Location = new System.Drawing.Point(18, 32);
            this.pref_tempSetupFolderL.Name = "pref_tempSetupFolderL";
            this.pref_tempSetupFolderL.Size = new System.Drawing.Size(144, 18);
            this.pref_tempSetupFolderL.TabIndex = 0;
            this.pref_tempSetupFolderL.Text = "Temp Setup Folder:";
            this.pref_tempSetupFolderTT.SetToolTip(this.pref_tempSetupFolderL, "Open the Temp Setup Folder");
            this.pref_tempSetupFolderL.Click += new System.EventHandler(this.Pref_tempSetupFolderL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(662, 296);
            this.Name = "MainForm";
            this.Text = "Algo Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.setup_tempSetupGB.ResumeLayout(false);
            this.setup_tempSetupGB.PerformLayout();
            this.setup_archiveSetupGB.ResumeLayout(false);
            this.setup_archiveSetupGB.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.setupTP.ResumeLayout(false);
            this.setup_splitContainer.Panel1.ResumeLayout(false);
            this.setup_splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.setup_splitContainer)).EndInit();
            this.setup_splitContainer.ResumeLayout(false);
            this.preferencesTP.ResumeLayout(false);
            this.preferencesTP.PerformLayout();
            this.pref_editCodeOpenPrefSC.Panel1.ResumeLayout(false);
            this.pref_editCodeOpenPrefSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pref_editCodeOpenPrefSC)).EndInit();
            this.pref_editCodeOpenPrefSC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox setup_tempSetupGB;
        private System.Windows.Forms.GroupBox setup_archiveSetupGB;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage setupTP;
        private System.Windows.Forms.SplitContainer setup_splitContainer;
        private System.Windows.Forms.TabPage preferencesTP;
        private System.Windows.Forms.Button setup_temp_openB;
        private System.Windows.Forms.Label setup_temp_inOutL;
        private System.Windows.Forms.CheckBox setup_temp_inOutFilesCB;
        private System.Windows.Forms.Button setup_temp_createB;
        private System.Windows.Forms.Label setup_temp_inOutFilenameL;
        private System.Windows.Forms.TextBox setup_temp_inOutFilenameTB;
        private System.Windows.Forms.Button setup_archive_openB;
        private System.Windows.Forms.Button setup_archive_createB;
        private System.Windows.Forms.Label setup_archive_cppL;
        private System.Windows.Forms.TextBox setup_archive_folderTB;
        private System.Windows.Forms.Label setup_archive_folderL;
        private System.Windows.Forms.CheckBox setup_archive_inOutFilesCB;
        private System.Windows.Forms.TextBox setup_archive_cppFilenameTB;
        private System.Windows.Forms.Label setup_archive_cppFilenameL;
        private System.Windows.Forms.Label setup_temp_cppL;
        private System.Windows.Forms.TextBox setup_temp_cppFilenameTB;
        private System.Windows.Forms.Label setup_temp_cppFilenameL;
        private System.Windows.Forms.Button pref_tempSetupFolderB;
        private System.Windows.Forms.Label pref_tempSetupFolderL;
        private System.Windows.Forms.Button pref_archiveSetupFolderB;
        private System.Windows.Forms.Label pref_archiveSetupFolderL;
        private System.Windows.Forms.CheckBox pref_exitAfterOpenCreateCB;
        private System.Windows.Forms.CheckBox pref_openAfterCreateCB;
        private System.Windows.Forms.Button pref_editStartCodeB;
        private System.Windows.Forms.TextBox pref_openFilesWithTB;
        private System.Windows.Forms.Label pref_openFilesWithL;
        private System.Windows.Forms.CheckBox pref_saveDataForAutocompleteCB;
        private System.Windows.Forms.SplitContainer pref_editCodeOpenPrefSC;
        private System.Windows.Forms.Button pref_openPrefFolderB;
        private System.Windows.Forms.ToolTip pref_tempSetupFolderTT;
    }
}

