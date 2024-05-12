using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebulousFleetGenerator
{
    class SprinterShip : Ship
    {
        public SprinterShip()
        {
            power = 0;
            crew = 40;
            shipClass = "Sprinter";
            slots = GenerateSlots();
            InstallStandardModules(slots);  
        }

        public override List<Slot> GenerateSlots()
        {
            slots = new List<Slot>
            {
                new Slot { name = "Mount 1", location = "Mount", size1 = 3, size2 = 4, size3 = 5 },
                new Slot { name = "Mount 2", location = "Mount", size1 = 3, size2 = 2, size3 = 3 },
                new Slot { name = "Mount 3", location = "Mount", size1 = 2, size2 = 2, size3 = 2 },
                new Slot { name = "Mount 4", location = "Mount", size1 = 2, size2 = 2, size3 = 2 },
                new Slot { name = "Compartment 1", location = "Compartment", size1 = 4, size2 = 1, size3 = 6 },
                new Slot { name = "Compartment 2", location = "Compartment", size1 = 4, size2 = 1, size3 = 6 },
                new Slot { name = "Compartment 3", location = "Compartment", size1 = 3, size2 = 1, size3 = 3 },
                new Slot { name = "Compartment 4", location = "Compartment", size1 = 3, size2 = 1, size3 = 3 },
                new Slot { name = "Module 1", location = "Module", size1 = 3, size2 = 3, size3 = 3 },
                new Slot { name = "Module 2", location = "Module", size1 = 8, size2 = 3, size3 = 6 },
                new Slot { name = "Module 3", location = "Module", size1 = 2, size2 = 2, size3 = 2 },
                new Slot { name = "Module 4", location = "Module", size1 = 2, size2 = 2, size3 = 2 }
            };

            return slots;
        }

        public override void InstallStandardModules(List<Slot> slots)
        {
            slots.Single(s => s.name == "Compartment 1").installModule(ModuleRegistry.Modules.Single(m => m.Name == "Basic CIC"));
            slots.Single(s => s.name == "Module 1").installModule(ModuleRegistry.Modules.Single(m => m.Name == "FR3300 Micro Reactor"));
            slots.Single(s => s.name == "Module 2").installModule(ModuleRegistry.Modules.Single(m => m.Name == "FM200"));
            slots.Single(s => s.name == "Module 3").installModule(ModuleRegistry.Modules.Single(m => m.Name == "RS35 'Frontline' Radar"));
        }
    }
}
