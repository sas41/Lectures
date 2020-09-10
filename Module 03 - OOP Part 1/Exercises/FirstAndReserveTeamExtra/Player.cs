using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeamExtra
{
    class Player
    {
		private string name;

		public string Name
		{
			get { return name; }
			set
			{
				if (value == null || value == "")
				{
					Console.WriteLine("Name cannot be null or empty!");
					return;
				}
				name = value;
			}
		}


		private int endurance;
		private int Endurance
		{
			get { return endurance; }
			set
			{
				if (value < 0 || value > 100)
				{
					Console.WriteLine("Endurance shoud be betweeon 0 and 100");
					return;
				}
				endurance = value;
			}
		}


		private int sprint;
		private int Sprint
		{
			get { return sprint; }
			set
			{
				if (value < 0 || value > 100)
				{
					Console.WriteLine("Sprint shoud be betweeon 0 and 100");
					return;
				}
				sprint = value;
			}
		}


		private int dribble;
		private int Dribble
		{
			get { return dribble; }
			set
			{
				if (value < 0 || value > 100)
				{
					Console.WriteLine("Dribble shoud be betweeon 0 and 100");
					return;
				}
				dribble = value;
			}
		}


		private int passing;
		private int Passing
		{
			get { return passing; }
			set
			{
				if (value < 0 || value > 100)
				{
					Console.WriteLine("Passing shoud be betweeon 0 and 100");
					return;
				}
				passing = value;
			}
		}


		private int shooting;
		private int Shooting
		{
			get { return shooting; }
			set
			{
				if (value < 0 || value > 100)
				{
					Console.WriteLine("Shooting shoud be betweeon 0 and 100");
					return;
				}
				shooting = value;
			}
		}

		public int Average
		{
			get
			{
				return Convert.ToInt32(Math.Round((Endurance + Sprint + Dribble + Passing + shooting) / 5.0));
			}
		}

		public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
		{
			Name = name;
			Endurance = endurance;
			Sprint = sprint;
			Dribble = dribble;
			Passing = passing;
			Shooting = shooting;
		}
	}
}
