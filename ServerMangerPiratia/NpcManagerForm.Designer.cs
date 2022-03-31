namespace ServerManagerPiratia
{
    partial class NpcManagerForm
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

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NpcManagerForm));
            this.labTitle = new System.Windows.Forms.Label();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.buttonMakeNpcFile = new System.Windows.Forms.Button();
            this.textBoxNpcModel = new System.Windows.Forms.TextBox();
            this.buttonNpcRemove = new System.Windows.Forms.Button();
            this.textBoxNpcScript = new System.Windows.Forms.TextBox();
            this.buttonNpcAdd = new System.Windows.Forms.Button();
            this.labelNpcScript = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxNpcLocation = new System.Windows.Forms.TextBox();
            this.labelNpcLocation = new System.Windows.Forms.Label();
            this.textNpcAngle = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxNpcAngle = new System.Windows.Forms.PictureBox();
            this.labelNpcAngle = new System.Windows.Forms.Label();
            this.textBoxNpcPosY = new System.Windows.Forms.TextBox();
            this.labelNpcPosY = new System.Windows.Forms.Label();
            this.textBoxNpcPosX = new System.Windows.Forms.TextBox();
            this.labelNpcPosX = new System.Windows.Forms.Label();
            this.labelNpcPos = new System.Windows.Forms.Label();
            this.comboBoxNpcIcon = new System.Windows.Forms.ComboBox();
            this.labelNpcIcon = new System.Windows.Forms.Label();
            this.labelNpcModel = new System.Windows.Forms.Label();
            this.textBoxNpcName = new System.Windows.Forms.TextBox();
            this.labelNpcName = new System.Windows.Forms.Label();
            this.textBoxNpcID = new System.Windows.Forms.TextBox();
            this.labelNpcID = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.listBoxNpc = new System.Windows.Forms.ListBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxHeader.SuspendLayout();
            this.panelBackground.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNpcAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNpcAngle)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.groupBoxLeft.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Segoe UI", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTitle.Location = new System.Drawing.Point(8, 10);
            this.labTitle.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(251, 30);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "NPC Manager (*npc.txt)";
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHeader.Controls.Add(this.buttonPath);
            this.groupBoxHeader.Controls.Add(this.textBoxPath);
            this.groupBoxHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxHeader.Location = new System.Drawing.Point(8, 56);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxHeader.Size = new System.Drawing.Size(1006, 58);
            this.groupBoxHeader.TabIndex = 1;
            this.groupBoxHeader.TabStop = false;
            this.groupBoxHeader.Text = "Path to file with NPC";
            // 
            // buttonPath
            // 
            this.buttonPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPath.Location = new System.Drawing.Point(972, 24);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(25, 23);
            this.buttonPath.TabIndex = 2;
            this.buttonPath.Text = "...";
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.ButtonPath_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPath.Location = new System.Drawing.Point(7, 24);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(959, 23);
            this.textBoxPath.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.Filter = "NPC list (*.txt)|*.txt";
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackground.Controls.Add(this.panelMain);
            this.panelBackground.Controls.Add(this.panelLeft);
            this.panelBackground.Controls.Add(this.panelHeader);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1024, 800);
            this.panelBackground.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.groupBoxMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(352, 120);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(8);
            this.panelMain.Size = new System.Drawing.Size(670, 678);
            this.panelMain.TabIndex = 3;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.AutoSize = true;
            this.groupBoxMain.Controls.Add(this.textBoxNpcModel);
            this.groupBoxMain.Controls.Add(this.textBoxNpcScript);
            this.groupBoxMain.Controls.Add(this.labelNpcScript);
            this.groupBoxMain.Controls.Add(this.textBoxNpcLocation);
            this.groupBoxMain.Controls.Add(this.labelNpcLocation);
            this.groupBoxMain.Controls.Add(this.textNpcAngle);
            this.groupBoxMain.Controls.Add(this.pictureBoxNpcAngle);
            this.groupBoxMain.Controls.Add(this.labelNpcAngle);
            this.groupBoxMain.Controls.Add(this.textBoxNpcPosY);
            this.groupBoxMain.Controls.Add(this.labelNpcPosY);
            this.groupBoxMain.Controls.Add(this.textBoxNpcPosX);
            this.groupBoxMain.Controls.Add(this.labelNpcPosX);
            this.groupBoxMain.Controls.Add(this.labelNpcPos);
            this.groupBoxMain.Controls.Add(this.comboBoxNpcIcon);
            this.groupBoxMain.Controls.Add(this.labelNpcIcon);
            this.groupBoxMain.Controls.Add(this.labelNpcModel);
            this.groupBoxMain.Controls.Add(this.textBoxNpcName);
            this.groupBoxMain.Controls.Add(this.labelNpcName);
            this.groupBoxMain.Controls.Add(this.textBoxNpcID);
            this.groupBoxMain.Controls.Add(this.labelNpcID);
            this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxMain.Location = new System.Drawing.Point(8, 8);
            this.groupBoxMain.Margin = new System.Windows.Forms.Padding(8);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxMain.Size = new System.Drawing.Size(654, 662);
            this.groupBoxMain.TabIndex = 2;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "{NPC}";
            // 
            // buttonMakeNpcFile
            // 
            this.buttonMakeNpcFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMakeNpcFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMakeNpcFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMakeNpcFile.Location = new System.Drawing.Point(233, 628);
            this.buttonMakeNpcFile.Name = "buttonMakeNpcFile";
            this.buttonMakeNpcFile.Size = new System.Drawing.Size(100, 23);
            this.buttonMakeNpcFile.TabIndex = 4;
            this.buttonMakeNpcFile.Text = "New *npc.txt file";
            this.buttonMakeNpcFile.UseVisualStyleBackColor = true;
            this.buttonMakeNpcFile.Click += new System.EventHandler(this.ButtonMakeNpcFile_Click);
            // 
            // textBoxNpcModel
            // 
            this.textBoxNpcModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNpcModel.Location = new System.Drawing.Point(11, 102);
            this.textBoxNpcModel.Name = "textBoxNpcModel";
            this.textBoxNpcModel.Size = new System.Drawing.Size(217, 23);
            this.textBoxNpcModel.TabIndex = 22;
            this.textBoxNpcModel.Text = "{Model}";
            this.textBoxNpcModel.TextChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // buttonNpcRemove
            // 
            this.buttonNpcRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNpcRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNpcRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNpcRemove.Location = new System.Drawing.Point(5, 588);
            this.buttonNpcRemove.Name = "buttonNpcRemove";
            this.buttonNpcRemove.Size = new System.Drawing.Size(328, 23);
            this.buttonNpcRemove.TabIndex = 3;
            this.buttonNpcRemove.Text = "[-] Remove NPC";
            this.buttonNpcRemove.UseVisualStyleBackColor = true;
            this.buttonNpcRemove.Click += new System.EventHandler(this.ButtonNpcRemove_Click);
            // 
            // textBoxNpcScript
            // 
            this.textBoxNpcScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNpcScript.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNpcScript.Location = new System.Drawing.Point(10, 508);
            this.textBoxNpcScript.Name = "textBoxNpcScript";
            this.textBoxNpcScript.Size = new System.Drawing.Size(633, 23);
            this.textBoxNpcScript.TabIndex = 21;
            this.textBoxNpcScript.Text = "{Script}";
            this.textBoxNpcScript.TextChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // buttonNpcAdd
            // 
            this.buttonNpcAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNpcAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNpcAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonNpcAdd.Location = new System.Drawing.Point(5, 557);
            this.buttonNpcAdd.Name = "buttonNpcAdd";
            this.buttonNpcAdd.Size = new System.Drawing.Size(328, 23);
            this.buttonNpcAdd.TabIndex = 2;
            this.buttonNpcAdd.Text = "[+] Add new NPC";
            this.buttonNpcAdd.UseVisualStyleBackColor = true;
            this.buttonNpcAdd.Click += new System.EventHandler(this.ButtonNpcAdd_Click);
            // 
            // labelNpcScript
            // 
            this.labelNpcScript.AutoSize = true;
            this.labelNpcScript.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNpcScript.Location = new System.Drawing.Point(10, 490);
            this.labelNpcScript.Name = "labelNpcScript";
            this.labelNpcScript.Size = new System.Drawing.Size(43, 15);
            this.labelNpcScript.TabIndex = 20;
            this.labelNpcScript.Text = "Script:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(5, 628);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save NPC list";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textBoxNpcLocation
            // 
            this.textBoxNpcLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNpcLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNpcLocation.Location = new System.Drawing.Point(10, 448);
            this.textBoxNpcLocation.Name = "textBoxNpcLocation";
            this.textBoxNpcLocation.Size = new System.Drawing.Size(633, 23);
            this.textBoxNpcLocation.TabIndex = 19;
            this.textBoxNpcLocation.Text = "{Location}";
            this.textBoxNpcLocation.TextChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // labelNpcLocation
            // 
            this.labelNpcLocation.AutoSize = true;
            this.labelNpcLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNpcLocation.Location = new System.Drawing.Point(10, 430);
            this.labelNpcLocation.Name = "labelNpcLocation";
            this.labelNpcLocation.Size = new System.Drawing.Size(57, 15);
            this.labelNpcLocation.TabIndex = 18;
            this.labelNpcLocation.Text = "Location:";
            // 
            // textNpcAngle
            // 
            this.textNpcAngle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNpcAngle.Location = new System.Drawing.Point(148, 337);
            this.textNpcAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.textNpcAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.textNpcAngle.Name = "textNpcAngle";
            this.textNpcAngle.Size = new System.Drawing.Size(80, 23);
            this.textNpcAngle.TabIndex = 17;
            this.textNpcAngle.ValueChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // pictureBoxNpcAngle
            // 
            this.pictureBoxNpcAngle.Location = new System.Drawing.Point(10, 285);
            this.pictureBoxNpcAngle.Name = "pictureBoxNpcAngle";
            this.pictureBoxNpcAngle.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxNpcAngle.TabIndex = 16;
            this.pictureBoxNpcAngle.TabStop = false;
            this.pictureBoxNpcAngle.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxNpcAngle_Paint);
            // 
            // labelNpcAngle
            // 
            this.labelNpcAngle.AutoSize = true;
            this.labelNpcAngle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNpcAngle.Location = new System.Drawing.Point(10, 264);
            this.labelNpcAngle.Name = "labelNpcAngle";
            this.labelNpcAngle.Size = new System.Drawing.Size(71, 15);
            this.labelNpcAngle.TabIndex = 15;
            this.labelNpcAngle.Text = "View angle:";
            // 
            // textBoxNpcPosY
            // 
            this.textBoxNpcPosY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNpcPosY.Location = new System.Drawing.Point(148, 227);
            this.textBoxNpcPosY.Name = "textBoxNpcPosY";
            this.textBoxNpcPosY.Size = new System.Drawing.Size(80, 23);
            this.textBoxNpcPosY.TabIndex = 14;
            this.textBoxNpcPosY.Text = "{Y}";
            this.textBoxNpcPosY.TextChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // labelNpcPosY
            // 
            this.labelNpcPosY.AutoSize = true;
            this.labelNpcPosY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNpcPosY.Location = new System.Drawing.Point(125, 230);
            this.labelNpcPosY.Name = "labelNpcPosY";
            this.labelNpcPosY.Size = new System.Drawing.Size(17, 15);
            this.labelNpcPosY.TabIndex = 13;
            this.labelNpcPosY.Text = "Y:";
            // 
            // textBoxNpcPosX
            // 
            this.textBoxNpcPosX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNpcPosX.Location = new System.Drawing.Point(35, 227);
            this.textBoxNpcPosX.Name = "textBoxNpcPosX";
            this.textBoxNpcPosX.Size = new System.Drawing.Size(80, 23);
            this.textBoxNpcPosX.TabIndex = 12;
            this.textBoxNpcPosX.Text = "{X}";
            this.textBoxNpcPosX.TextChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // labelNpcPosX
            // 
            this.labelNpcPosX.AutoSize = true;
            this.labelNpcPosX.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNpcPosX.Location = new System.Drawing.Point(10, 230);
            this.labelNpcPosX.Name = "labelNpcPosX";
            this.labelNpcPosX.Size = new System.Drawing.Size(17, 15);
            this.labelNpcPosX.TabIndex = 11;
            this.labelNpcPosX.Text = "X:";
            // 
            // labelNpcPos
            // 
            this.labelNpcPos.AutoSize = true;
            this.labelNpcPos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNpcPos.Location = new System.Drawing.Point(10, 204);
            this.labelNpcPos.Name = "labelNpcPos";
            this.labelNpcPos.Size = new System.Drawing.Size(76, 15);
            this.labelNpcPos.TabIndex = 10;
            this.labelNpcPos.Text = "Coordinates:";
            // 
            // comboBoxNpcIcon
            // 
            this.comboBoxNpcIcon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxNpcIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNpcIcon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxNpcIcon.FormattingEnabled = true;
            this.comboBoxNpcIcon.ItemHeight = 20;
            this.comboBoxNpcIcon.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.comboBoxNpcIcon.Location = new System.Drawing.Point(10, 162);
            this.comboBoxNpcIcon.Name = "comboBoxNpcIcon";
            this.comboBoxNpcIcon.Size = new System.Drawing.Size(218, 26);
            this.comboBoxNpcIcon.TabIndex = 9;
            this.comboBoxNpcIcon.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxNpcIcon_DrawItem);
            this.comboBoxNpcIcon.SelectedIndexChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // labelNpcIcon
            // 
            this.labelNpcIcon.AutoSize = true;
            this.labelNpcIcon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNpcIcon.Location = new System.Drawing.Point(10, 144);
            this.labelNpcIcon.Name = "labelNpcIcon";
            this.labelNpcIcon.Size = new System.Drawing.Size(84, 15);
            this.labelNpcIcon.TabIndex = 8;
            this.labelNpcIcon.Text = "Minimap icon:";
            // 
            // labelNpcModel
            // 
            this.labelNpcModel.AutoSize = true;
            this.labelNpcModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNpcModel.Location = new System.Drawing.Point(10, 84);
            this.labelNpcModel.Name = "labelNpcModel";
            this.labelNpcModel.Size = new System.Drawing.Size(195, 15);
            this.labelNpcModel.TabIndex = 6;
            this.labelNpcModel.Text = "Model (id from characterinfo.txt):";
            // 
            // textBoxNpcName
            // 
            this.textBoxNpcName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNpcName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNpcName.Location = new System.Drawing.Point(253, 42);
            this.textBoxNpcName.Name = "textBoxNpcName";
            this.textBoxNpcName.Size = new System.Drawing.Size(390, 23);
            this.textBoxNpcName.TabIndex = 5;
            this.textBoxNpcName.Text = "{Name}";
            this.textBoxNpcName.TextChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // labelNpcName
            // 
            this.labelNpcName.AutoSize = true;
            this.labelNpcName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNpcName.Location = new System.Drawing.Point(253, 24);
            this.labelNpcName.Name = "labelNpcName";
            this.labelNpcName.Size = new System.Drawing.Size(43, 15);
            this.labelNpcName.TabIndex = 2;
            this.labelNpcName.Text = "Name:";
            // 
            // textBoxNpcID
            // 
            this.textBoxNpcID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNpcID.Location = new System.Drawing.Point(10, 42);
            this.textBoxNpcID.Name = "textBoxNpcID";
            this.textBoxNpcID.Size = new System.Drawing.Size(218, 23);
            this.textBoxNpcID.TabIndex = 1;
            this.textBoxNpcID.Text = "{ID}";
            this.textBoxNpcID.TextChanged += new System.EventHandler(this.FieldNpc_Changed);
            // 
            // labelNpcID
            // 
            this.labelNpcID.AutoSize = true;
            this.labelNpcID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNpcID.Location = new System.Drawing.Point(10, 24);
            this.labelNpcID.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelNpcID.Name = "labelNpcID";
            this.labelNpcID.Size = new System.Drawing.Size(23, 15);
            this.labelNpcID.TabIndex = 0;
            this.labelNpcID.Text = "ID:";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.groupBoxLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 120);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(8);
            this.panelLeft.Size = new System.Drawing.Size(352, 678);
            this.panelLeft.TabIndex = 2;
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.AutoSize = true;
            this.groupBoxLeft.Controls.Add(this.buttonMakeNpcFile);
            this.groupBoxLeft.Controls.Add(this.listBoxNpc);
            this.groupBoxLeft.Controls.Add(this.buttonNpcAdd);
            this.groupBoxLeft.Controls.Add(this.buttonSave);
            this.groupBoxLeft.Controls.Add(this.buttonNpcRemove);
            this.groupBoxLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLeft.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxLeft.Location = new System.Drawing.Point(8, 8);
            this.groupBoxLeft.Margin = new System.Windows.Forms.Padding(8);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Padding = new System.Windows.Forms.Padding(8);
            this.groupBoxLeft.Size = new System.Drawing.Size(336, 662);
            this.groupBoxLeft.TabIndex = 1;
            this.groupBoxLeft.TabStop = false;
            this.groupBoxLeft.Text = "{NPC_list}";
            // 
            // listBoxNpc
            // 
            this.listBoxNpc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxNpc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxNpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxNpc.FormattingEnabled = true;
            this.listBoxNpc.HorizontalScrollbar = true;
            this.listBoxNpc.ItemHeight = 20;
            this.listBoxNpc.Location = new System.Drawing.Point(5, 27);
            this.listBoxNpc.Name = "listBoxNpc";
            this.listBoxNpc.Size = new System.Drawing.Size(328, 524);
            this.listBoxNpc.TabIndex = 0;
            this.listBoxNpc.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxNpc_DrawItem);
            this.listBoxNpc.SelectedIndexChanged += new System.EventHandler(this.ListBoxNpc_SelectedIndexChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labTitle);
            this.panelHeader.Controls.Add(this.groupBoxHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1022, 120);
            this.panelHeader.TabIndex = 1;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Black;
            this.imageList.Images.SetKeyName(0, "10.bmp");
            this.imageList.Images.SetKeyName(1, "1.bmp");
            this.imageList.Images.SetKeyName(2, "2.bmp");
            this.imageList.Images.SetKeyName(3, "3.bmp");
            this.imageList.Images.SetKeyName(4, "4.bmp");
            this.imageList.Images.SetKeyName(5, "5.bmp");
            this.imageList.Images.SetKeyName(6, "6.bmp");
            this.imageList.Images.SetKeyName(7, "7.bmp");
            this.imageList.Images.SetKeyName(8, "8.bmp");
            this.imageList.Images.SetKeyName(9, "9.bmp");
            this.imageList.Images.SetKeyName(10, "11.bmp");
            this.imageList.Images.SetKeyName(11, "12.bmp");
            this.imageList.Images.SetKeyName(12, "13.bmp");
            this.imageList.Images.SetKeyName(13, "14.bmp");
            this.imageList.Images.SetKeyName(14, "arraw.bmp");
            this.imageList.Images.SetKeyName(15, "15.bmp");
            this.imageList.Images.SetKeyName(16, "shop.bmp");
            this.imageList.Images.SetKeyName(17, "0.bmp");
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "NPC list (*.txt)|*.txt";
            // 
            // NpcManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1024, 800);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NpcManagerForm";
            this.Text = "NpcManagerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NpcManagerForm_FormClosing);
            this.Shown += new System.EventHandler(this.NpcManagerForm_Shown);
            this.groupBoxHeader.ResumeLayout(false);
            this.groupBoxHeader.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textNpcAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNpcAngle)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.groupBoxLeft.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label labTitle;
        private GroupBox groupBoxHeader;
        private TextBox textBoxPath;
        private Button buttonPath;
        private OpenFileDialog openFileDialog;
        private Panel panelBackground;
        private Panel panelHeader;
        private Panel panelLeft;
        private GroupBox groupBoxLeft;
        private ListBox listBoxNpc;
        private Panel panelMain;
        private GroupBox groupBoxMain;
        private TextBox textBoxNpcName;
        private Label labelNpcName;
        private TextBox textBoxNpcID;
        private Label labelNpcID;
        private Label labelNpcModel;
        private TextBox textBoxNpcScript;
        private Label labelNpcScript;
        private TextBox textBoxNpcLocation;
        private Label labelNpcLocation;
        private NumericUpDown textNpcAngle;
        private PictureBox pictureBoxNpcAngle;
        private Label labelNpcAngle;
        private TextBox textBoxNpcPosY;
        private Label labelNpcPosY;
        private TextBox textBoxNpcPosX;
        private Label labelNpcPosX;
        private Label labelNpcPos;
        private ComboBox comboBoxNpcIcon;
        private Label labelNpcIcon;
        private Button buttonNpcRemove;
        private Button buttonNpcAdd;
        private Button buttonSave;
        private ImageList imageList;
        private SaveFileDialog saveFileDialog;
        private TextBox textBoxNpcModel;
        private Button buttonMakeNpcFile;
    }
}