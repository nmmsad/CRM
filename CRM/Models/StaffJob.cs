using System;

namespace CRM.Models
{
    public class StaffJob
    {
        public int Id { get; set; }

        public string? TgId { get; set; }//

        public string WorkName { get; set; }

        public DateTime? AddDate { get; set; }//now

        public int Price { get; set; }

        public string? Contact { get; set; }

        public int? HiddenPrice { get; set; }
    }
}
