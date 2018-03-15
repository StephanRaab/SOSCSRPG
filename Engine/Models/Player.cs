/*
 * Created by SharpDevelop.
 * User: stephan.raab
 * Date: 3/15/18
 * Time: 12:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Engine.Models
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public class Player
	{
		string Name { get; set; }
		string CharacterClass { get; set; }
		int HitPoints { get; set; }
		int ExperiencePoints { get; set; }
		int Level { get; set; }
		int Gold { get; set; }
	}
}
