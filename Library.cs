// GOALS set out for this APP
// Everyone likes IMDB... Now I want to make a little film library database of my own
// This will be a desktop App about movies I own/love/want to watch.
// At the finished Product of this App, the App should be able to:
// * Store data on a new movie
// * Retrieve data on a movie that exists in the library
// * Include search functionality and the ability to edit entries

// You can use Microsoft SQL Server for the database and Visual Studio for the front end. Add in other Amazing features you want
// Maybe I might add a feature that could pull data from IMDB to poppulate my application. 
// Other features could also pull images, movie posters and trailers from the web.


using System;
using System.Collections.Generic;

// Don't forget I am using the class System.Collections.Generic namespace because I want my Console App to be able to access Dictionaries in it

class Library
{
    static void Main()
    {
        Console.WriteLine("WELCOME aboard to MY FILM LIBRARY 1.0.1");
        Console.WriteLine("This is an App whose aim is to give you the best when it comes to of Film Libraries");
        Console.WriteLine();

        // Currently as at today: 1st of March 2023, my C# learning hasn't gotten me yet to databases But I would try as 
        // much as possible to replicate one(mock one based on my understanding)

        Console.WriteLine("What would you Like to do today?, Enter any of the following options:");
        Console.WriteLine();
        Console.WriteLine();

        // asling me user for what they want to do in me App
        // Console.WriteLine("Enter any of the following options:");
        // Console.WriteLine();
        // Console.WriteLine("Enter 'D'to add Data on a movie");
        // Console.WriteLine("Enter 'R'to Retrieve Data on a movie");
        // Console.WriteLine("Enter 'C'to comment potential fixes to a movie");
        // Console.WriteLine("Enter 'Boo'to rate a movie down");
        // Console.WriteLine("Enter 'Woo'to rate a movie up");

        Console.WriteLine("Enter 'S' to see the list of movies we have on our System or Enter 'X' to exit the Application");

        // working with lower or upper cases for my switch-case statement and reading line for user's answer
        string userFirstAnswer = Console.ReadLine().ToUpper();

        switch (userFirstAnswer)
        {
            case "S":
                Console.WriteLine("Here is a List of all the Movies we currently have on our Database");
                Console.WriteLine("1. Harry Potter");
                Console.WriteLine("2. Money Heist");
                Console.WriteLine("3. Shanty Town");
                Console.WriteLine("4. Till");

                Console.WriteLine();
                Console.WriteLine("Having said all of that, what would you lie to do today? ENter '1' for Harry Potter, '2' for Money Heist e.t.c");

                string userSecondAnswer = Console.ReadLine();
                int userSecondAnswerInInteger = int.Parse(userSecondAnswer);

                switch (userSecondAnswerInInteger)
                {
                    case 1:
                        Console.WriteLine("You have selected Harry Potter, what would you like to do to this Movie today?");
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Enter 'A'to add Data on the Harry Potter movie");
                        Console.WriteLine("Enter 'R'to Retrieve Data on the Harry Potter movie");
                        Console.WriteLine("Enter 'C'to comment potential fixes to the Harry Potter movie");
                        Console.WriteLine("Enter 'Boo'to rate the Harry Potter movie down");
                        Console.WriteLine("Enter 'Woo'to rate the Harry Potter movie up");
                        string harry = Console.ReadLine().ToUpper();

                        switch (harry)
                        {
                            case "A":
                                // data1
                                Console.WriteLine("Enter the data you want to add to the movie: harrry potter");
                                Console.WriteLine();
                                Console.WriteLine("Note: You are expected to add up to 5 data's on the selected Movie");

                                Console.WriteLine();
                                // Console.WriteLine();
                                // data2
                                string addHarryData = Console.ReadLine();

                                Console.WriteLine("Dear User, add in the second data on the Harry Potter Movie");

                                string addHarryData2 = Console.ReadLine();
                                // data3

                                Console.WriteLine("Dear User, add in the third data on the Harry Potter Movie");

                                string addHarryData3 = Console.ReadLine();

                                Console.WriteLine("add in the fourth data on the Harry Potter Movie");

                                string addHarryData4 = Console.ReadLine();


                                Console.WriteLine("add in the fifth data on the Harry Potter Movie");

                                string addHarryData5 = Console.ReadLine();

                                Console.WriteLine("Thank you very Much on all Data provided");

                                Console.WriteLine("Would you like to see each of the Data you enterred? [Enter 'Y' for yes and 'N' for No]");

                                string seeData = Console.ReadLine().ToUpper();

                                switch (seeData)
                                {
                                    case "Y":
                                        Console.WriteLine("Here is all the Data you Inputted");

                                        Dictionary<int, string> harryDictionary = new Dictionary<int, string>() { { 1, addHarryData }, { 2, addHarryData2 }, { 3, addHarryData3 }, { 4, addHarryData4 }, { 5, addHarryData5 } };


                                        foreach (KeyValuePair<int, string> data in harryDictionary)
                                        {
                                            // using the KeyValuePair<TKey, TValue>nclass that will represent each key-value pair within our dictionary
                                            Console.WriteLine($"The data {data.Key} you added to the Harry Potter Movie was: '{data.Value}'");

                                        }
                                        Console.WriteLine("Enter What you would love to do next. [Enter 'K' to go back to the Main Menu or 'X' to exit the APplication]");
                                            string whatToDo = Console.ReadLine();

                                            // another switch-case statement to determine what User wants to do next
                                            switch (whatToDo)
                                            {
                                                case "K":
                                                    Main();
                                                    break;
                                                case "X":
                                                    Console.WriteLine("Goodbye My Dear User");
                                                break; 
                                                
                                            }
                                        break;

                                    case "N":
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("Let's Get Back to the Main Menu of the App");
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Main();
                                        break;
                                }



                                break;
                            default:
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("You have selected Money Heist, what would you like to do to this Movie today?");
                        Console.WriteLine("Enter 'D'to add Data on the Money Heist movie");
                        Console.WriteLine();

                        Console.WriteLine("Enter 'R' to Retrieve Data on the Money Heist movie");
                        Console.WriteLine();
                        Console.WriteLine("Enter 'C' to comment potential fixes to the Money Heist movie");
                        Console.WriteLine();
                        Console.WriteLine("Enter 'Boo' to rate the Money Heist movie down");
                        Console.WriteLine();
                        Console.WriteLine("Enter 'Woo' to rate the Money Heist movie up");
                        Console.WriteLine();
                        break;


                    default:
                        break;
                }

                break;

            case "X":
                Console.WriteLine("Goodbye My Dear User");
                break;
            default:
                break;
        }



        // Taking in user's answer to my above questions
        string userAns = Console.ReadLine().ToUpper();

        // using switch-cases again in this App

        switch (userAns)
        {
            case "Woo":
                Console.WriteLine("You have just indicated that you Loved a movie, tell us what you think");
                break;

            default:
                break;
        }




    }
}