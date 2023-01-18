////Task: Write a program that will recognize invalid inputs when the user requests information about students in a class.

//What will the application do?

//-     2 Points: Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food

//-     1 Point: Prompt the user to ask about a particular student by number. Convert the input to an integer. Use the integer as the index for the arrays. Print the student’s name.

//-     1 Point: Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.

//-     1 Point: Ask the user if they would like to learn about another student.
//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


//Build Specifications:
//-     1 Point: Validate user number: Use an if statement to check if the number is out of range, i.e. either less than 1 or greater than the length of the arrays.
//If so, display a friendly message and let the user try again.

//-     1 Point: Validate category: Ask the user what information category to display: "Hometown" or "Favorite Food". Use an if statement to check that they entered
//either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question. (See hints below!)

//-     1 Point: Array Length: Use the first array’s Length property in your code instead of hardcoding it.

//Hints:
//-     Make sure the arrays are the same size.

//-     Let the user enter a number from 1 up to and including the length of the array. To get the index, subtract 1 from the number they entered.

//-     For the valid category: You might create a separate program to test out some code that uses a while loop and asks for either “Hometown” or “Favorite Food.” And
//only finishes the loop if either of these two is entered. Once you have it working, copy the code over to your “real” code.

//-     Make it easy for the user – tell them what information is available

//-     Try to use good grammar. Make your messages polite.

//Extra Challenges:
//-     1 Point: Provide an option where the user can see a list of all students.

//-     2 Points: Allow the user to search by student name (Good challenge but difficult!)

//-     1 Point: Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"


//2 Points: Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
//bool showNames = true;
string[] StudentName = { "Justin Jones", "Ethan Thomas", "Belle Baxley", "Allison Jones", "John Glandon", "Michael Blackburn",
    "Christopher Washington", "Earle Fox", "Joshua Carolin", "Mourad Alfadil", "Tee Sotomi", "Wilfredo Pacheco", "Jun Kim",
    "Jason Garrison", "Cam Dixon", "Josh Strathres" };
string[] towns = { "Columbus", "Urbana", "Haleiwa", "Grand Rapids", "Detroit", "Warren", "Detroit", "Saline", "Westland",
    "Detroit", "Chicago", "Canton", "Lubbock", "Chelsea", "South Lyon", "Oxford" };
string[] foods = { "Baja Blast", "Hot Wings", "french fries", "Pad Ke Mao", "Stir fry", "Anpan", "Egg roll", "Pizza",
    "Naleśniki", "Fried Rice", "Pasta", "Quesadilla", "noodles", "Chewing Tobacco", "Coney Dogs", "Pizza" };
Console.WriteLine("Welcome!");
//Console.WriteLine("Would you like to see a list of all students in the class? Type either a yes or a no.");

//string display = Console.ReadLine();
//while (showNames == true)
//{
//  if (display == "yes" || display == "y")
//  {
//    foreach (string n in StudentName) //this displays all objects inside of the array
//    {
//      Console.WriteLine(n);
//    }
//  }
//  else if (display == "no" || display == "n")
//  {
//    showNames = true;
//    break;
//  }
//  else
//    Console.WriteLine($"\n{display} is not a correct response. Please enter a either a yes or a no.");
//  showNames = true;
//  break;
//}
bool restart = true;

Console.WriteLine("Enter a whole number from 1-16:\n");
while (restart)
{
  int locInArray = int.Parse(Console.ReadLine().ToLower().Trim());
  if (locInArray > 0 && locInArray <= StudentName.Length + 1)
  {
    Console.WriteLine($"\nStudent {locInArray} is {StudentName[locInArray - 1]}.");
    bool looping = true;
    while (looping)
    {
      Console.WriteLine("What would you like to learn about them? Enter either \"hometown\" or \"favorite food\":");
      string CategoryChoice = Console.ReadLine().Trim();
      if (CategoryChoice == "hometown" || CategoryChoice == "home town" || CategoryChoice == "Home Town" || CategoryChoice == "Hometown" || CategoryChoice == "town" || CategoryChoice == "Town")
      {
        Console.WriteLine($"\n{StudentName[locInArray - 1]} is from {towns[locInArray - 1]}.");
        Console.WriteLine("\nWould you like to learn about another student? Please enter either yes or no.");
        while (true)
        {
          string LearnMoreChoice = Console.ReadLine().ToLower().Trim();
          if (LearnMoreChoice == "yes" || LearnMoreChoice == "y")
          {
            Console.WriteLine("\nFantastic. Which student would you like to learn more about? Enter a differnt number from 1-16:");
            restart = true;
            looping = false;
            break;
          }
          else if (LearnMoreChoice == "no" || LearnMoreChoice == "n")
          {
            Console.WriteLine("\nHope you learned something kid. Have a good day.");
            restart = false;
            looping = false;
            break;
          }
          else
            Console.WriteLine($"\n{LearnMoreChoice} is not a correct response. Please enter a either a yes or a no.");
        }
      }
      else if (CategoryChoice == "favorite food" || CategoryChoice == "favoritefood")
      {
        Console.WriteLine($"\n{StudentName[locInArray - 1]} enjoys {foods[locInArray - 1]}.");
        Console.WriteLine("\nWould you like to learn about another student? Please enter either yes or no.");
        while (looping)
        {
          string LearnMoreChoice = Console.ReadLine().ToLower().Trim();

          if (LearnMoreChoice == "yes" || LearnMoreChoice == "y")
          {
            Console.WriteLine("\nFantastic. Which student would you like to learn more about? Enter a differnt number from 1-16:");
            restart = true;
            looping = false;
            break;
          }
          else if (LearnMoreChoice == "no" || LearnMoreChoice == "n")
          {
            Console.WriteLine("\nHope you learned something kid. Have a good day.");
            restart = false;
            looping = false;
            break;
          }
          else
            Console.WriteLine($"\n{LearnMoreChoice} is not a correct response. Please enter a either a yes or a no.");
        }
      }
      else
        Console.WriteLine($"\n{CategoryChoice} is not a correct response.");
    }
  }
  else
    Console.WriteLine($"\n{locInArray} is not a correct response. Please enter a whole number between 1 and 16.");
}



