using System;
namespace Group13
{
    public class Users
    {
        public string userId { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
        public String email { get; set; }
        public string password { get; set; }
        public String userType { get; set; }
        public String subscription { get; set; }
        public String carMake { get; set; }
        public String carModel { get; set; }
        public String carColour { get; set; }
        public String registration { get; set; }
        public string transmission { get; set; }
        public string cylinders { get; set; }

        public string print()
        {
            return (userId + " " + fName + " " + lName + " " + email);
        }
    }
}
