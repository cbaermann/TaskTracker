using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models
{
    public class UserTask
    {
        [Key]
        public int UserTaskId{get;set;}

        public int UserId{get;set;}
        public User User {get;set;}
        public int TaskId {get;set;}
        public Task Task {get;set;}

    }
}