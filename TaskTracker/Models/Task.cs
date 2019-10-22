using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskTracker.Models
{
    public class Task
    {
        [Key]
        public int TaskId {get;set;}

        public User Creator {get;set;}

        public List<UserTask> UserTasks{get;set;}

        [Required]
        [MinLength(2, ErrorMessage="Task must have at least 2 characters")]
        public string Name{get;set;}

        [Required]
        [MinLength(3, ErrorMessage="Description must have at least 3 characters")]
        public string Description {get;set;}

        public DateTime CreatedAt {get;set;}=DateTime.Now;
        public DateTime UpdatedAt {get;set;}= DateTime.Now;
    }
}