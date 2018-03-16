using System;
using Engine.Models;

namespace Engine.ViewModels
{
	public class GameSession
	{
		public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }

		public GameSession()
		{
			//This is a constructor
			CurrentPlayer = new Player();
			CurrentPlayer.Name = "Jovan";
			CurrentPlayer.CharacterClass = "Fighter";
			CurrentPlayer.HitPoints = 10;
			CurrentPlayer.Gold = 1000000;
			CurrentPlayer.ExperiencePoints = 0;
			CurrentPlayer.Level = 1;

            CurrentLocation = new Models.Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house.";
            CurrentLocation.ImageName = "/Engine;Component/Images/Locations/Home.png";
		}
	}
}
