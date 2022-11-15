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
            this.comboBoxMount = new System.Windows.Forms.ComboBox();
            this.lblRemoteName = new System.Windows.Forms.Label();
            this.txtRemoteName = new System.Windows.Forms.TextBox();
            this.lblDriveLetter = new System.Windows.Forms.Label();
            this.txtDriveLetter = new System.Windows.Forms.TextBox();
            this.btnUnmount = new System.Windows.Forms.Button();
            this.checkBoxRAAS = new System.Windows.Forms.CheckBox();
            this.notifyIconRclone = new System.Windows.Forms.NotifyIcon(this.components);
            this.backgroundWorkerRclone = new System.ComponentModel.BackgroundWorker();
            this.btnConfig = new System.Windows.Forms.Button();
            this.checkBoxReadonly = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxReadonly2 = new System.Windows.Forms.CheckBox();
            this.comboBoxMount2 = new System.Windows.Forms.ComboBox();
            this.txtRemoteName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDriveLetter2 = new System.Windows.Forms.TextBox();
            this.CacheHelpLink2 = new System.Windows.Forms.LinkLabel();
            this.CacheHelpLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBoxDriveEnabled = new System.Windows.Forms.CheckBox();
            this.checkBoxDriveEnabled2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDriveLabel = new System.Windows.Forms.TextBox();
            this.textBoxDriveLabel2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRLocation
            // 
            this.txtRLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtRLocation.Location = new System.Drawing.Point(118, 17);
            this.txtRLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtRLocation.Name = "txtRLocation";
            this.txtRLocation.ReadOnly = true;
            this.txtRLocation.Size = new System.Drawing.Size(241, 25);
            this.txtRLocation.TabIndex = 0;
            this.txtRLocation.TabStop = false;
            // 
            // lblRloneLocation
            // 
            this.lblRloneLocation.AutoSize = true;
            this.lblRloneLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRloneLocation.Location = new System.Drawing.Point(11, 20);
            this.lblRloneLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRloneLocation.Name = "lblRloneLocation";
            this.lblRloneLocation.Size = new System.Drawing.Size(103, 17);
            this.lblRloneLocation.TabIndex = 100;
            this.lblRloneLocation.Text = "Rclone Location:";
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSelect.Location = new System.Drawing.Point(363, 17);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 26);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // openFileDialogRclone
            // 
            this.openFileDialogRclone.FileName = "rclone";
            this.openFileDialogRclone.Filter = "Exe Files (.exe) |* .exe";
            // 
            // btnMount
            // 
            this.btnMount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMount.Location = new System.Drawing.Point(230, 295);
            this.btnMount.Margin = new System.Windows.Forms.Padding(2);
            this.btnMount.Name = "btnMount";
            this.btnMount.Size = new System.Drawing.Size(155, 25);
            this.btnMount.TabIndex = 11;
            this.btnMount.TabStop = false;
            this.btnMount.Text = "Mount";
            this.btnMount.UseVisualStyleBackColor = true;
            this.btnMount.Click += new System.EventHandler(this.btnMount_Click);
            // 
            // comboBoxMount
            // 
            this.comboBoxMount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxMount.Items.AddRange(new object[] {
            "--vfs-cache-mode writes",
            "--vfs-cache-mode off",
            "--vfs-cache-mode minimal",
            "--vfs-cache-mode full"});
            this.comboBoxMount.Location = new System.Drawing.Point(104, 60);
            this.comboBoxMount.Name = "comboBoxMount";
            this.comboBoxMount.Size = new System.Drawing.Size(206, 25);
            this.comboBoxMount.TabIndex = 3;
            this.comboBoxMount.TabStop = false;
            this.comboBoxMount.SelectedIndexChanged += new System.EventHandler(this.comboBoxMount_SelectedIndexChanged);
            // 
            // lblRemoteName
            // 
            this.lblRemoteName.AutoSize = true;
            this.lblRemoteName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblRemoteName.Location = new System.Drawing.Point(5, 23);
            this.lblRemoteName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoteName.Name = "lblRemoteName";
            this.lblRemoteName.Size = new System.Drawing.Size(95, 17);
            this.lblRemoteName.TabIndex = 101;
            this.lblRemoteName.Text = "Remote Name:";
            // 
            // txtRemoteName
            // 
            this.txtRemoteName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtRemoteName.Location = new System.Drawing.Point(104, 20);
            this.txtRemoteName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoteName.Name = "txtRemoteName";
            this.txtRemoteName.Size = new System.Drawing.Size(206, 25);
            this.txtRemoteName.TabIndex = 1;
            this.txtRemoteName.TabStop = false;
            // 
            // lblDriveLetter
            // 
            this.lblDriveLetter.AutoSize = true;
            this.lblDriveLetter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDriveLetter.Location = new System.Drawing.Point(321, 23);
            this.lblDriveLetter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDriveLetter.Name = "lblDriveLetter";
            this.lblDriveLetter.Size = new System.Drawing.Size(78, 17);
            this.lblDriveLetter.TabIndex = 102;
            this.lblDriveLetter.Text = "Drive Letter:";
            // 
            // txtDriveLetter
            // 
            this.txtDriveLetter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtDriveLetter.Location = new System.Drawing.Point(403, 20);
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
            this.btnUnmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUnmount.Location = new System.Drawing.Point(389, 295);
            this.btnUnmount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnmount.Name = "btnUnmount";
            this.btnUnmount.Size = new System.Drawing.Size(155, 25);
            this.btnUnmount.TabIndex = 12;
            this.btnUnmount.TabStop = false;
            this.btnUnmount.Text = "Unmount";
            this.btnUnmount.UseVisualStyleBackColor = true;
            this.btnUnmount.Click += new System.EventHandler(this.btnUnmount_Click);
            // 
            // checkBoxRAAS
            // 
            this.checkBoxRAAS.AutoSize = true;
            this.checkBoxRAAS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxRAAS.Location = new System.Drawing.Point(68, 297);
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
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConfig.Location = new System.Drawing.Point(447, 17);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(100, 26);
            this.btnConfig.TabIndex = 106;
            this.btnConfig.TabStop = false;
            this.btnConfig.Text = "Config";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // checkBoxReadonly
            // 
            this.checkBoxReadonly.AutoSize = true;
            this.checkBoxReadonly.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxReadonly.Location = new System.Drawing.Point(437, 22);
            this.checkBoxReadonly.Name = "checkBoxReadonly";
            this.checkBoxReadonly.Size = new System.Drawing.Size(86, 21);
            this.checkBoxReadonly.TabIndex = 107;
            this.checkBoxReadonly.Text = "Read-only";
            this.checkBoxReadonly.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.textBoxDriveLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxDriveEnabled);
            this.groupBox1.Controls.Add(this.CacheHelpLink);
            this.groupBox1.Controls.Add(this.lblRemoteName);
            this.groupBox1.Controls.Add(this.checkBoxReadonly);
            this.groupBox1.Controls.Add(this.comboBoxMount);
            this.groupBox1.Controls.Add(this.txtRemoteName);
            this.groupBox1.Controls.Add(this.lblDriveLetter);
            this.groupBox1.Controls.Add(this.txtDriveLetter);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(14, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 100);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.textBoxDriveLabel2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.checkBoxDriveEnabled2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxReadonly2);
            this.groupBox2.Controls.Add(this.comboBoxMount2);
            this.groupBox2.Controls.Add(this.txtRemoteName2);
            this.groupBox2.Controls.Add(this.CacheHelpLink2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDriveLetter2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(14, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 96);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Remote Name:";
            // 
            // checkBoxReadonly2
            // 
            this.checkBoxReadonly2.AutoSize = true;
            this.checkBoxReadonly2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxReadonly2.Location = new System.Drawing.Point(437, 22);
            this.checkBoxReadonly2.Name = "checkBoxReadonly2";
            this.checkBoxReadonly2.Size = new System.Drawing.Size(86, 21);
            this.checkBoxReadonly2.TabIndex = 107;
            this.checkBoxReadonly2.Text = "Read-only";
            this.checkBoxReadonly2.UseVisualStyleBackColor = true;
            // 
            // comboBoxMount2
            // 
            this.comboBoxMount2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMount2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBoxMount2.Items.AddRange(new object[] {
            "--vfs-cache-mode writes",
            "--vfs-cache-mode off",
            "--vfs-cache-mode minimal",
            "--vfs-cache-mode full"});
            this.comboBoxMount2.Location = new System.Drawing.Point(104, 58);
            this.comboBoxMount2.Name = "comboBoxMount2";
            this.comboBoxMount2.Size = new System.Drawing.Size(206, 25);
            this.comboBoxMount2.TabIndex = 3;
            this.comboBoxMount2.TabStop = false;
            // 
            // txtRemoteName2
            // 
            this.txtRemoteName2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtRemoteName2.Location = new System.Drawing.Point(104, 20);
            this.txtRemoteName2.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemoteName2.Name = "txtRemoteName2";
            this.txtRemoteName2.Size = new System.Drawing.Size(206, 25);
            this.txtRemoteName2.TabIndex = 1;
            this.txtRemoteName2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(321, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 102;
            this.label2.Text = "Drive Letter:";
            // 
            // txtDriveLetter2
            // 
            this.txtDriveLetter2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtDriveLetter2.Location = new System.Drawing.Point(403, 20);
            this.txtDriveLetter2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDriveLetter2.MaxLength = 1;
            this.txtDriveLetter2.Name = "txtDriveLetter2";
            this.txtDriveLetter2.Size = new System.Drawing.Size(22, 25);
            this.txtDriveLetter2.TabIndex = 2;
            this.txtDriveLetter2.TabStop = false;
            this.txtDriveLetter2.Text = "Y";
            // 
            // CacheHelpLink2
            // 
            this.CacheHelpLink2.AutoSize = true;
            this.CacheHelpLink2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CacheHelpLink2.Location = new System.Drawing.Point(5, 61);
            this.CacheHelpLink2.Name = "CacheHelpLink2";
            this.CacheHelpLink2.Size = new System.Drawing.Size(90, 17);
            this.CacheHelpLink2.TabIndex = 104;
            this.CacheHelpLink2.TabStop = true;
            this.CacheHelpLink2.Text = "Cache Option:";
            this.CacheHelpLink2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDocument_LinkClicked);
            // 
            // CacheHelpLink
            // 
            this.CacheHelpLink.AutoSize = true;
            this.CacheHelpLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CacheHelpLink.Location = new System.Drawing.Point(5, 63);
            this.CacheHelpLink.Name = "CacheHelpLink";
            this.CacheHelpLink.Size = new System.Drawing.Size(90, 17);
            this.CacheHelpLink.TabIndex = 111;
            this.CacheHelpLink.TabStop = true;
            this.CacheHelpLink.Text = "Cache Option:";
            this.CacheHelpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(12, 298);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(46, 17);
            this.linkLabel2.TabIndex = 111;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Github";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // checkBoxDriveEnabled
            // 
            this.checkBoxDriveEnabled.AutoSize = true;
            this.checkBoxDriveEnabled.Checked = true;
            this.checkBoxDriveEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDriveEnabled.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxDriveEnabled.Location = new System.Drawing.Point(6, -1);
            this.checkBoxDriveEnabled.Name = "checkBoxDriveEnabled";
            this.checkBoxDriveEnabled.Size = new System.Drawing.Size(68, 21);
            this.checkBoxDriveEnabled.TabIndex = 112;
            this.checkBoxDriveEnabled.Text = "Drive 1";
            this.checkBoxDriveEnabled.UseVisualStyleBackColor = true;
            this.checkBoxDriveEnabled.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxDriveEnabled2
            // 
            this.checkBoxDriveEnabled2.AutoSize = true;
            this.checkBoxDriveEnabled2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBoxDriveEnabled2.Location = new System.Drawing.Point(6, -1);
            this.checkBoxDriveEnabled2.Name = "checkBoxDriveEnabled2";
            this.checkBoxDriveEnabled2.Size = new System.Drawing.Size(68, 21);
            this.checkBoxDriveEnabled2.TabIndex = 113;
            this.checkBoxDriveEnabled2.Text = "Drive 2";
            this.checkBoxDriveEnabled2.UseVisualStyleBackColor = true;
            this.checkBoxDriveEnabled2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(321, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Label:";
            // 
            // textBoxDriveLabel
            // 
            this.textBoxDriveLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxDriveLabel.Location = new System.Drawing.Point(367, 60);
            this.textBoxDriveLabel.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDriveLabel.Name = "textBoxDriveLabel";
            this.textBoxDriveLabel.Size = new System.Drawing.Size(156, 25);
            this.textBoxDriveLabel.TabIndex = 114;
            this.textBoxDriveLabel.TabStop = false;
            // 
            // textBoxDriveLabel2
            // 
            this.textBoxDriveLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxDriveLabel2.Location = new System.Drawing.Point(367, 58);
            this.textBoxDriveLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDriveLabel2.Name = "textBoxDriveLabel2";
            this.textBoxDriveLabel2.Size = new System.Drawing.Size(156, 25);
            this.textBoxDriveLabel2.TabIndex = 116;
            this.textBoxDriveLabel2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(321, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 115;
            this.label4.Text = "Label:";
            // 
            // RcloneMount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(561, 338);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnMount);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRLocation;
        private System.Windows.Forms.Label lblRloneLocation;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialogRclone;
        private System.Windows.Forms.Button btnMount;
        private System.Windows.Forms.ComboBox comboBoxMount;
        private System.Windows.Forms.Label lblRemoteName;
        private System.Windows.Forms.TextBox txtRemoteName;
        private System.Windows.Forms.Label lblDriveLetter;
        private System.Windows.Forms.TextBox txtDriveLetter;
        private System.Windows.Forms.Button btnUnmount;
        private System.Windows.Forms.CheckBox checkBoxRAAS;
        private System.Windows.Forms.NotifyIcon notifyIconRclone;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRclone;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.CheckBox checkBoxReadonly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxReadonly2;
        private System.Windows.Forms.ComboBox comboBoxMount2;
        private System.Windows.Forms.TextBox txtRemoteName2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDriveLetter2;
        private System.Windows.Forms.LinkLabel CacheHelpLink2;
        private System.Windows.Forms.LinkLabel CacheHelpLink;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBoxDriveEnabled;
        private System.Windows.Forms.CheckBox checkBoxDriveEnabled2;
        private System.Windows.Forms.TextBox textBoxDriveLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDriveLabel2;
        private System.Windows.Forms.Label label4;
    }
}

