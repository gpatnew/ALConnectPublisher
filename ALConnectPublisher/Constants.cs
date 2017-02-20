using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALConnectPublisher
{
    class Constants
    {
        public const string S3Bucket = "mobileapp.alfc.us";
        public const string S3FeatureDirectory = "featureitem";
        public const string S3MessageDirectory = "weeklymessage";
        public const string S3NotificationDirectory = "notifications";
        public const string MessageTopic = "arn:aws:sns:us-west-2:650481127744:WeeklyMessages";
        public const string FeatureTopic = "arn:aws:sns:us-west-2:650481127744:FeaturedItems";
    }
}
