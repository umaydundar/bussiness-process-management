using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class HiringDetails
    {
        public int DetailID { get; set; }
        public long TaskID { get; set; }
        public int ResponsibleUserID { get; set; }
        public string ResponsibleUserName { get; set; }
        public string HireName { get; set; }
        public string Department { get; set; }
        public string StepDescription { get; set; }
        public string Status { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string UserName2 { get; set; }
        public string UserName3 { get; set; }
        public string Status2 { get; set; }
        public string Status3 { get; set; }
        public DateTime? CompletionDate2 { get; set; }
        public DateTime? CompletionDate3 { get; set; }

    }
}
