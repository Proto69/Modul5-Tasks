using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Царски_гамбит
{
    internal class King
    {
        public string Name { get; set; }
        private bool isUnderAttack;
        public bool IsUnderAttack
        {
            get
            {
                return isUnderAttack;
            }
            set
            {
                isUnderAttack = value;
            }
        }

        public King(string name)
        {
            this.Name = name;
        }
    }
}
