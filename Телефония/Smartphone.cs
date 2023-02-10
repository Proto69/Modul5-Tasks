using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Телефония.Interfaces;

namespace Телефония
{
    internal class Smartphone : ICall, IBrowse
    {

        public void Browse(string address)
        {
            if (address.Any(char.IsDigit))
                Console.WriteLine("Invalid Address");
            else
                Console.WriteLine($"Browsing: {address}");
        }

        public void Call(string number)
        {
            if (!number.All(char.IsDigit))
                Console.WriteLine("Invalid Number");
            else
                Console.WriteLine($"Calling... {number}"); ;
        }
    }
}
