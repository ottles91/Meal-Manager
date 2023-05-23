using System;
namespace MealManager
{
	public class MealBook
	{
		public List<Meal> meals { get; }

		//Takes a meal object and adds it to the master list
		public bool addMeal(Meal meal)
		{
			if(meal == null)
			{
				return false;
			}
			else
			{
				meals.Add(meal);
				return true; 
			}
		}

		//Takes a string, creates a meal object and adds it to the master list
		public bool addMeal(string meal)
		{
			if(meal == null)
			{
				return false;
			}
			else
			{
				Meal meal1 = new Meal(meal);
				meals.Add(meal1);
				return true; 
			}
		}

		public MealBook()
		{
			//Initiate the mast list
			meals = new List<Meal>();
		}
	}
}

