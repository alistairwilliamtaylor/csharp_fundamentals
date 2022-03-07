﻿using System.Runtime.ConstrainedExecution;
// See https://aka.ms/new-console-template for more information

// COUNT MULTIPLES OF 3
// var count = 0;
// for (var i = 1; i < 101; i++)
// {
//     if (i % 3 == 0)
//     {
//         count++;
//     };
// };
// System.Console.WriteLine(count);

// SUM NUMBERS UNTIL THE USER HAS HAD ENOUGH
// int runningTotal = 0;
// while (true)
// {
//     System.Console.WriteLine("Enter a number or enter 'ok' to exit");
//     var userInput = Console.ReadLine();
//     if (userInput == "ok")
//     {
//         System.Console.WriteLine(runningTotal);
//         break;
//     }
//     else
//     {
//         runningTotal = runningTotal + int.Parse(userInput);
//     };
// };

// FACTORIAL USING FOR LOOP
// System.Console.WriteLine("Enter a number, and I'll tell you its factorial");
// var numberProvided = int.Parse(Console.ReadLine());
// var total = 1;
// for (var i = numberProvided; i > 0; i--)
// {
//     total = total * i;
// };
// System.Console.WriteLine(string.Format("The factorial of {0} is {1}", numberProvided, total));

// GUESS THE NUMBER WITH INPUT VALIDATION AND ERROR HANDLING
// var random = new Random();
// var secretNumber = random.Next(1,10);
// const int guessesAllowed = 4;
// System.Console.WriteLine("Can you guess the secret number between 1 and 10?");
// for (var i = 1; i <= guessesAllowed; i++)
// {
//     bool guessIsAnInt = false;
//     var userGuess = 0; // this doesn't work if I do int userGuess;
//     while(true)
//     {
//         var userInput = Console.ReadLine();
//         guessIsAnInt = int.TryParse((userInput), out userGuess);
//         if (guessIsAnInt && userGuess >= 1 && userGuess <= 10)
//         {
//             break;
//         }
//         else
//         {
//             System.Console.WriteLine("Are you kidding me?!?! That's not even a valid guess! Stop screwing around and guess a number between 1 and 10!!!");
//         }
//     };
//     if (userGuess == secretNumber)
//     {
//         System.Console.WriteLine(string.Format("You are correct! The secret number was {0}!", secretNumber));
//         break;
//     }
//     else if (i < guessesAllowed)
//     {
//         if (userGuess < secretNumber)
//         {
//             System.Console.WriteLine(string.Format("You must guess HIGHER! You have {0} guesses left!", guessesAllowed - i));
//         }
//         else 
//         {
//             System.Console.WriteLine(string.Format("You must guess LOWER! You have {0} guesses left!", guessesAllowed - i));
//         }
//     }
//     else {
//         System.Console.WriteLine("You lose! You lose! You lose!");
//     };
// };

System.Console.WriteLine("Enter five integers separated by commas, e.g. 5,9,3,1,6");
var userInput = Console.ReadLine();
bool hasNoContent = string.IsNullOrWhiteSpace(userInput);
if (!hasNoContent)
{
    var listOfEntries = userInput.Split(',');
    var largestEntry = 0;
    foreach (var entry in listOfEntries)
    {
        var userEntry = 0;
        var isValidInt = int.TryParse(entry, out userEntry);
        if (!isValidInt)
        {
            System.Console.WriteLine(string.Format("{0} was not a valid integer", entry));
        }
        if (userEntry > largestEntry)
        {
            largestEntry = userEntry;
        }
    }
    System.Console.WriteLine(string.Format("The largest number in your list was {0}", largestEntry));
}
else {
    System.Console.WriteLine("No input detected");
}