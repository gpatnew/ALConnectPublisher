using Microsoft.Office.Core;
using Microsoft.Office.Interop.PowerPoint;
using System;

namespace ALConnectPublisher
{
    public class PPTConverter
    {

        public string Results { get; set; }
    /// <summary>
    /// return the list of imges created from the slides in the PPt
    /// </summary>
    /// <param name="file"></param>
    /// <param name="messageName"></param>
    /// <param name="path"></param>
    /// <returns></returns>
        public string BuildSlides(string file, string messageName, string path)
        {
            string filelist = "";
            int slideCount = 0;
            var pptApplication = new Application();
            var separator = "";
            try
            {
                Presentation pptPresentation = pptApplication.Presentations.Open(file, MsoTriState.msoFalse);
                 var loader = new AWSHelper();

                for (int i = 1; i <= pptPresentation.Slides.Count; i++)
                {
                    var slideName = string.Concat(messageName.Replace(" ", ""), i.ToString(), ".png");
                    var largeSlideName = string.Concat(messageName.Replace(" ", ""), i.ToString(), "x2.png");
                    var localPath = string.Concat(path, "\\", slideName);
                    var localLargePath = string.Concat(path, "\\", largeSlideName);
                    var presentation_text = string.Empty;

                    pptPresentation.Slides[i].Export(localLargePath, "PNG", 1024, 576);
                    pptPresentation.Slides[i].Export(localPath, "PNG", 400, 220);
                    foreach (var item in pptPresentation.Slides[i].Shapes)
                    {
                        var shape = (Microsoft.Office.Interop.PowerPoint.Shape)item;
                        if (shape.HasTextFrame == MsoTriState.msoTrue)
                        {
                            if (shape.TextFrame.HasText == MsoTriState.msoTrue)
                            {
                                var textRange = shape.TextFrame.TextRange;
                                var text = textRange.Text;
                                presentation_text += text + " ";
                            }
                        }
                    }
                    loader.SaveFileToS3(localPath, Constants.S3Bucket, Constants.S3MessageDirectory + "/"+ messageName, slideName);
                    loader.SaveFileToS3(localPath, Constants.S3Bucket, Constants.S3MessageDirectory + "/" + messageName, largeSlideName);
                    slideCount++;
                    filelist += string.Format("{0}{1}", separator, slideName);
                    separator = ";";
                }
                Results = string.Format("Uploaded {0} slides", slideCount);

            }
            catch (Exception e)
            {
                Results = e.Message;
            }
            finally
            {
                pptApplication.Quit();
            }
            return filelist;

        }

    }
}
