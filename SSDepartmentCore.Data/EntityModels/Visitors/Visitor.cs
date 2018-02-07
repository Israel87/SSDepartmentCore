using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SSDepartmentCore.Data.EntityModels.Visitors
{
    public class Visitor : User
    {
        [Required]
        public DateTime DateVisited { get; set; }
        [Required]
        public bool Adventist { get; set; }
        public string Church { get; set; }
        public bool NeedCounselling { get; set; }
        public bool SeePastor { get; set; }
        public string PrayerRequest { get; set; }

    }
}
