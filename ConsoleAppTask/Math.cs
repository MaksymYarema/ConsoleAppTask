using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTask
{
    class Math
    {
        //Поля
        private double num1;
        private double num2;
        //get, set
        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }
        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
        //Конструктор
        public Math()
        {
            num1 = 0;
            num2 = 0;
        }
        public Math(double value1, double value2)
        {
            num1 = value1;
            num2 = value2;
        }
        //Методи
        public void Show()
        {
            Console.WriteLine($"Num1: " + num1 + $"\tNum2: " + num2);
        }
        public void Add()
        {
            double result = num1 + num2;
            Console.WriteLine($"Result: " + result);
        }
        public void Minus()
        {
            double result = num1 - num2;
            Console.WriteLine($"Result: " + result);
        }
        public void Multiply()
        {
            double result = num1 * num2;
            Console.WriteLine($"Result: " + result);
        }
        public void Division()
        {
            double result = num1 / num2;
            Console.WriteLine($"Result: " + result);
        }
    }
}
