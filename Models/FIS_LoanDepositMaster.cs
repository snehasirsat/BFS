using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BFS.Models
{
    public class FIS_LoanDepositMaster
    {
        [Key]
        public int LoanDepositID { get; set; }

        [ForeignKey("FIS_AccountMaster")]
        public int AccountID { get; set; }
        public virtual FIS_AccountMaster FIS_AccountMaster { get; set; }

        [ForeignKey("FIS_SchemeMaster")]
        public int SchemeID { get; set; }
        public virtual FIS_SchemeMaster FIS_SchemeMaster { get; set; }
        public DateTime Deposit_SancDate { get; set; }
        public int Period { get; set; }
        public string PeriodUnit { get; set; }
        public decimal InterestRate { get; set; }
        public decimal PenalRate { get; set; }
        public DateTime Maturity_ExpDate { get; set; }
        public decimal Deposit_loanAmt { get; set; }
        public decimal Maturity_Amt { get; set; }
        public string Interest_Frequency { get; set; }
        public string Installment_Frequency { get; set; }
        public decimal Interest_Amount { get; set; }

    }
}
