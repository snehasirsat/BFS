using Microsoft.CodeAnalysis.Operations;
using System.ComponentModel.DataAnnotations;

namespace BFS.Models
{
    public class FIS_BranchMaster
    {
        [Key]
        public int BranchID { get; set; }
        public int BankID { get; set; }
        public string BranchName { get; set; }
        public string Address_1 { get; set; }
        public string Address_2 { get; set; }
        public string City { get; set; }
        public string MobileNo { get; set; }
        public string CityCode { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string MICRCode { get; set; }
        public string WeeklyOff { get; set; }

    }
}
