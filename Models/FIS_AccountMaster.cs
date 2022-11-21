using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BFS.Models
{
    public class FIS_AccountMaster
    {
        [Key]
        public int  AccountID { get; set; }

        //Client Information
        [ForeignKey("FIS_Customer")]
        public int ClientID { get; set; }
        public virtual FIS_Customer FIS_Customer { get; set; }

        //Account Information
        [ForeignKey("FIS_BranchMaster")]
        public int BranchID { get; set; }
        public virtual FIS_BranchMaster FIS_BranchMaster { get; set; }
        [Display(Name = "Account Operating Instruction")]
        public string Operation { get; set; }
        [Display(Name = "No Of Joints")]
        public int NoOfJoints { get; set; }

        //Deposit Details
        public virtual FIS_LoanDepositMaster FIS_LoanDepositMaster { get; set; }    
      


    }
}
