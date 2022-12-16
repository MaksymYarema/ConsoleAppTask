using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    class Show
    {
        //Методи
        public void ShowAuthorization()
        {
            Authorization Person1 = new Authorization();
            Person1.Name = $"Maksym";
            Person1.Password = $"1234567890";
            Person1.Email = $"test.test@gmail.com";
            Person1.ShowAll();
            Person1.ShowNameAndPassword();
        }
        public void ShowMath()
        {
            Math Test1 = new Math();
            Test1.Num1 = 10;
            Test1.Num2 = 5;
            Test1.Show();
            Test1.Add();
            Test1.Minus();
            Test1.Multiply();
            Test1.Division();
        }
    }
}
