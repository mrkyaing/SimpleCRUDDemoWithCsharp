﻿using System;
namespace SimpleCRUDDemo{
    public class UserModel {
        public int  Id { get; set; }
        public string  Name { get; set; }
        public string  Email { get; set; }
        public string  Password { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
