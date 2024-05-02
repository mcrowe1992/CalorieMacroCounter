using Calorie_Macro_Counter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calorie_Macro_Counter.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
        public DbSet<FoodItem> FoodItems { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}
