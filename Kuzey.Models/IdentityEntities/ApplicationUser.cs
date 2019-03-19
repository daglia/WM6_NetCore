﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Kuzey.Models.IdentityEntities
{
    public class ApplicationUser : IdentityUser
    {
        [Required, StringLength(50)] public string Name { get; set; } = "Test";
        [Required, StringLength(50)] public string Surname { get; set; } = "Test2";
        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}