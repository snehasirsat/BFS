using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BFS.Models
{
    public class FIS_JointOperators
    {
        [Key]
        public int JointOperID { get; set; }

        [ForeignKey("FIS_AccountMaster")]
        public int AccountID { get; set; }
        public virtual FIS_AccountMaster FIS_AccountMaster { get; set; }

        [ForeignKey("FIS_Customer")]
        public int JointOperClientID { get; set; }
        public virtual FIS_Customer FIS_Customer { get; set; }
        public string Designation { get; set; }
        public string isActive { get; set; }

    }
}
