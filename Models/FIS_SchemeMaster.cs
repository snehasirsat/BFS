using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BFS.Models
{
    public class FIS_SchemeMaster
    {
        [Key]
        public int SchemeID { get; set; }
        public string SchemeName { get; set; }

        [ForeignKey("FIS_GLMaster")]
        public int GLId { get; set; }
        public virtual FIS_GLMaster FIS_GLMaster { get; set; }
        public DateTime FromDate { get; set; }
        public decimal FromAmount { get; set; }
        public int FromPeriod { get; set; }
        public decimal InterestRate { get; set; }
        public decimal PenalRate { get; set; }
        public DateTime UptoDate { get; set; }
        public decimal UptoAmount { get; set; }
        public int ToPeriod { get; set; }
        public string IsActive { get; set; }

    }
}
