using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALConnectPublisher.Models
{
    interface IAWSNotification
    {
        string Author { get; set; }

        string AudioUrl { get; set; }

        string Bucket { get; set; }

        DateTime EndDate { get; set; }
        string[] FileNames { get; set; }
      
        bool IsVideo { get; set; }

        string Message { get; set; }

        DateTime StartDate { get; set; }

        string Title { get; set; }

        string Type { get; }      

        

  
    }
}
