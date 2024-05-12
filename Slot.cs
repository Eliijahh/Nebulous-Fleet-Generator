using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebulousFleetGenerator
{
    public class Slot
    {
        public string name { get; set; }
        public string location { get; set; }
        public int size1 { get; set; }
        public int size2 { get; set; }
        public int size3 { get; set; }
        Module installedModule { get; set; }
        public Module InstalledModule
        {
            get { return installedModule; }
        }

        //check if a module can be installed in the slot
        public bool canInstall(Module module)
        {
            if (module.Location == location && module.Size1 <= size1 && module.Size2 <= size2 && module.Size3 <= size3)
            {
                return true;
            }
            return false;
        }

        //install a module in the slot
        public void installModule(Module module)
        {
            if (canInstall(module))
            {
                installedModule = module;
            }
        }

        //uninstall a module from the slot
        public void uninstallModule(Module module) 
        { 
            installedModule = null;
        }

    }
}
