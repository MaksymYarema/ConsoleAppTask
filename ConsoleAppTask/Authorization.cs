using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    class Authorization
    {
        //Поля
        private string name;
        private string password;
        private string email;
        //get, set
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //Конструктор
        public Authorization()
        {
            name = String.Empty;
            password = String.Empty;
            email = String.Empty;
        }
        //Методи
        public void ShowAll()
        {
            Console.WriteLine($"Name: " + name + $"\tPassword: " + password + $"\tEmail: " + email);
        }
        public void ShowNameAndPassword() 
        {
            Console.WriteLine($"Name: " + name + $"\tPassword: " + password);
        }
    }
}
