using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebulousFleetGenerator
{
    public class Module
    {
        private string Name { get; set; }
        public string getName()
        {
            return Name;
        }

        string Type { get; set; }
        string location { get; set; }
        string Size1 { get; set; }
        string Size2 { get; set; }
        string Size3 { get; set; }
        string AmmoType { get; set; }
        string Power { get; set; }
        string Crew { get; set; }
    
        public List<Module> generateModules()
        {
            var modules = new List<Module>
            {
                new Module { Name = "Mk61 Cannon", Type = "Weapon", location = "Mount", Size1 = "3", Size2 = "1", Size3 = "3", AmmoType = "120mm", Power = "-50", Crew = "-4" },
                new Module { Name = "Mk62 Cannon", Type = "Weapon", location = "Mount", Size1 = "3", Size2 = "1", Size3 = "3", AmmoType = "120mm", Power = "-50", Crew = "-8" },
                new Module { Name = "Mk64 Cannon", Type = "Weapon", location = "Mount", Size1 = "3", Size2 = "1", Size3 = "5", AmmoType = "250mm", Power = "-125", Crew = "-15" },
                new Module { Name = "Basic CIC" , Type = "Command", location = "Compartment", Size1 = "4", Size2 = "1", Size3 = "6", AmmoType = "", Power = "0", Crew = "-20" },
                new Module { Name = "Reinforced CIC", Type = "Command", location = "Compartment", Size1 = "4", Size2 = "1", Size3 = "6", AmmoType = "", Power = "0", Crew = "-20" },
                new Module { Name = "FR3300 Micro Reactor", Type = "Powerplant", location = "Module", Size1 = "3", Size2 = "3", Size3 = "3", AmmoType = "", Power = "2250", Crew = "-5" },
                new Module { Name = "FR4800 Reactor", Type = "Powerplant", location = "Module", Size1 = "5", Size2 = "5", Size3 = "5", AmmoType = "", Power = "4200", Crew = "-10" },
                new Module { Name = "FM200", Type = "Propulsion", location = "Module", Size1 = "5", Size2 = "3", Size3 = "5", AmmoType = "", Power = "500", Crew = "-10" },
                new Module { Name = "FM200R", Type = "Propulsion", location = "Module", Size1 = "5", Size2 = "3", Size3 = "5", AmmoType = "", Power = "500", Crew = "-10" },
                new Module { Name = "Berthing", Type = "Crew", location = "Compartment", Size1 = "1", Size2 = "1", Size3 = "1", AmmoType = "", Power = "0", Crew = "3" },
                new Module { Name = "Bulk Magazine", Type = "Storage", location = "Compartment", Size1 = "1", Size2 = "1", Size3 = "1", AmmoType = "", Power = "0", Crew = "0" },
                new Module { Name = "Reinforced Magazine", Type = "Storage", location = "Compartment", Size1 = "1", Size2 = "1", Size3 = "1", AmmoType = "", Power = "0", Crew = "0" }
            };

            return modules;
        }

    }
}
