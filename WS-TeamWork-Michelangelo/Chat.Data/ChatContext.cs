using Chat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;   

namespace Chat.Data
{
    public class ChatContext
    {
        //public ChatContext()
        //    : base("asdasdas")//ConfigurationManager.AppSettings[""])
        //{
        //}

        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //Users
        //    modelBuilder.Entity<User>().HasKey(x => x.Id);
        //    modelBuilder.Entity<User>().Property(x => x.Username).IsRequired().HasMaxLength(50);
        //    modelBuilder.Entity<User>().Property(x => x.Password).IsRequired().HasMaxLength(16);
        //    modelBuilder.Entity<User>().Property(x => x.Nickname).IsRequired().HasMaxLength(50);
        //    modelBuilder.Entity<User>().Property(x => x.SessionKey).HasMaxLength(50);

        //    //Messages
        //    modelBuilder.Entity<Message>().HasKey(x => x.Id);
        //    modelBuilder.Entity<Message>().Property(x => x.Content).HasColumnType("text");

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
