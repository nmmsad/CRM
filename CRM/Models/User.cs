using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace CRM.Models
{

    public class User
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required(ErrorMessage = "Please Enter Fio")]
        public string? Fio { get; set; }

        [DataType(DataType.Date)]
        //[Range(typeof(DateTime), "1900-01-01", "2010-01-01" ,
        //ErrorMessage = "Value for {0} must be between {1} and {2}")]
        //[CustomDateRange(ErrorMessage = "wrong")]
        //[Date(ErrorMessage = "wrong")]
        [Required(ErrorMessage = "Please Enter Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Please Enter Login")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
        
        public string? UserAddress { get; set; }
        
        public string? PasportData { get; set; }
        
        public string? Mail { get; set; }
        
        public string? TgId { get; set; }
        
        public int? LocationId { get; set; }
        [Range(1,3)]
        [Required(ErrorMessage = "Please Enter Id Of Role")]
        public int RoleId { get; set; }

    }
    //public class CustomDateRangeAttribute : RangeAttribute
    //{
    //    public CustomDateRangeAttribute() : base(typeof(DateTime), DateTime.Now.ToString(), DateTime.Now.AddYears(20).ToString())
    //    { }
    //}
    //public class DateAttribute : RangeAttribute
    //{
    //    public DateAttribute()
    //      : base(typeof(DateTime), DateTime.Now.AddYears(-20).ToShortDateString(), DateTime.Now.AddYears(2).ToShortDateString()) { }
    //}

}