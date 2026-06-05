//---------------------------------------------------------------------
// Question 1: Weekday Enumeration
// Define an enum named "Weekday" to represent the days of the week (Monday to Sunday) in English.
// Hint: Use the provided Vietnamese example as a reference to declare the enum in English.
/* Enums are commonly used to represent a fixed set of values, such as the days of the week, ensuring consistency and preventing invalid values. */
enum Weekday
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
//---------------------------------------------------------------------
// Question 2: Enemy State Enumeration
// Define an enum named "EnemyState" to represent the states of an enemy in a game (Idle, Patrol, Attack).
// Hint: Use descriptive terms to indicate the different states of an enemy in a game scenario.
/* Enums can encapsulate the various states of an enemy character in a game, such as when they are idle, patrolling, or attacking. */
enum EnemyState
{
    Idle,
    Patrol,
    Attack
}
//---------------------------------------------------------------------
// Question 3: Flight Status Enumeration
// Define an enum named "FlightStatus" to represent the status of a character's flight in a 2D platformer game (Ascending, Descending, Stationary).
// Hint: Use descriptive terms to indicate the different states of flight in the enum.
/* Enums are useful for defining and managing various states or conditions within a game, such as character flight status. */
enum FlightStatus
{
    Ascending,
    Descending,
    Stationary
}

//---------------------------------------------------------------------
// Question 4: Title Rank Enumeration
// Define an enum named "TitleRank" to represent possible ranks or titles (Beginner, Intermediate, Advanced) in English.
// Hint: Apply the same enum declaration principles to define ranks or titles for users or characters in a game or application.
/* Enums facilitate the organization and categorization of ranks or titles, serving as constants within the program. */
enum TitleRank
{
    Beginner,
    Intermediate,
    Advanced
}

//---------------------------------------------------------------------
// Question 5: Player Movement Enumeration
// Define an enum named "PlayerMovement" to represent the movement states of a player in a game (Idle, Walk, Run).
// Hint: Use descriptive terms to indicate the different states of player movement in a game scenario.
/* Enums can define various movement states for a player character in a game, simplifying the logic for handling different movement actions and transitions. */
enum PlayerMovement
{
    Idle,
    Walk,
    Run
}
//---------------------------------------------------------------------
// Question 6: Accessing Enum Data
// Write a C# program to access the enum data representing the days of the week.
// Hint: Use the provided "DayOfWeek" enum and display the names of different days using Console.WriteLine().
/* Enums allow easy access to predefined values, ensuring consistency and preventing errors when working with specific sets of data. */

// Simple program demonstrating how to access and print enum values
class Program
{
    static void Main()
    {
        // Assign a specific enum value to a variable
        Weekday today = Weekday.Monday;
        Console.WriteLine($"Today is: {today}");

        // Print all values defined in the Weekday enum
        Console.WriteLine("All days of the week:");
        foreach (Weekday day in Enum.GetValues(typeof(Weekday)))
        {
            Console.WriteLine(day);
        }

        // Convert a string to the enum type safely
        string input = "Friday";
        if (Enum.TryParse<Weekday>(input, out Weekday parsedDay))
        {
            Console.WriteLine($"Parsed '{input}' into enum value: {parsedDay}");
        }

        // Wait for user so the console stays open when run outside an IDE
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
