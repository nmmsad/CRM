namespace CRM.Models
{
    public class CliesntsHistory
    {
        public int Id { get; set; }
        public string? Fio { get; set; }// null or no valid
        public string? Adress { get; set; }// null
        public string? CarName { get; set; }
        public int? Price { get; set; }
        public int? TgId { get; set; } // null
        public string? PhoneNumber { get; set; } // null
        public int? IdStaff { get; set; }
    }
}
