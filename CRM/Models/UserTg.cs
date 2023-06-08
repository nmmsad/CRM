using System;

namespace CRM.Models
{
    public class UserTg
    {
        public int Id { get; set; }//hide

        public string? UserId { get; set; }

        public string? UserName { get; set; }

        public DateTime? RequestTime { get; set; }// now

        public bool? IsRequest { get; set; }// 0 - no 1
    }
}
