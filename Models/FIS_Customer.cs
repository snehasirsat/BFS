using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace BFS.Models
{
    public class FIS_Customer
    {
        [Key]
        [Required]
        [Range(1,999999999)]
        [Display(Name = "ClientID")]
        public int ClientID { get; set; }
        [Required]
        [Display(Name = "ClientName")]
        [StringLength(10,ErrorMessage ="Name Should be 10 char only")]
        public string ClientName { get; set; }
        [Required]
        [Display(Name = "ClientType")]
        public string ClientType { get; set; }
        [Required]
        [Display(Name = "Address_1")]
        public string Address_1 { get; set; }
        [Required]
        [Display(Name = "Address_2")]
        public string Address_2 { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "District")]
        public string District { get; set; }
        [Required]
        [Display(Name = "State")]
        public string State { get; set; }
        [Required]
        [Display(Name = "MobileNumber")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "AadharNo bteween 1 to 10 digit")]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "AadharNo")]
        [StringLength(maximumLength:12,MinimumLength =12, ErrorMessage = "AadharNo bteween 1 to 12 digit")]
        public string AadharNo { get; set; }
        [Required]
        [Display(Name = "PAN")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "AadharNo bteween 1 to 10 digit")]
        public string PAN { get; set; }
        [Required]
        [Display(Name = "Telephone")]        
        public string Telephone { get; set; }
        [Required]
        [Display(Name = "Email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Pelase Enter Valid EmaliId")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        //[Required]       
        //[Display(Name = "Photo")]
        //public Image Photo { get; set; }
        ////[Required]
       
        //[Display(Name = "Signature")]
        //public Image Signature { get; set; }
        [Required]
        [Display(Name = "IsActive")]
        public string IsActive { get; set; }

    }
}
