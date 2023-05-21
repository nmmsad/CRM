using System;

namespace CRM.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public string? Quantity { get; set; }

        public DateTime? Date { get; set; } //системно

        public int? JobId { get; set; } //null
    }
}
