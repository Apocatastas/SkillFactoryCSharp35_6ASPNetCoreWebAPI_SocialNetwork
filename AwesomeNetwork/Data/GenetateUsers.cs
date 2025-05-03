using AwesomeNetwork.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeNetwork.Data
{
    public class GenetateUsers
    {
        public readonly string[] maleNames = new string[] { "Aidan", "Khalid", "Ash", "Nimus", "Pair", "Christian", "Straker", "Vokhial", "Moandor", "Ajith" };
        public readonly string[] femaleNames = new string[] { "Aeris", "Giselle", "Melodie", "Charna", "Valeska", "Vedomina", "Sinxa" };
        public readonly string[] lastNames = new string[] { "Inferno", "Castle", "Nekropolis", "Citadel", "Tower" };

        public List<User> Populate(int count)
        {
            var users = new List<User>();
            for (int i = 1; i < count; i++)
            {
                string firstName;
                var rand = new Random();

                var male = rand.Next(1, 2) == 1;

                var lastName = lastNames[rand.Next(0, lastNames.Length - 1)];
                if (male)
                {
                    firstName = maleNames[rand.Next(0, maleNames.Length - 1)];
                }
                else
                {
                    lastName = lastName + "a";
                    firstName = femaleNames[rand.Next(0, femaleNames.Length - 1)];
                }

                var item = new User()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = DateTime.Now.AddDays(-rand.Next(1, (DateTime.Now - DateTime.Now.AddYears(-25)).Days)),
                    Email = "hero" + rand.Next(0, 1204) + "@heroes.com",
                };

                item.UserName = item.Email;
                item.Image = "https://apocatastas.github.io/thebestdeveloperever/dummy.png";

                users.Add(item);
            }

            return users;
        }
    }
}
