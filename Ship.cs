using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebulousFleetGenerator
{
    public abstract class Ship
    {
        public string name { get; set;}
        public string shipClass { get; set;}
        public int power { get; set; }
        public int crew { get; set; }
        public List<Slot> slots { get; set; }
        public abstract List<Slot> GenerateSlots();
        //update the power and crew of the ship according to the installed modules
        public void UpdatePowerAndCrew()
        {
            foreach (Slot slot in slots)
            {
                if (slot.InstalledModule != null)
                {
                    power += slot.InstalledModule.Power;
                    crew += slot.InstalledModule.Crew;
                }
            }
        }
        public abstract void InstallStandardModules(List<Slot> slots);
    }
}
