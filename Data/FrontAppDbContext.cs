using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using uttarakhand_project_front.Models;

namespace uttarakhand_project_front.Data
{
    public class FrontAppDbContext : IdentityDbContext
    {
        public FrontAppDbContext(DbContextOptions<FrontAppDbContext> options) : base(options)
        {

        }

        public DbSet<Registration> RegistrationMaster { get; set; }
        public DbSet<QualifyingExam> QualifyingExamMaster { get; set; }
        public DbSet<QualifyingExamDetails> QualifyingExamDetailsMaster { get; set; }
        public DbSet<ExamCenter> ExamCenterMaster { get; set; }
        public DbSet<Course> CourseMaster { get; set; }
        public DbSet<QualifyingType> QualifyingTypeMaster { get; set; }
        public DbSet<Pincode> PincodeMaster { get; set; }
        public DbSet<State> StateMaster { get; set; }
        public DbSet<OtpTable> OtpTableMaster { get; set; }
        public DbSet<Payment> PaymentMaster { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var foreign in builder.Model.GetEntityTypes().SelectMany(s => s.GetForeignKeys()))
            {
                foreign.DeleteBehavior = DeleteBehavior.Restrict;
            }
            builder.Entity<ApplicationUser>().Property(p => p.UserFlag).HasDefaultValue<int>(1);
            builder.Entity<Registration>().Property(p => p.Dob).HasColumnType("date");
            builder.Entity<Registration>().Property(p => p.IsFinalSubmit).HasDefaultValue("No");
            builder.Entity<Registration>().Property(p => p.IsPaymentDone).HasDefaultValue("No");
            builder.Entity<Registration>().Property(p => p.IsActive).HasDefaultValue(1);
            builder.Entity<Registration>().HasAlternateKey(p => p.UniqueKey);
            builder.Entity<OtpTable>().Property(p => p.IsValid).HasDefaultValue(false);
            builder.Entity<Payment>().Property(p => p.PaidStatus).HasDefaultValue(0);

           
           
            builder.Seed();
            base.OnModelCreating(builder);
        }
    }
}