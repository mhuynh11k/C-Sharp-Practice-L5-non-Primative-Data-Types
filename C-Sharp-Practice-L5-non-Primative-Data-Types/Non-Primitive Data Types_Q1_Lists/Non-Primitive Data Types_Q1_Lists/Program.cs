//Part 1
//Create a list of 5 names and then print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.

List<string> names = new List<string>();
names.Add("Alice");
names.Add("Bob");
names.Add("Charlie");
names.Add("David");
names.Add("Eve");

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
//Part 2
//Using the list of names and find the name in the 3rd position and print it out to the console.
//Hint: You can use the index of the list to find the name in the 3rd position.

// Console.WriteLine(names[2]);  


//Part 3
//Using the list of names, remove the name in the 2nd position and then print the list out to the console.
//Hint: You can use the RemoveAt() method to remove an item from the list.
// names.RemoveAt(1);
// Console.WriteLine("After removing the name in the 2nd position:");
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }
//Part 4
//Using the list of names, add a new name to the list and then print the list out to the console.
//Hint: You can use the Add() method to add a new name to the list.

// names.Add("Frank");
// Console.WriteLine("After adding a new name:");
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

//Part 5
//Using the list of names , find the length of the list and print it out to the console.
//Hint: You can use the Count property to find the length of the list.
// Console.WriteLine($"The length of the list is: {names.Count}");
//Part 6
//Using the list of names , check if a name exists in the list and print out if it exists or not.
//Hint: You can use the Contains() method to check if a name exists in the list.
// string nameToCheck = "Frank";
// if (names.Contains(nameToCheck))
// {
//     Console.WriteLine($"{nameToCheck} exists in the list.");
// }
// else
// {
//     Console.WriteLine($"{nameToCheck} does not exist in the list.");
// }
//Part 7
//Using the list of names, find the index of a name in the list and print it out to the console.
//Hint: You can use the IndexOf() method to find the index of a name in the list.
// string nameToFind = "Charlie";
// int index = names.IndexOf(nameToFind);
// if (index != -1)
// {
//     Console.WriteLine($"{nameToFind} is found at index: {index}");
// }
// else
// {
//     Console.WriteLine($"{nameToFind} is not found in the list.");
// }
//Part 8
//Using the list of names, insert a new name at the 3rd position and print the list out to the console.
//Hint: You can use the Insert() method to insert a new name at a specific position in the list.
names.Insert(2, "Grace");
Console.WriteLine("After inserting a new name at the 3rd position:");
foreach (string name in names)
{
    Console.WriteLine(name);
}
//Part 9
//Using the list of names, sort the list and print it out to the console.
//Hint: You can use the Sort() method to sort the list.
// names.Sort();
// Console.WriteLine("After sorting the list:");
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

//Part 10
//Using the list of names , use findlastindex() method to find the last index of a name in the list and print it out to the console.
//Hint: You can use the FindLastIndex() method to find the last index of a name in the list.
int lastIndex = names.FindLastIndex(name => name == "Alice");
Console.WriteLine($"The last index of 'Alice' is: {lastIndex}");

//Part 11
//Using the list of names, clear the list and print the list out to the console.
//Hint: You can use the Clear() method to clear the list.
names.Clear();
Console.WriteLine("After clearing the list:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Part 12
//Create a new list of strings and integers and print them out to the console.
//Hint: You can use the Add() method to add items to the list and then use a foreach loop to print them out to the console.
names.Add("Hannah");
names.Add("Ivy");
names.Add("Jack");
names.Add("Karen");
names.Add("Leo");
foreach (string name in names)
{
    Console.WriteLine(name);
}



