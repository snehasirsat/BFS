using System.Xml.Linq;
using System;
using System.ComponentModel.DataAnnotations;

namespace BFS.Models
{
    public class FIS_GLMaster
    {
        [Key]
        public int GLId { get; set; }
        public string GlCode { get; set; }
        public string GLName { get; set; }
        public string GLShortName { get; set; }
        public int AccountTypeID { get; set; }
        public string ChequeBook { get; set; }
        public decimal ChqMinBal { get; set; }
        public decimal NoChqMinBal { get; set; }
        public decimal PrintPosition { get; set; }
        public string IsActive { get; set; }

    }
}
