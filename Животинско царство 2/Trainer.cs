using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Животинско_царство_2
{
    public class Trainer
    {
        public IAnimal Entity { get; set; }

        public Trainer(IAnimal entity)
        {
            this.Entity = entity;
        }

        public void Make()
        {
            Entity.Perform();
        }
    }
}
