using System;

namespace Resume.Server.Contracts
{
    public class CoffeeStatusDTO
    {
        public int Id { get; set; }
        public decimal Level { get; set; }
        public DateTime Timestamp { get; set; }
    }
}