using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentRegistrationApplication.Models;

namespace StudentRegistrationApplication
{
    public class UserDataContext : DbContext
    {
        private readonly string path = @"D:\CreatedDatabase\UserDatabase\User.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={path}");
        }


        public DbSet<User> Users { get; set; }
    }
}
