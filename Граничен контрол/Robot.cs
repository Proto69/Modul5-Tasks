using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Граничен_контрол
{
    public class Robot : IDs
    {
        public string Model { get; }
        public long ID { get; }

        public Robot(string model, long iD)
        {
            this.Model = model;
            this.ID = iD;
        }

        public long GetID()
        {
            return ID;
        }
    }
}
