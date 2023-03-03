using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyApplication.Models
{
    public class Clients
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? RegistrationDate { get; set; } = DateTime.Now;
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GenderCode { get; set; }
        public string PhotoPath { get; set; }
        public string Login { get; set; }
    }
}
