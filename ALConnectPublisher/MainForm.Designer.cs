namespace ALConnectPublisher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbPowerPoint = new System.Windows.Forms.TextBox();
            this.tbMssageTitle = new System.Windows.Forms.TextBox();
            this.tbMessageAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpMessgeStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSelectSermon = new System.Windows.Forms.Button();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.tbPassage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMessageAudio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscripeToNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFeature = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.tbFeatureTitle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpFeatureEnd = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.tbFeatureText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpFeatureStart = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFeatureVideo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFeatureImage = new System.Windows.Forms.TextBox();
            this.buttonPublishFeature = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.panelNotifications = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panelFeature.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PowerPoint";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbPowerPoint
            // 
            this.tbPowerPoint.Location = new System.Drawing.Point(93, 49);
            this.tbPowerPoint.Name = "tbPowerPoint";
            this.tbPowerPoint.Size = new System.Drawing.Size(357, 20);
            this.tbPowerPoint.TabIndex = 1;
            this.tbPowerPoint.TextChanged += new System.EventHandler(this.ValidateToPublishMessage);
            // 
            // tbMssageTitle
            // 
            this.tbMssageTitle.Location = new System.Drawing.Point(93, 77);
            this.tbMssageTitle.Name = "tbMssageTitle";
            this.tbMssageTitle.Size = new System.Drawing.Size(357, 20);
            this.tbMssageTitle.TabIndex = 2;
            this.tbMssageTitle.Text = "Weekly Message";
            this.tbMssageTitle.TextChanged += new System.EventHandler(this.ValidateToPublishMessage);
            // 
            // tbMessageAuthor
            // 
            this.tbMessageAuthor.AutoCompleteCustomSource.AddRange(new string[] {
            "Pastor Steve",
            "Pastor Ken",
            "Pastor Kimo"});
            this.tbMessageAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbMessageAuthor.Location = new System.Drawing.Point(93, 109);
            this.tbMessageAuthor.Name = "tbMessageAuthor";
            this.tbMessageAuthor.Size = new System.Drawing.Size(357, 20);
            this.tbMessageAuthor.TabIndex = 3;
            this.tbMessageAuthor.Text = "Pastor Steve";
            this.tbMessageAuthor.TextChanged += new System.EventHandler(this.ValidateToPublishMessage);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Speaker";
            // 
            // dtpMessgeStart
            // 
            this.dtpMessgeStart.Location = new System.Drawing.Point(93, 240);
            this.dtpMessgeStart.Name = "dtpMessgeStart";
            this.dtpMessgeStart.Size = new System.Drawing.Size(200, 20);
            this.dtpMessgeStart.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Publish on";
            // 
            // buttonSelectSermon
            // 
            this.buttonSelectSermon.Location = new System.Drawing.Point(451, 47);
            this.buttonSelectSermon.Name = "buttonSelectSermon";
            this.buttonSelectSermon.Size = new System.Drawing.Size(54, 22);
            this.buttonSelectSermon.TabIndex = 8;
            this.buttonSelectSermon.Text = "select";
            this.buttonSelectSermon.UseVisualStyleBackColor = true;
            this.buttonSelectSermon.Click += new System.EventHandler(this.buttonSelectMessage_Click);
            // 
            // buttonPublish
            // 
            this.buttonPublish.Enabled = false;
            this.buttonPublish.Location = new System.Drawing.Point(375, 321);
            this.buttonPublish.Name = "buttonPublish";
            this.buttonPublish.Size = new System.Drawing.Size(75, 26);
            this.buttonPublish.TabIndex = 7;
            this.buttonPublish.Text = "Publish";
            this.buttonPublish.UseVisualStyleBackColor = true;
            this.buttonPublish.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // tbPassage
            // 
            this.tbPassage.Location = new System.Drawing.Point(93, 138);
            this.tbPassage.Multiline = true;
            this.tbPassage.Name = "tbPassage";
            this.tbPassage.Size = new System.Drawing.Size(357, 96);
            this.tbPassage.TabIndex = 4;
            this.tbPassage.TextChanged += new System.EventHandler(this.ValidateToPublishMessage);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Main Passage";
            // 
            // tbMessageAudio
            // 
            this.tbMessageAudio.Location = new System.Drawing.Point(93, 266);
            this.tbMessageAudio.Name = "tbMessageAudio";
            this.tbMessageAudio.Size = new System.Drawing.Size(357, 20);
            this.tbMessageAudio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "AudioURL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subscripeToNotificationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // subscripeToNotificationToolStripMenuItem
            // 
            this.subscripeToNotificationToolStripMenuItem.Name = "subscripeToNotificationToolStripMenuItem";
            this.subscripeToNotificationToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.subscripeToNotificationToolStripMenuItem.Text = "List of Notifications";
            this.subscripeToNotificationToolStripMenuItem.Click += new System.EventHandler(this.subscripeToNotificationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // panelFeature
            // 
            this.panelFeature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFeature.Controls.Add(this.label17);
            this.panelFeature.Controls.Add(this.tbFeatureTitle);
            this.panelFeature.Controls.Add(this.label16);
            this.panelFeature.Controls.Add(this.dtpFeatureEnd);
            this.panelFeature.Controls.Add(this.label15);
            this.panelFeature.Controls.Add(this.tbFeatureText);
            this.panelFeature.Controls.Add(this.label14);
            this.panelFeature.Controls.Add(this.dtpFeatureStart);
            this.panelFeature.Controls.Add(this.label13);
            this.panelFeature.Controls.Add(this.tbFeatureVideo);
            this.panelFeature.Controls.Add(this.label10);
            this.panelFeature.Controls.Add(this.label9);
            this.panelFeature.Controls.Add(this.button1);
            this.panelFeature.Controls.Add(this.tbFeatureImage);
            this.panelFeature.Controls.Add(this.buttonPublishFeature);
            this.panelFeature.Controls.Add(this.label12);
            this.panelFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFeature.Location = new System.Drawing.Point(668, 38);
            this.panelFeature.Name = "panelFeature";
            this.panelFeature.Size = new System.Drawing.Size(525, 375);
            this.panelFeature.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Title";
            // 
            // tbFeatureTitle
            // 
            this.tbFeatureTitle.Location = new System.Drawing.Point(104, 55);
            this.tbFeatureTitle.Name = "tbFeatureTitle";
            this.tbFeatureTitle.Size = new System.Drawing.Size(346, 23);
            this.tbFeatureTitle.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(44, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "End on";
            // 
            // dtpFeatureEnd
            // 
            this.dtpFeatureEnd.Location = new System.Drawing.Point(104, 219);
            this.dtpFeatureEnd.Name = "dtpFeatureEnd";
            this.dtpFeatureEnd.Size = new System.Drawing.Size(232, 23);
            this.dtpFeatureEnd.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 254);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Description";
            // 
            // tbFeatureText
            // 
            this.tbFeatureText.Location = new System.Drawing.Point(104, 251);
            this.tbFeatureText.Multiline = true;
            this.tbFeatureText.Name = "tbFeatureText";
            this.tbFeatureText.Size = new System.Drawing.Size(346, 60);
            this.tbFeatureText.TabIndex = 14;
            this.tbFeatureText.TextChanged += new System.EventHandler(this.ValidateToPublishFeature);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Publish on";
            // 
            // dtpFeatureStart
            // 
            this.dtpFeatureStart.Location = new System.Drawing.Point(104, 193);
            this.dtpFeatureStart.Name = "dtpFeatureStart";
            this.dtpFeatureStart.Size = new System.Drawing.Size(232, 23);
            this.dtpFeatureStart.TabIndex = 12;
            this.dtpFeatureStart.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Video URL";
            // 
            // tbFeatureVideo
            // 
            this.tbFeatureVideo.Location = new System.Drawing.Point(104, 136);
            this.tbFeatureVideo.Name = "tbFeatureVideo";
            this.tbFeatureVideo.Size = new System.Drawing.Size(346, 23);
            this.tbFeatureVideo.TabIndex = 11;
            this.tbFeatureVideo.TextChanged += new System.EventHandler(this.ValidateToPublishFeature);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "OR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Image";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSelectedFeatured_Click);
            // 
            // tbFeatureImage
            // 
            this.tbFeatureImage.Location = new System.Drawing.Point(104, 93);
            this.tbFeatureImage.Name = "tbFeatureImage";
            this.tbFeatureImage.Size = new System.Drawing.Size(346, 23);
            this.tbFeatureImage.TabIndex = 9;
            this.tbFeatureImage.TextChanged += new System.EventHandler(this.ValidateToPublishFeature);
            // 
            // buttonPublishFeature
            // 
            this.buttonPublishFeature.Enabled = false;
            this.buttonPublishFeature.Location = new System.Drawing.Point(364, 317);
            this.buttonPublishFeature.Name = "buttonPublishFeature";
            this.buttonPublishFeature.Size = new System.Drawing.Size(75, 26);
            this.buttonPublishFeature.TabIndex = 15;
            this.buttonPublishFeature.Text = "Publish";
            this.buttonPublishFeature.UseVisualStyleBackColor = true;
            this.buttonPublishFeature.Click += new System.EventHandler(this.buttonPublishFeature_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(144, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "FEATURED ITEM";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbPowerPoint);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbMssageTitle);
            this.panel1.Controls.Add(this.buttonSelectSermon);
            this.panel1.Controls.Add(this.tbMessageAuthor);
            this.panel1.Controls.Add(this.buttonPublish);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbMessageAudio);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPassage);
            this.panel1.Controls.Add(this.dtpMessgeStart);
            this.panel1.Location = new System.Drawing.Point(82, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 375);
            this.panel1.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(126, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "SERMON MESSAGE";
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ALConnectPublisher.Properties.Settings.Default, "Results", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(665, 433);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(292, 102);
            this.labelResults.TabIndex = 15;
            this.labelResults.Text = global::ALConnectPublisher.Properties.Settings.Default.Results;
            // 
            // panelNotifications
            // 
            this.panelNotifications.Controls.Add(this.dataGridView1);
            this.panelNotifications.Location = new System.Drawing.Point(82, 419);
            this.panelNotifications.Name = "panelNotifications";
            this.panelNotifications.Size = new System.Drawing.Size(551, 241);
            this.panelNotifications.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 672);
            this.Controls.Add(this.panelNotifications);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFeature);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PPT to ALConnect";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFeature.ResumeLayout(false);
            this.panelFeature.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNotifications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbPowerPoint;
        private System.Windows.Forms.TextBox tbMssageTitle;
        private System.Windows.Forms.TextBox tbMessageAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpMessgeStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSelectSermon;
        private System.Windows.Forms.Button buttonPublish;
        private System.Windows.Forms.TextBox tbPassage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMessageAudio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subscripeToNotificationToolStripMenuItem;
        private System.Windows.Forms.Panel panelFeature;
        private System.Windows.Forms.TextBox tbFeatureImage;
        private System.Windows.Forms.Button buttonPublishFeature;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbFeatureText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpFeatureStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFeatureVideo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpFeatureEnd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbFeatureTitle;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelNotifications;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

