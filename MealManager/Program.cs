using MealManager;

bool terminateProgram = false;

//Create the MealBook object to handle the meals
MealBook book = new MealBook();

void DisplayMenu()
{
    while (!terminateProgram)
    {
        Console.WriteLine("Welcome! Enter a meal name to add it to your Meal Book, or type quit to exit");
        string input = Console.ReadLine();

        //Quit the program if the user entered "quit"
        if (input.ToLower() == "quit")
        {
            Console.WriteLine("Goodbye!");
            terminateProgram = true;
            //Console.ReadKey();
        }
        else
        {
            bool sucessfullyAdded = ProcessInput(input);

            //If the meal was sucessfully added then inform the user and go back to the top
            if(sucessfullyAdded)
            {
                Console.WriteLine("Successfully added!");
                continue;
            }
        }

    }
}

bool ProcessInput(string input)
{
    if (input == null)
    {
        return false;
    }
    else
    {
        //Create a new Meal object with the name inputted by the user
        bool successfullyAdded = book.addMeal(input);
        return successfullyAdded;
    }
}

DisplayMenu();