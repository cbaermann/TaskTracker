using Microsoft.EntityFrameworkCore;

namespace TaskTracker.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users{get;set;}
        public DbSet<Task> Tasks{get;set;}
        public DbSet<UserTask> UserTasks{get;set;}
    }
}