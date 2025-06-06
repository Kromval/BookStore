﻿using BookStoreApi.Enums;

namespace BookStoreApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public UserRole Role { get; set; }
    }

}
