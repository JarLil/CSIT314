using System;
using System.Collections.Generic;

namespace Group13
{
    public class Requests
    {
        public string ReqID { get; set; }
        public String UserID { get; set; }
        public String UserCarMake { get; set; }
        public String UserCarModel { get; set; }
        public string UserCarColour { get; set; }
        public String UserRego { get; set; }
        public String UserMessage { get; set; }
        public String UserLocation { get; set; }
        public String Status { get; set; }

        public List<Requests> RequestsArray { get; set; }
    }
}
