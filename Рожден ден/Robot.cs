using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Рожден_ден.Interfaces;

namespace Рожден_ден
{
    public class Robot : IID
    {
        public string Model { get; }
        public long ID { get; }

        public Robot(string model, long iD)
        {
            Model = model;
            ID = iD;
        }

        public long GetID()
        {
            return ID;
        }
    }
}
