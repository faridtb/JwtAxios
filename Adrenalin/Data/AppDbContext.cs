using Adrenalin.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Adrenalin.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Name = "Farid",
                    Surname = "Baliyev",
                    Birth = new DateTime(1997, 02, 09),
                    Role = Rolles.Admin.ToString(),
                    Email = "baliyevfarid@gmail.com",
                    PhoneNumber = "0505683810",
                    UserName = "faradheus",
                },
                new AppUser
                {
                    Name = "Telman",
                    Surname = "Baliyev",
                    Birth = new DateTime(1961, 02, 22),
                    Role = Rolles.Banned.ToString(),
                    Email = "baliyevtelman@gmail.com",
                    PhoneNumber = "0555270533",
                    UserName = "ayavrikcor",
                },
                new AppUser
                {
                    Name = "Hasan",
                    Surname = "Baliyev",
                    Birth = new DateTime(1993, 01, 12),
                    Role = Rolles.Member.ToString(),
                    Email = "baliyev.93@gmail.com",
                    PhoneNumber = "0557274749",
                    UserName = "hesen123",
                }) ;
                
                

        }
    }
}
