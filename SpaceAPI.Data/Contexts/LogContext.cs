using System;
using Microsoft.EntityFrameworkCore;
using SpaceAPI.Data.Interfaces;
using SpaceAPI.Data.Models;

namespace SpaceAPI.Data.Contexts
{

    public interface ILogContext
    {
        int SaveChanges();
        DbSet<StateLog> StateLogs { get; set; }
 
    }

    public class LogContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LogContext(IHttpContextAccessor httpContextAccessor, DbContextOptions<LogContext> options)
            : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        
        public override int SaveChanges(string currentUser = "anonymouse")
        {
            foreach (var auditableEntity in ChangeTracker.Entries<IAuditableEntity>())
            {
                if (auditableEntity.State == EntityState.Added ||
                    auditableEntity.State == EntityState.Modified)
                {
                    // implementation may change based on the useage scenario, this
                    // sample is for forma authentication.
                    

                    // modify updated date and updated by column for 
                    // adds of updates.
                    auditableEntity.Entity.UpdatedDate = DateTime.Now;
                    auditableEntity.Entity.UpdatedBy = currentUser;

                    // pupulate created date and created by columns for
                    // newly added record.
                    if (auditableEntity.State == EntityState.Added)
                    {
                        auditableEntity.Entity.CreatedDate = DateTime.Now;
                        auditableEntity.Entity.CreatedBy = currentUser;
                    }
                    else
                    {
                        // we also want to make sure that code is not inadvertly
                        // modifying created date and created by columns 
                        auditableEntity.Property(p => p.CreatedDate).IsModified = false;
                        auditableEntity.Property(p => p.CreatedBy).IsModified = false;
                    }
                }
            }
            return base.SaveChanges();
        }

        public DbSet<StateLog> StateLogs { get; set; }
    }
}