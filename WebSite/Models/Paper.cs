using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    public class Paper
    { 
        public string UserName { get; set; }
        public string Password { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeCompany { get; set; }
        public long EmployeePhoneNo { get; set; }

        public string EmployeeLocation { get; set; }
    }
}