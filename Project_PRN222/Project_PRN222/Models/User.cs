﻿using Microsoft.AspNetCore.Identity;

namespace Project_PRN222.Models
{
    public class User : IdentityUser<Guid>
    {
        public string? NameToDisplay { get; set; }
        public string? ImageUrl { get; set; }
        public int Exp { get; set; }
        public Guid? LevelId { get; set; }
        public Level Level { get; set; }
    }
}
