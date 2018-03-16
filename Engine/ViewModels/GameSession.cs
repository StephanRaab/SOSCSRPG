using System;
using Engine.Models;

namespace Engine.ViewModels
{
	public class GameSession
	{
		public Player CurrentPlayer {get; set;}

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
		}
	}
}
