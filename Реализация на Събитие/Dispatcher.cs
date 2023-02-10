using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реализация_на_Събитие
{
    public delegate void NameChangeEventHandler();
    public class Dispatcher
    {
        //Името
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                //Стартиране
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        //Поддръжка на събитията
        private Handler handler;

        //Събитие
        private NameChangeEventHandler NameChange { get; set; }

        public Dispatcher()
        {
            handler = new();
        }

        //Засичане на събитието
        private void OnNameChange(NameChangeEventArgs args)
        {
            Handler.OnDispatcherNameChange(handler, args);
        }
    }
}
