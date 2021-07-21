﻿namespace CarRentalSystem.Application.Features.Identity
{
    public class UserInputModel
    {
        internal UserInputModel(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public string Email { get; }

        public string Password { get; }
    }
}
