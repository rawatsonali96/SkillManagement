using Microsoft.EntityFrameworkCore;
using SkillModel;

namespace SkillRepository
{
    public class DatabaseSet : DbContext
    {

        public DatabaseSet(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserSkill>()
                .HasOne<Skill>(s => s.Skill)
                .WithMany(g => g.UserSkills)
                .HasForeignKey(s => s.SkillId);
            modelBuilder.Entity<UserSkill>()
                .HasOne<Employee>(s => s.Employee)
                .WithMany(g => g.Skills)
                .HasForeignKey(s => s.EmpID);
            //modelBuilder.Entity<Skill>()
             //        .HasOptional(c => c)
            //         .WithMany()
            //         .HasForeignKey(c => c.SpouseId);
        }
    //    public DbSet<SkillTemp> SkillsTemp { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
    }
}
