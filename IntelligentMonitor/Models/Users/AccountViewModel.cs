﻿using System.Collections.Generic;

namespace IntelligentMonitor.Models.Users
{
    public class LoginViewModel
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class PasswordViewModel
    {
        public string OldPassword { get; set; }

        public string Password { get; set; }

        public string Repassword { get; set; }
    }

    public class ProfileViewModel
    {
        public string NickName { get; set; }
    }

    public class PermissionViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string PermissionName { get; set; }
    }

    public class RoleViewModel
    {
        public Users User { get; set; }

        public List<Roles> RoleList { get; set; }
    }

    public class UserViewModel
    {
        public string UserName { get; set; }

        public string NickName { get; set; }

        public string Password { get; set; }

        public int RoleId { get; set; }
    }
}