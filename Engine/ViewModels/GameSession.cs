using System;
using Engine.Models;

namespace Engine.ViewModels
{
	public class GameSession
	{
		Player CurrentPlayer {get; set;}
		
		public GameSession()
		{
			// This is the constructor
			CurrentPlayer = new Player();
			CurrentPlayer.Name = "Jovan";
			CurrentPlayer.Gold = 1000000;
		}
	}
}
