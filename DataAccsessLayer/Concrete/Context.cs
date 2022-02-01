using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-83VGVFE0\\SQLEXPRESS;database=CoreDb; integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.Message2SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.WriterReceiver)
                .HasForeignKey(z => z.Message2ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
                
        }

        public DbSet<About> Abouts { get; set; } 

        public DbSet<Blog> Blogs { get; set; } 

        public DbSet<Category> Categories { get; set; } 

        public DbSet<Comment> Comments { get; set; } 

        public DbSet<Contact> Contacts { get; set; } 
         
        public DbSet<Writer> Writers { get; set; } 

        public DbSet<NewsLetter> NewsLetters { get; set; } 

        public DbSet<BlogRayting> BlogRaytings { get; set; } 

        public DbSet<Notification> Notifications { get; set; } 

        public DbSet<Message> Messages { get; set; } 

        public DbSet<Message2> Message2s { get; set; } 


    }
}
