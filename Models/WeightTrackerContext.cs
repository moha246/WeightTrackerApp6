using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeightTrackerApp6.Util;


namespace WeightTrackerApp6.Models
{
    public partial class WeightTrackerContext : DbContext
    {
        protected override void OnModelCreating (ModelBuilder modelBuilder) 
        {

            //foreign keys on users table
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasOne(d => d.aspNetUsers)
                .WithMany(m => m.users)
                 .HasForeignKey(d => d.aspNetUsersId)
                 .HasConstraintName("FK_aspNetUsersId");
            });

            //foreign keys on weight_details
            modelBuilder.Entity<WeightDetails>(entity =>
            {
                entity.HasOne(d => d.users)
                .WithMany(m => m.weight_details)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("users_weight_details");
            });

            //foreign keys on bmi
            modelBuilder.Entity<BMI>(entity =>
            {
                entity.HasOne(d => d.users)
                .WithMany(m => m.bmi)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("UserId");
            });

            //foreign keys on calorie counter
            modelBuilder.Entity<CalorieCounter>(entity =>
            {
                entity.HasOne(d => d.users)
                .WithMany(m => m.calorie_counter)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("UserId");
            });


            //foreign keys on AspNetRoles modelBuilder.Entity<AspNetUserRoles>(entity =>
            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasOne(d => d.aspNetRoles)
                .WithMany(m => m.aspNetUserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasOne(d => d.aspNetUsers)
                .WithMany(m => m.AspNetUserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });


            modelBuilder.Entity<AspNetUserRoles>().HasKey(a => new { a.UserId, a.RoleId });

           // base.OnModelCreating(modelBuilder);
        }

            
         public WeightTrackerContext(DbContextOptions<WeightTrackerContext> options) : base(options)
        {
 
        }

        public WeightTrackerContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var appconfig = new AppConfiguration("DefaultConnections");
                optionsBuilder.UseNpgsql("User ID=postgres;Password=41904190;Host=localhost; Port=5432;Database=Test;Pooling=true");
            }
        }

        public DbSet<WeightDetails> WeightDetails { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<CalorieCounter> Calorie_Counter { get; set; }
        public DbSet<BMI> BMI { get; set; }
        public DbSet<FoodCategory> FoodCategory { get; set; }
        public DbSet<FoodTips> FoodTips { get; set; }
        public DbSet<FoodType> FoodType { get; set; }
        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
       // public DbSet<AspNetUserClaim> AspNetUserClaim { get; set; }
        //public DbSet<AspNetRoleClaim> AspNetRoleClaim { get; set; }
       // public DbSet<AspNetUserToken> AspNetUserToken { get; set; }
        //public DbSet<AspNetUserLogin> AspNetUserLogin { get; set; }



    }
}