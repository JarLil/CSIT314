using System;
using System.Collections.Generic;
namespace Group13
{
    public class CompletedRequests
    {
        public string ReqID { get; set; }
        public String RSAID { get; set; }
        public String UserID { get; set; }
        public String UserCarMake { get; set; }
        public string UserCarModel { get; set; }
        public String UserCarColour { get; set; }
        public String UserRego { get; set; }
        public String UserMessage { get; set; }
        public String UserLocation { get; set; }

        public List<CompletedRequests> CompletedRequestsArray { get; set; }
    }
}
