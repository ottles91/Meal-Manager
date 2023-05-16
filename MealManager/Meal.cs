using System;
namespace MealManager
{
	public class Meal
	{
		private string Name { get; }
		//TODO: Add a list of ingredients

		public Meal()
		{
		}

		public Meal(string name)
		{
			Name = name;
		}
	}
}

