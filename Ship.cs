using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebulousFleetGenerator
{
    public abstract class Ship
    {
        public string Name { get; set;}
        public int power { get; set; }
        public int crew { get; set; }

        public List<Slot> slots { get; set; }

        public abstract void GenerateSlots();
    }
}
