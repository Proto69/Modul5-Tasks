using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реализация_на_Събитие
{
    public class Handler
    {
        public static void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"Dispatcher’s name changed to {args.Name}");
        }
    }
}
