using Microsoft.EntityFrameworkCore;

namespace HostelSimple2.Models
{

    public class HostelContext : DbContext
    {
        public HostelContext(DbContextOptions<HostelContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<MealLog> MealLogs { get; set; }
    }

    public class MealLog
    {
        public int LogID { get; set; }
        public string StudentIDCard { get; set; }
        public DateTime MealDate { get; set; }
        public string MealTime { get; set; }
        public string DishName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Quantity * Price;
    }

}
