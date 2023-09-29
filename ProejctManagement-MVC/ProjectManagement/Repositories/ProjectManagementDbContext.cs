using Microsoft.EntityFrameworkCore;
using ProjectManagement.Entities;

namespace ProjectManagement.Repositories
{
	public class ProjectManagementDbContext:DbContext
	{
		public DbSet<User> Users { get; set; }

		//public ProjectManagementDbContext()
		//{
		//	Users = this.Set<User>();
		//}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder
				.UseSqlServer("Server=DESKTOP-6EIHMO8\\SQLEXPRESS;Database=ProjectManagementDB;Trusted_Connection=True;MultipleActiveResultSets=True");
		}
	}
}
