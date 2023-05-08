using Work.DAL.Extend;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Work.DAL.Entity;

namespace Work.DAL.Database
{
    public class WorkContext : IdentityDbContext<Extend.ApplicationUser>
    {
        public WorkContext(DbContextOptions<WorkContext> opt) : base(opt)
        {
        }
        public DbSet<Post> Post { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectAttachments> ProjectAttachments { get; set; }
       public DbSet<Chat> Chat { get; set; }
        public DbSet<Reply> Reply{ get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Rate> Rate { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Create a new role for Identity framework

            var RolesNames = new List<string>() { "Student","Specialist","Graduate","Investor" };

            foreach (var roleName in RolesNames)
            {

                var role = new IdentityRole
                {
                    Name = roleName,
                    NormalizedName = roleName.ToUpper(),
                };
                builder.Entity<IdentityRole>().HasData(role);
            }

        }

    }
}
