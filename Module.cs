using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using NPOI.SS.Formula.Functions;

namespace NebulousFleetGenerator
{
    public static class ModuleRegistry
    {
        public static ReadOnlyCollection<Module> Modules { get; }

        // Static constructor to initialize the Modules collection
        static ModuleRegistry()
        {
            List<Module> modules = new List<Module>
            {
                new Module { Name = "Mk61 Cannon", Type = "Weapon", Location = "Mount", Size1 = 3, Size2 = 1, Size3 = 3, AmmoType = "120mm", Power = -50, Crew = -4 },
                new Module { Name = "Mk62 Cannon", Type = "Weapon", Location = "Mount", Size1 = 3, Size2 = 1, Size3 = 3, AmmoType = "120mm", Power = -50, Crew = -8 },
                new Module { Name = "Mk64 Cannon", Type = "Weapon", Location = "Mount", Size1 = 3, Size2 = 1, Size3 = 5, AmmoType = "250mm", Power = -125, Crew = -15 },
                new Module { Name = "Basic CIC" , Type = "Command", Location = "Compartment", Size1 = 4, Size2 = 1, Size3 = 6, AmmoType = "", Power = 0, Crew = -20 },
                new Module { Name = "Reinforced CIC", Type = "Command", Location = "Compartment", Size1 = 4, Size2 = 1, Size3 = 6, AmmoType = "", Power = 0, Crew = -20 },
                new Module { Name = "FR3300 Micro Reactor", Type = "powerplant", Location = "Module", Size1 = 3, Size2 = 3, Size3 = 3, AmmoType = "", Power = 2250, Crew = -5 },
                new Module { Name = "FR4800 Reactor", Type = "powerplant", Location = "Module", Size1 = 5, Size2 = 5, Size3 = 5, AmmoType = "", Power = 4200, Crew = -10 },
                new Module { Name = "FM200", Type = "Propulsion", Location = "Module", Size1 = 5, Size2 = 3, Size3 = 5, AmmoType = "", Power = 500, Crew = -10 },
                new Module { Name = "FM200R", Type = "Propulsion", Location = "Module", Size1 = 5, Size2 = 3, Size3 = 5, AmmoType = "", Power = 500, Crew = -10 },
                new Module { Name = "Berthing", Type = "crew", Location = "Compartment", Size1 = 1, Size2 = 1, Size3 = 1, AmmoType = "", Power = 0, Crew = 3 },
                new Module { Name = "Bulk Magazine", Type = "Storage", Location = "Compartment", Size1 = 1, Size2 = 1, Size3 = 1, AmmoType = "", Power = 0, Crew = 0 },
                new Module { Name = "Reinforced Magazine", Type = "Storage", Location = "Compartment", Size1 = 1, Size2 = 1, Size3 = 1, AmmoType = "", Power = 0, Crew = 0 }
            };
            Modules = new ReadOnlyCollection<Module>(modules);
        }
    }
    
    public class Module
    {
        string name;
        string type;
        string location;
        int size1;
        int size2;
        int size3;
        string ammoType;
        int power;
        int crew;
    
        //create all properties to allow get methods
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public int Size1
        {
            get { return size1; }
            set { size1 = value; }
        }
        public int Size2
        {
            get { return size2; }
            set { size2 = value; }
        }
        public int Size3
        {
            get { return size3; }
            set { size3 = value; }
        }
        public string AmmoType
        {
            get { return ammoType; }
            set { ammoType = value; }
        }
        public int Power
        {
            get { return power; }
            set { power = value; }
        }
        public int Crew
        {
            get { return crew; }
            set { crew = value; }
        }

        public List<Module> generateModules()
        {
            var modules = new List<Module>
            {
                new Module { name = "Mk61 Cannon", type = "Weapon", location = "Mount", size1 = 3, size2 = 1, size3 = 3, ammoType = "120mm", power = -50, crew = -4 },
                new Module { name = "Mk62 Cannon", type = "Weapon", location = "Mount", size1 = 3, size2 = 1, size3 = 3, ammoType = "120mm", power = -50, crew = -8 },
                new Module { name = "Mk64 Cannon", type = "Weapon", location = "Mount", size1 = 3, size2 = 1, size3 = 5, ammoType = "250mm", power = -125, crew = -15 },
                new Module { name = "Basic CIC" , type = "Command", location = "Compartment", size1 = 4, size2 = 1, size3 = 6, ammoType = "", power = 0, crew = -20 },
                new Module { name = "Reinforced CIC", type = "Command", location = "Compartment", size1 = 4, size2 = 1, size3 = 6, ammoType = "", power = 0, crew = -20 },
                new Module { name = "FR3300 Micro Reactor", type = "powerplant", location = "Module", size1 = 3, size2 = 3, size3 = 3, ammoType = "", power = 2250, crew = -5 },
                new Module { name = "FR4800 Reactor", type = "powerplant", location = "Module", size1 = 5, size2 = 5, size3 = 5, ammoType = "", power = 4200, crew = -10 },
                new Module { name = "FM200", type = "Propulsion", location = "Module", size1 = 5, size2 = 3, size3 = 5, ammoType = "", power = 500, crew = -10 },
                new Module { name = "FM200R", type = "Propulsion", location = "Module", size1 = 5, size2 = 3, size3 = 5, ammoType = "", power = 500, crew = -10 },
                new Module { name = "Berthing", type = "Crew", location = "Compartment", size1 = 1, size2 = 1, size3 = 1, ammoType = "", power = 0, crew = 3 },
                new Module { name = "Bulk Magazine", type = "Storage", location = "Compartment", size1 = 1, size2 = 1, size3 = 1, ammoType = "", power = 0, crew = 0 },
                new Module { name = "Reinforced Magazine", type = "Storage", location = "Compartment", size1 = 1, size2 = 1, size3 = 1, ammoType = "", power = 0, crew = 0 },
                new Module { name = "RS35 'Frontline' Radar", type = "Radar", location = "Module", size1 = 2, size2 = 2, size3 = 2, ammoType = "", power = -2000, crew = 0 }
            };
            return modules;
        }

    }
}
