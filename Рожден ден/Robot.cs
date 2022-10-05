using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Рожден_ден.Interfaces;

namespace Рожден_ден
{
    public class Robot : IID, IBirthday
    {
        public string Model { get; }
        public long ID { get; }
        public string Birthday { get; }

        public Robot(string model, long id)
        {
            Model = model;
            ID = id;
            this.Birthday = "00/00/0000";
        }

        public long GetID()
        {
            return ID;
        }

        public string GetBirthDay()
        {
            return Birthday;
        }
    }
}
