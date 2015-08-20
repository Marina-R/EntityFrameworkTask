using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EFTask.Models;

namespace EFTask.DAL
{
    public class UserInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            var users = new List<User>
            {
                new User{FirstName="Amelia",LastName="Romaniuk",Email="test@test.com",PhoneNumber="12232342312"},
                new User{FirstName="Pasha",LastName="Sasha",Email="test2@test.com",PhoneNumber="12232342852"}
            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
        }
    }
}