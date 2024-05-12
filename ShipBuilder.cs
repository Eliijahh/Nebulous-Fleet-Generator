using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace NebulousFleetGenerator
{
    class ShipBuilder
    {
        List<Module> modules = new List<Module>();
        public void generateModules()
        {
            Module moduleGenerator = new Module();
            List<Module> modules = moduleGenerator.generateModules();
        }

        public Ship generate()
        {
            //initialise the SprinterShip class
            var sprinterShip = new SprinterShip();

            //generate the slots for the ship
            sprinterShip.GenerateSlots();

            //generate a random name for the ship
            var randomShipName = new RandomShipName();
            sprinterShip.name = randomShipName.generate();

            //add standard modules to the sprinter ship
            sprinterShip.slots.Single(s => s == "");

            return sprinterShip;
        }

        private 

        //create a for loop to perform a loop x number of times depending on the number that was enetered in the SprinterNumberTextBox
        
}

