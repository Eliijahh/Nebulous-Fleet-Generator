using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebulousFleetGenerator
{
    class SprinterShip : Ship
    {
        int power = 0;
        int crew = 40;

        public override void GenerateSlots()
        {
            slots = new List<Slot>
            {
                new Slot { Name = "Mount 1", Location = "Mount", Size1 = 3, Size2 = 4, Size3 = 5 },
                new Slot { Name = "Mount 2", Location = "Mount", Size1 = 3, Size2 = 2, Size3 = 3 },
                new Slot { Name = "Mount 3", Location = "Mount", Size1 = 2, Size2 = 2, Size3 = 2 },
                new Slot { Name = "Mount 4", Location = "Mount", Size1 = 2, Size2 = 2, Size3 = 2 },
                new Slot { Name = "Compartment 1", Location = "Compartment", Size1 = 4, Size2 = 1, Size3 = 6 },
                new Slot { Name = "Compartment 2", Location = "Compartment", Size1 = 4, Size2 = 1, Size3 = 6 },
                new Slot { Name = "Compartment 3", Location = "Compartment", Size1 = 3, Size2 = 1, Size3 = 3 },
                new Slot { Name = "Compartment 4", Location = "Compartment", Size1 = 3, Size2 = 1, Size3 = 3 },
                new Slot { Name = "Module 1", Location = "Module", Size1 = 3, Size2 = 3, Size3 = 3 },
                new Slot { Name = "Module 2", Location = "Module", Size1 = 8, Size2 = 3, Size3 = 6 },
                new Slot { Name = "Module 3", Location = "Module", Size1 = 2, Size2 = 2, Size3 = 2 },
                new Slot { Name = "Module 4", Location = "Module", Size1 = 2, Size2 = 2, Size3 = 2 }
            };
        }
    }
}
