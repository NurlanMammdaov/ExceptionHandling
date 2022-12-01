using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpEx
{
    internal class Person
    {
        private byte _age;
        public byte Age
        {
            get => _age;
            set
            {
                if(value <=0)
                {
                    throw new InvailedAgeException("Yas 0 dan kicik ola bilmez");
                   
                }
            }
        }
        public string Name { get; set; }
    }
}
