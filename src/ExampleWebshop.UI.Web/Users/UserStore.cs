using ExampleWebshop.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleWebshop.UI.Web.Users
{
    public class UserStore
    {
        private readonly string USER_STORE_PATH = Directory.GetCurrentDirectory() + @"\Users.txt";
        private readonly IPersonService personService;
        private const string ENCRYPTION_PASSWORD = "2GZCt7jkhm3f#VpvP$%@9IAWNa1pG53sXeKC33VLiec5USzDw*Aw&!Gq7#&EH&yn";

        private Dictionary<string, string> Users;

        public UserStore(IPersonService personService)
        {
            if (File.Exists(USER_STORE_PATH))
            {
                Users = JsonConvert.DeserializeObject<Dictionary<string, string>>(StringCipher.Decrypt(File.ReadAllText(USER_STORE_PATH), ENCRYPTION_PASSWORD));
            }
            else
            {
                Users = new Dictionary<string, string>();
            }   

            this.personService = personService;
        }
        
        public Person GetPerson(string email)
        {
            return personService.Get(email);
        }

        public bool Validate(string email, string password)
        {
            return Users.ContainsKey(email) && BCrypt.Net.BCrypt.Verify(password, Users[email]);
        }

        public bool Register(Person person, string password)
        {
            if (personService.Exists(person.Email))
            {
                return false;
            }

            if (Users.ContainsKey(person.Email))
            {
                return false;
            }

            personService.Add(person);
            Users[person.Email] = BCrypt.Net.BCrypt.HashPassword(password);
            File.WriteAllText(USER_STORE_PATH, StringCipher.Encrypt(JsonConvert.SerializeObject(Users), ENCRYPTION_PASSWORD));

            return true;
        }
    }
}
