using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        // create the world for us
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Farmer's Field",
                "There are rows of corn growing here, with giant rats hiding between them", 
                "/Engine;Component/Images/Locations/FarmFields.png");

            newWorld.AddLocation(-1, -1, "Farmer's House", 
                "This is the house of your neighbor, Farmer Ted.", 
                "/Engine;Component/Images/Locations/Farmhouse.png");

            newWorld.AddLocation(0, -1, "Home", 
                "This is your home.",
                "/Engine;Component/Images/Locations/Home.png");

            return newWorld;
        }
    }
}
