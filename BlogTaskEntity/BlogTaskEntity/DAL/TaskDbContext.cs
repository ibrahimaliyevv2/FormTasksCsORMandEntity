using BlogTaskEntity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogTaskEntity.DAL
{
    public class TaskDbContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-KA8SSD4;Database=BlogTaskDB;Trusted_Connection=TRUE");
        }
    }
}
