﻿using System;
using Amazon;
using Amazon.S3;
using Amazon.S3.Transfer;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using System.Collections.Generic;
using Amazon.Runtime;
using ALConnectPublisher.Models;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using Amazon.S3.Model;

namespace ALConnectPublisher
{
    public class AWSHelper
    {
        public string Results { get; set; }
        
        public bool SaveFileToS3(string path, string bucket, string subDirectory, string fileName)
        {
            var fileSent = false;

            try
            {
                IAmazonS3 client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);
                var utility = new TransferUtility(client);

                var transferRequest = new TransferUtilityUploadRequest();
                transferRequest.BucketName = string.IsNullOrEmpty(subDirectory) ? bucket : string.Concat(bucket, "/", subDirectory);
                transferRequest.Key = fileName;
                transferRequest.FilePath = path;
                transferRequest.CannedACL = S3CannedACL.PublicRead;
                utility.Upload(transferRequest);
                Results += string.Format(" File sent {0}{1}", fileName, Environment.NewLine);
                fileSent = true;
            }
            catch (Exception e)
            {
                Results = string.Format("ERROR sending {0}: {1}", fileName, e.Message);
                fileSent = false;
            }


            return fileSent;
        }

        internal bool SaveFileToS3(IAWSNotification obj, string bucket, string subDirectory, string fileName)
        {
            var fileSent = false;
            try
            {           
                IAmazonS3 client = new AmazonS3Client(Amazon.RegionEndpoint.USWest2);
                var utility = new TransferUtility(client);

                var transferRequest = new TransferUtilityUploadRequest();
               
                transferRequest.BucketName =  string.Concat(bucket, "/", subDirectory);
                transferRequest.Key = fileName;
                transferRequest.ContentType = "text/json";
                transferRequest.CannedACL = S3CannedACL.PublicRead;
                
                var json = JsonConvert.SerializeObject(obj);
                
                transferRequest.InputStream = GenerateStreamFromString(json);
                utility.Upload(transferRequest);
                fileSent = true;
                Results += string.Format(" File sent {0}{1}", fileName, Environment.NewLine);
                fileSent = true;
            }
            catch (Exception E)
            {
                Results = E.Message;
                fileSent = false;
            }
            return fileSent;

        }

        public List<IAWSNotification> ListNotifications(string bucket, string subDirectory)
        {
            var client = new AmazonS3Client(RegionEndpoint.USWest2);
            var topicList = new List<IAWSNotification>();
            try
            {
                var response =  client.ListObjects(new Amazon.S3.Model.ListObjectsRequest()
                {
                    BucketName = bucket,
                    Prefix = subDirectory,
                    MaxKeys = 250
                });

                foreach (S3Object item in response.S3Objects)
                {
                    var res = client.GetObject(new GetObjectRequest() { BucketName  = bucket, Key = item.Key});
                    var note = ParseResponse(res);
                    if(note != null)
                        topicList.Add(note);
                }
                
            }
            catch(Exception e)
            { var f = e.Message; }

            return topicList;
        }

        private IAWSNotification ParseResponse(GetObjectResponse res)
        {
            using (var stream = res.ResponseStream)
            {
                var reader =  new StreamReader(stream);
                var notification = reader.ReadToEnd();
                return ProcessNotification(notification);

            }
        }

        private IAWSNotification ProcessNotification(string notification)
        {
            if (string.IsNullOrEmpty(notification))
                return null;
            return JsonConvert.DeserializeObject<Feature>(notification);
        }

        public bool SendNotification(string resourceName, string subject, string message)
        {
            return false;
            //string resourceName = "arn:aws:sns:us-west-1:650481127744:WeeklyMessage";
            AmazonSimpleNotificationServiceClient snsclient = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest1);
            PublishRequest pr = new PublishRequest();
            
            pr.Message = message;
            pr.Subject = subject;
            pr.TopicArn = resourceName;

            var response = snsclient.Publish(pr);
            Results = response.MessageId;
            
            return response.HttpStatusCode == System.Net.HttpStatusCode.OK;
        }

        internal void SendSubscription(string email)
        {
            var client = new AmazonSimpleNotificationServiceClient(RegionEndpoint.USWest2);
            // Subscribe an endpoint - in this case, an email address
            client.Subscribe(new SubscribeRequest
            {
                TopicArn = Constants.MessageTopic,
                Protocol = "email",
                Endpoint = email
            });

            client.Subscribe(new SubscribeRequest
            {
                TopicArn = Constants.FeatureTopic,
                Protocol = "email",
                Endpoint = email
            });
        }

        public Stream GenerateStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
