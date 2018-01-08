using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MailSend
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBird;
        private string email;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfBird { get => dateOfBird; set => dateOfBird = value; }
        public string Email { get => email; set => email = value; }
    }
}
