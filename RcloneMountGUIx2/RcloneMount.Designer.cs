namespace RcloneMountGUI
{
    partial class RcloneMount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RcloneMount));
            this.txtRLocation = new System.Windows.Forms.TextBox();
            this.lblRloneLocation = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.openFileDialogRclone = new System.Windows.Forms.OpenFileDialog();
            this.btnMount = new System.Windows.Forms.Button();
            this.txtRemoteName = new System.Windows.Forms.TextBox();
            this.txtDriveLetter = new System.Windows.Forms.TextBox();
            this.btnUnmount = new System.Windows.Forms.Button();
            this.checkBoxRAAS = new System.Windows.Forms.CheckBox();
            this.notifyIconRclone = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorkerRclone = new System.ComponentModel.BackgroundWorker();
            this.btnConfig = new System.Windows.Forms.Button();
            this.checkBoxReadonly = new System.Windows.Forms.CheckBox();
            this.textBoxDriveLabel = new System.Windows.Forms.TextBox();
            this.CacheHelpLink = new System.Windows.Forms.LinkLabel();
            this.textBoxDriveLabel2 = new System.Windows.Forms.TextBox();
            this.checkBoxDriveEnabled2 = new System.Windows.Forms.CheckBox();
            this.checkBoxReadonly2 = new System.Windows.Forms.CheckBox();
            this.comboBoxMount2 = new System.Windows.Forms.ComboBox();
            this.txtRemoteName2 = new System.Windows.Forms.TextBox();
            this.CacheHelpLink2 = new System.Windows.Forms.LinkLabel();
            this.txtDriveLetter2 = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDrive = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxMount = new System.Windows.Forms.ComboBox();
            this.checkBoxDriveEnabled = new System.Windows.Forms.CheckBox();
            this.panelDrive2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelDrive.SuspendLayout();
            this.panelDrive2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRLocation
            // 
            this.txtRLocation.BackColor = System.Drawing.Color.DimGray;
            this.txtRLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtRLocation.ForeColor = System.Drawing.Color.White;
            this.txtRLocation.Location = new System.Drawing.Point(118, 17);
            this.txtRLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtRLocation.Name = "txtRLocation";
            this.txtRLocation.ReadOnly = true;
            this.txtRLocation.Size = new System.Drawing.Size(218, 25);
            this.txtRLocation.TabIndex = 0;
            this.txtRLocation.TabStop = false;
            // 
            // lblRloneLocation
            // 
            this.lblRloneLocation.AutoSize = true;
            this.lblRloneLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRloneLocation.ForeColor = System.Drawing.Color.White;
            this.lblRloneLocation.Location = new System.Drawing.Point(11, 20);
            this.lblRloneLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRloneLocation.Name = "lblRloneLocation";
            this.lblRloneLocation.Size = new System.Drawing.Size(103, 17);
            this.lblRloneLocation.TabIndex = 100;
            this.lblRloneLocation.Text = "Rclone Location:";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(340, 16);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 26);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // openFileDialogRclone
            // 
            this.openFileDialogRclone.FileName = "rclone";
            this.openFileDialogRclone.Filter = "Exe Files (.exe) |* .exe";
            // 
            // btnMount
            // 
            this.btnMount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMount.ForeColor = System.Drawing.Color.White;
            this.btnMount.Location = new System.Drawing.Point(340, 349);
            this.btnMount.Margin = new System.Windows.Forms.Padding(2);
            this.btnMount.Name = "btnMount";
            this.btnMount.Size = new System.Drawing.Size(113, 31);
            this.btnMount.TabIndex = 11;
            this.btnMount.TabStop = false;
            this.btnMount.Text = "Mount";
            this.btnMount.UseVisualStyleBackColor = false;
            this.btnMount.Click += new System.EventHandler(this.btnMount_Click);
            // 
            // txtRemoteName
            // 
            this.txtRemoteName.BackColor = System.Drawing.Color.DimGray;
            this.txtRemoteName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtRemoteName.ForeColor = System.Drawing.Color.White;
            this.txtRemoteName.Location = new System.Drawing.Point(109, 15);
            this.txtRemoteName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoteName.Name = "txtRemoteName";
            this.txtRemoteName.Size = new System.Drawing.Size(226, 25);
            this.txtRemoteName.TabIndex = 1;
            this.txtRemoteName.TabStop = false;
            // 
            // txtDriveLetter
            // 
            this.txtDriveLetter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtDriveLetter.Location = new System.Drawing.Point(422, 15);
            this.txtDriveLetter.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriveLetter.MaxLength = 1;
            this.txtDriveLetter.Name = "txtDriveLetter";
            this.txtDriveLetter.Size = new System.Drawing.Size(22, 25);
            this.txtDriveLetter.TabIndex = 2;
            this.txtDriveLetter.TabStop = false;
            this.txtDriveLetter.Text = "Z";
            // 
            // btnUnmount
            // 
            this.btnUnmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUnmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnmount.ForeColor = System.Drawing.Color.White;
            this.btnUnmount.Location = new System.Drawing.Point(458, 349);
            this.btnUnmount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnmount.Name = "btnUnmount";
            this.btnUnmount.Size = new System.Drawing.Size(113, 31);
            this.btnUnmount.TabIndex = 12;
            this.btnUnmount.TabStop = false;
            this.btnUnmount.Text = "Unmount";
            this.btnUnmount.UseVisualStyleBackColor = false;
            this.btnUnmount.Click += new System.EventHandler(this.btnUnmount_Click);
            // 
            // checkBoxRAAS
            // 
            this.checkBoxRAAS.AutoSize = true;
            this.checkBoxRAAS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxRAAS.ForeColor = System.Drawing.Color.White;
            this.checkBoxRAAS.Location = new System.Drawing.Point(179, 354);
            this.checkBoxRAAS.Name = "checkBoxRAAS";
            this.checkBoxRAAS.Size = new System.Drawing.Size(157, 21);
            this.checkBoxRAAS.TabIndex = 105;
            this.checkBoxRAAS.Text = "Auto Mount at Startup";
            this.checkBoxRAAS.UseVisualStyleBackColor = true;
            this.checkBoxRAAS.CheckedChanged += new System.EventHandler(this.checkBoxRAAS_CheckedChanged);
            // 
            // notifyIconRclone
            // 
            this.notifyIconRclone.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconRclone.BalloonTipText = "Mounted Succesfully";
            this.notifyIconRclone.BalloonTipTitle = "Rclone Mount";
            this.notifyIconRclone.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconRclone.Icon")));
            this.notifyIconRclone.Text = "Rclone Mount";
            this.notifyIconRclone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconRclone_MouseDoubleClick);
            // 
            // backgroundWorkerRclone
            // 
            this.backgroundWorkerRclone.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRclone_DoWork);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Location = new System.Drawing.Point(444, 16);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(127, 26);
            this.btnConfig.TabIndex = 106;
            this.btnConfig.TabStop = false;
            this.btnConfig.Text = "Rclone Config";
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // checkBoxReadonly
            // 
            this.checkBoxReadonly.AutoSize = true;
            this.checkBoxReadonly.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxReadonly.Location = new System.Drawing.Point(456, 17);
            this.checkBoxReadonly.Name = "checkBoxReadonly";
            this.checkBoxReadonly.Size = new System.Drawing.Size(86, 21);
            this.checkBoxReadonly.TabIndex = 107;
            this.checkBoxReadonly.Text = "Read-only";
            this.checkBoxReadonly.UseVisualStyleBackColor = true;
            // 
            // textBoxDriveLabel
            // 
            this.textBoxDriveLabel.BackColor = System.Drawing.Color.DimGray;
            this.textBoxDriveLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxDriveLabel.ForeColor = System.Drawing.Color.White;
            this.textBoxDriveLabel.Location = new System.Drawing.Point(388, 55);
            this.textBoxDriveLabel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDriveLabel.Name = "textBoxDriveLabel";
            this.textBoxDriveLabel.Size = new System.Drawing.Size(154, 25);
            this.textBoxDriveLabel.TabIndex = 114;
            this.textBoxDriveLabel.TabStop = false;
            // 
            // CacheHelpLink
            // 
            this.CacheHelpLink.AutoSize = true;
            this.CacheHelpLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CacheHelpLink.LinkColor = System.Drawing.Color.White;
            this.CacheHelpLink.Location = new System.Drawing.Point(10, 58);
            this.CacheHelpLink.Name = "CacheHelpLink";
            this.CacheHelpLink.Size = new System.Drawing.Size(90, 17);
            this.CacheHelpLink.TabIndex = 111;
            this.CacheHelpLink.TabStop = true;
            this.CacheHelpLink.Text = "Cache Option:";
            this.CacheHelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxDriveLabel2
            // 
            this.textBoxDriveLabel2.BackColor = System.Drawing.Color.DimGray;
            this.textBoxDriveLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxDriveLabel2.ForeColor = System.Drawing.Color.White;
            this.textBoxDriveLabel2.Location = new System.Drawing.Point(388, 54);
            this.textBoxDriveLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDriveLabel2.Name = "textBoxDriveLabel2";
            this.textBoxDriveLabel2.Size = new System.Drawing.Size(154, 25);
            this.textBoxDriveLabel2.TabIndex = 116;
            this.textBoxDriveLabel2.TabStop = false;
            // 
            // checkBoxDriveEnabled2
            // 
            this.checkBoxDriveEnabled2.AutoSize = true;
            this.checkBoxDriveEnabled2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxDriveEnabled2.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDriveEnabled2.Name = "checkBoxDriveEnabled2";
            this.checkBoxDriveEnabled2.Size = new System.Drawing.Size(68, 21);
            this.checkBoxDriveEnabled2.TabIndex = 113;
            this.checkBoxDriveEnabled2.Text = "Drive 2";
            this.checkBoxDriveEnabled2.UseVisualStyleBackColor = true;
            this.checkBoxDriveEnabled2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBoxReadonly2
            // 
            this.checkBoxReadonly2.AutoSize = true;
            this.checkBoxReadonly2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxReadonly2.Location = new System.Drawing.Point(456, 16);
            this.checkBoxReadonly2.Name = "checkBoxReadonly2";
            this.checkBoxReadonly2.Size = new System.Drawing.Size(86, 21);
            this.checkBoxReadonly2.TabIndex = 107;
            this.checkBoxReadonly2.Text = "Read-only";
            this.checkBoxReadonly2.UseVisualStyleBackColor = true;
            // 
            // comboBoxMount2
            // 
            this.comboBoxMount2.BackColor = System.Drawing.Color.DimGray;
            this.comboBoxMount2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMount2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxMount2.ForeColor = System.Drawing.Color.White;
            this.comboBoxMount2.Items.AddRange(new object[] {
            "--vfs-cache-mode writes",
            "--vfs-cache-mode off",
            "--vfs-cache-mode minimal",
            "--vfs-cache-mode full"});
            this.comboBoxMount2.Location = new System.Drawing.Point(109, 54);
            this.comboBoxMount2.Name = "comboBoxMount2";
            this.comboBoxMount2.Size = new System.Drawing.Size(226, 25);
            this.comboBoxMount2.TabIndex = 3;
            this.comboBoxMount2.TabStop = false;
            // 
            // txtRemoteName2
            // 
            this.txtRemoteName2.BackColor = System.Drawing.Color.DimGray;
            this.txtRemoteName2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtRemoteName2.ForeColor = System.Drawing.Color.White;
            this.txtRemoteName2.Location = new System.Drawing.Point(109, 14);
            this.txtRemoteName2.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoteName2.Name = "txtRemoteName2";
            this.txtRemoteName2.Size = new System.Drawing.Size(226, 25);
            this.txtRemoteName2.TabIndex = 1;
            this.txtRemoteName2.TabStop = false;
            // 
            // CacheHelpLink2
            // 
            this.CacheHelpLink2.AutoSize = true;
            this.CacheHelpLink2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CacheHelpLink2.LinkColor = System.Drawing.Color.White;
            this.CacheHelpLink2.Location = new System.Drawing.Point(10, 57);
            this.CacheHelpLink2.Name = "CacheHelpLink2";
            this.CacheHelpLink2.Size = new System.Drawing.Size(90, 17);
            this.CacheHelpLink2.TabIndex = 104;
            this.CacheHelpLink2.TabStop = true;
            this.CacheHelpLink2.Text = "Cache Option:";
            this.CacheHelpLink2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDocument_LinkClicked);
            // 
            // txtDriveLetter2
            // 
            this.txtDriveLetter2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtDriveLetter2.Location = new System.Drawing.Point(422, 14);
            this.txtDriveLetter2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriveLetter2.MaxLength = 1;
            this.txtDriveLetter2.Name = "txtDriveLetter2";
            this.txtDriveLetter2.Size = new System.Drawing.Size(22, 25);
            this.txtDriveLetter2.TabIndex = 2;
            this.txtDriveLetter2.TabStop = false;
            this.txtDriveLetter2.Text = "Y";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(14, 355);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 17);
            this.linkLabel2.TabIndex = 111;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Github";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(65, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 112;
            this.button1.TabStop = false;
            this.button1.Text = "Save settings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelDrive
            // 
            this.panelDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDrive.Controls.Add(this.textBoxDriveLabel);
            this.panelDrive.Controls.Add(this.CacheHelpLink);
            this.panelDrive.Controls.Add(this.label5);
            this.panelDrive.Controls.Add(this.comboBoxMount);
            this.panelDrive.Controls.Add(this.txtRemoteName);
            this.panelDrive.Controls.Add(this.checkBoxReadonly);
            this.panelDrive.Controls.Add(this.label7);
            this.panelDrive.Controls.Add(this.txtDriveLetter);
            this.panelDrive.Controls.Add(this.label6);
            this.panelDrive.ForeColor = System.Drawing.Color.White;
            this.panelDrive.Location = new System.Drawing.Point(14, 90);
            this.panelDrive.Name = "panelDrive";
            this.panelDrive.Size = new System.Drawing.Size(557, 94);
            this.panelDrive.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(342, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 113;
            this.label5.Text = "Label:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 101;
            this.label6.Text = "Remote Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(342, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 102;
            this.label7.Text = "Drive Letter:";
            // 
            // comboBoxMount
            // 
            this.comboBoxMount.BackColor = System.Drawing.Color.DimGray;
            this.comboBoxMount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxMount.ForeColor = System.Drawing.Color.White;
            this.comboBoxMount.Items.AddRange(new object[] {
            "--vfs-cache-mode writes",
            "--vfs-cache-mode off",
            "--vfs-cache-mode minimal",
            "--vfs-cache-mode full"});
            this.comboBoxMount.Location = new System.Drawing.Point(109, 55);
            this.comboBoxMount.Name = "comboBoxMount";
            this.comboBoxMount.Size = new System.Drawing.Size(226, 25);
            this.comboBoxMount.TabIndex = 3;
            this.comboBoxMount.TabStop = false;
            this.comboBoxMount.SelectedIndexChanged += new System.EventHandler(this.comboBoxMount_SelectedIndexChanged);
            // 
            // checkBoxDriveEnabled
            // 
            this.checkBoxDriveEnabled.AutoSize = true;
            this.checkBoxDriveEnabled.Checked = true;
            this.checkBoxDriveEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDriveEnabled.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxDriveEnabled.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDriveEnabled.Name = "checkBoxDriveEnabled";
            this.checkBoxDriveEnabled.Size = new System.Drawing.Size(68, 21);
            this.checkBoxDriveEnabled.TabIndex = 112;
            this.checkBoxDriveEnabled.Text = "Drive 1";
            this.checkBoxDriveEnabled.UseVisualStyleBackColor = true;
            this.checkBoxDriveEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelDrive2
            // 
            this.panelDrive2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelDrive2.Controls.Add(this.textBoxDriveLabel2);
            this.panelDrive2.Controls.Add(this.CacheHelpLink2);
            this.panelDrive2.Controls.Add(this.checkBoxReadonly2);
            this.panelDrive2.Controls.Add(this.label3);
            this.panelDrive2.Controls.Add(this.comboBoxMount2);
            this.panelDrive2.Controls.Add(this.txtDriveLetter2);
            this.panelDrive2.Controls.Add(this.txtRemoteName2);
            this.panelDrive2.Controls.Add(this.label8);
            this.panelDrive2.Controls.Add(this.label9);
            this.panelDrive2.ForeColor = System.Drawing.Color.White;
            this.panelDrive2.Location = new System.Drawing.Point(14, 234);
            this.panelDrive2.Name = "panelDrive2";
            this.panelDrive2.Size = new System.Drawing.Size(557, 94);
            this.panelDrive2.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(342, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Label:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(342, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "Drive Letter:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(10, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 101;
            this.label9.Text = "Remote Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.checkBoxDriveEnabled2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(14, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 28);
            this.panel1.TabIndex = 115;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.checkBoxDriveEnabled);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(14, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 28);
            this.panel2.TabIndex = 116;
            // 
            // RcloneMount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(586, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDrive2);
            this.Controls.Add(this.panelDrive);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.btnMount);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnUnmount);
            this.Controls.Add(this.checkBoxRAAS);
            this.Controls.Add(this.lblRloneLocation);
            this.Controls.Add(this.txtRLocation);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "RcloneMount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RcloneMountGUIx2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RcloneMount_FormClosed);
            this.Load += new System.EventHandler(this.RcloneMount_Load);
            this.Resize += new System.EventHandler(this.RcloneMount_Resize);
            this.panelDrive.ResumeLayout(false);
            this.panelDrive.PerformLayout();
            this.panelDrive2.ResumeLayout(false);
            this.panelDrive2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRLocation;
        private System.Windows.Forms.Label lblRloneLocation;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialogRclone;
        private System.Windows.Forms.Button btnMount;
        private System.Windows.Forms.TextBox txtRemoteName;
        private System.Windows.Forms.TextBox txtDriveLetter;
        private System.Windows.Forms.Button btnUnmount;
        private System.Windows.Forms.CheckBox checkBoxRAAS;
        private System.Windows.Forms.NotifyIcon notifyIconRclone;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRclone;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.CheckBox checkBoxReadonly;
        private System.Windows.Forms.CheckBox checkBoxReadonly2;
        private System.Windows.Forms.ComboBox comboBoxMount2;
        private System.Windows.Forms.TextBox txtRemoteName2;
        private System.Windows.Forms.TextBox txtDriveLetter2;
        private System.Windows.Forms.LinkLabel CacheHelpLink2;
        private System.Windows.Forms.LinkLabel CacheHelpLink;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBoxDriveEnabled2;
        private System.Windows.Forms.TextBox textBoxDriveLabel;
        private System.Windows.Forms.TextBox textBoxDriveLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDrive;
        private System.Windows.Forms.CheckBox checkBoxDriveEnabled;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelDrive2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

