using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models
{
    public class LoginViewModel
    {
        public User newUser{get;set;}
        public Login newLogin {get;set;}
    }
}