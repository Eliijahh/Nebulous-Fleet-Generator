using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NebulousFleetGenerator
{
    class RandomShipName
    {
        static Random rand = new Random();
        static String[] prefix = { "USS", "HMS", "HMS", "INS", "KMS", "JDS" };
        static String[] mainName = { "Indomitable", "Helpless", "Strongman", "Rocinante", "Eclipse", "Vanguard", "Sovereign", "Exodus", "Odyssey", "Harbinger", "Elysium", "Paragon",
            "Celestial", "Ascendant", "Infinity", "Orion", "Nebula", "Zenith", "Mirage", "Nova", "Pulsar", "Galaxy", "Meteor", "Comet", "Specter", "Ethereal", "Phantom", "Revenant",
            "Emissary", "Sentinel", "Guardian", "Arbiter", "Renegade", "Pioneer", "Nomad", "Marauder", "Voyager", "Seeker", "Pathfinder", "Reclaimer", "Avenger", "Savior", "Rebel",
            "Warlock", "Paladin", "Titan", "Colossus", "Goliath", "Behemoth", "Leviathan", "Phoenix", "Dragoon", "Corsair", "Ranger", "Strider", "Explorer", "Wanderer", "Adventurer",
            "Prospector", "Discoverer", "Surveyor", "Watcher", "Observer", "Visionary", "Dreamer", "Mystic", "Oracle", "Prophet", "Sage", "Seer", "Enlightener", "Preserver", "Custodian",
            "Architect", "Builder", "Creator", "Originator", "Smith", "Forger", "Artisan", "Craftsman", "Maestro", "Virtuoso", "Champion", "Hero", "Legend", "Mythic", "Epic", "Saga", "Tale",
            "Chronicle", "Record", "History", "Legacy", "Relic", "Artifact", "Heirloom", "Antique", "Curio", "Rarity", "Gem", "Jewel"};

        //generate 50 names that would fix well for a spaceship
        public string generate()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(prefix[rand.Next(prefix.Length)]);
            sb.Append(" ");
            sb.Append(mainName[rand.Next(mainName.Length)]);
            return sb.ToString();
        }   
    }
}
