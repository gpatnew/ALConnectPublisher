using System;
using System.IO;
using System.Windows.Forms;
using ALConnectPublisher.Models;
using Newtonsoft.Json;
using SimpleValidator;
using System.Collections.Generic;

namespace ALConnectPublisher
{
    public partial class MainForm : Form
    {
        public string ResultMessage { get; set; }

        private WeeklyMessage message = new WeeklyMessage();
        private Feature feature = new Feature();
        public MainForm()
        {
            InitializeComponent();
            BindNotifications();
            ResultMessage = "This requires Power Point to be installed to publish. \r\nAdd a subscription for email address to recieve the notification. ";
            SetResults();
        }

        private void buttonSelectMessage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PowerPoint|*.ppt*|All|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            tbPowerPoint.Text = openFileDialog1.ShowDialog() == DialogResult.OK ? openFileDialog1.FileName : "";

            try { PrepopulateFields(); }
            catch { }
            
        }


        private void publishButton_Click(object sender, EventArgs e)
        {
            var converter = new PPTConverter();
            var tempPath = Path.GetTempPath();
            var slidelist = converter.BuildSlides(tbPowerPoint.Text, tbMssageTitle.Text, tempPath);
            ResultMessage = converter.Results + Environment.NewLine;
            if(!ResultMessage.Contains("rror"))
            {
                var json = BuildMessage(slidelist);
                var helper = new AWSHelper();
                helper.SaveFileToS3(message, Constants.S3Bucket, Constants.S3NotificationDirectory, tbMssageTitle.Text.Trim().Replace(" ", "") + ".json");
                ResultMessage += helper.Results + Environment.NewLine; ;
                //helper.SendNotification(Constants.MessageTopic, "Message added " + tbMssageTitle.Text, json);
                //ResultMessage += helper.Results + Environment.NewLine; ;
            }
            SetResults();
            BindNotifications();
        }

        private void SetResults()
        {
            labelResults.Visible = true;
            labelResults.Text = ResultMessage;
        }
        private void ClearResults()
        {
            labelResults.Text = string.Empty;
        }
        private string BuildMessage(string fileList)
        {
            message.Title = tbMssageTitle.Text;
            message.Message = tbPassage.Text;
            message.Author = tbMessageAuthor.Text;
            message.FileNames = fileList.Split(';');
            message.AudioUrl = tbMessageAudio.Text;
            message.StartDate = dtpMessgeStart.Value;
            message.Bucket = Constants.S3Bucket;
            return JsonConvert.SerializeObject(message);
        }

        private string BuildFeature()
        {
            var i = tbFeatureImage.Text.LastIndexOf('\\') + 1;
            feature.IsVideo = label10.Visible;
            var file = feature.IsVideo ? tbFeatureVideo.Text : tbFeatureImage.Text.Substring(i);
            feature.EndDate = dtpFeatureEnd.Value;
            
            feature.Bucket = Constants.S3Bucket;
            feature.StartDate = dtpFeatureStart.Value;
            feature.FileNames = file.Split(';'); 
            feature.Message = tbFeatureText.Text;
            feature.Title = tbFeatureTitle.Text;
            return JsonConvert.SerializeObject(feature);
        }

        private void BindNotifications()
        {
            var helper = new AWSHelper();
            dataGridView1.DataSource = helper.ListNotifications(Constants.S3Bucket, "notifications");
            dataGridView1.Refresh();
        }


        private void PrepopulateFields()
        {
            if(!string.IsNullOrEmpty(tbPowerPoint.Text))
            {
                var day = "SUN MORN";
                var filePath = tbPowerPoint.Text;
                var fileName = filePath.Substring(filePath.LastIndexOf("\\")+1);
                var datePart = fileName.Substring(0,  fileName.LastIndexOf("-20") + 5);
                var messageName = fileName.Replace(datePart, "");
                messageName = messageName.Remove(messageName.LastIndexOf('.'));
                var passage = messageName.Substring(0, messageName.LastIndexOf(day));
                tbMssageTitle.Text = messageName.Replace(day,"").Trim();
                tbPassage.Text = passage.Trim();
                DateTime selectedDate;
                if(DateTime.TryParse(datePart, out selectedDate))
                dtpMessgeStart.Value = selectedDate;
            }
        }

        private void subscripeToNotificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNotifications.Visible = true;
            panelNotifications.BringToFront();
            buttonPublish.Enabled = false;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClosePanel();
        }

        private void ClosePanel()
        {

            panelNotifications.SendToBack();
            panelNotifications.Visible = false;

            BindNotifications();
        }

        private void buttonSelectedFeatured_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images|*.gif;*.png;*.jpeg;*.jpg|All|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            tbFeatureImage.Text = openFileDialog1.ShowDialog() == DialogResult.OK ? openFileDialog1.FileName : "";
        }

        private void buttonPublishFeature_Click(object sender, EventArgs e)
        {
            var title = tbFeatureTitle.Text.Trim().Replace(" ", "_");
            var featureJson = BuildFeature();
            var helper = new AWSHelper();
            if (feature.IsVideo)
                helper.SaveFileToS3(feature, Constants.S3Bucket, Constants.S3FeatureDirectory, title);
            else
                helper.SaveFileToS3(tbFeatureImage.Text, Constants.S3Bucket, Constants.S3FeatureDirectory, feature.FileNames[0]);

            //create a notification file
            helper.SaveFileToS3(feature, Constants.S3Bucket, Constants.S3NotificationDirectory, string.Concat("Feature_", title));
            ResultMessage = helper.Results;
            //helper.SendNotification(Constants.FeatureTopic, "Feature added ", featureJson);
            ResultMessage = " " + helper.Results;
            SetResults();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if(dtpFeatureEnd.Value != DateTime.Now || dtpFeatureEnd.Value < dtpFeatureStart.Value)
                dtpFeatureEnd.Value = dtpFeatureStart.Value.AddMonths(1);
        }

        

        private void ValidateToPublishMessage(object sender, EventArgs e)
        {
            var canPublish = !string.IsNullOrEmpty(tbPowerPoint.Text);
            canPublish = !string.IsNullOrEmpty(tbMessageAuthor.Text);
            canPublish = !string.IsNullOrEmpty(tbPassage.Text);
            canPublish = !string.IsNullOrEmpty(tbMssageTitle.Text);
            buttonPublish.Enabled = canPublish;
        }
        private void ValidateToPublishFeature(object sender, EventArgs e)
        {
            var canPublish = !string.IsNullOrEmpty(tbFeatureTitle.Text);
            canPublish = !string.IsNullOrEmpty(tbFeatureText.Text);
            var done = !string.IsNullOrEmpty(tbFeatureImage.Text) ? ChangeFeatureLabels(true) : ChangeFeatureLabels(false);
            
            buttonPublishFeature.Enabled = canPublish;
        }

        private string ChangeFeatureLabels(bool showLink)
        {
            var result = "";
            label10.Visible = !showLink;
            label13.Text = showLink ? "Web Link": "Video URL";
            return result;
        }
    }
}
