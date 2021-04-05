using System;
using System.Collections.Generic;
using System.Threading;

namespace rps
{
    class Program
    {
        static void Main(string[] args)
        {
            // string rock = "Rock";
            // string paper = "Paper";
            // string scissors = "Scissors";
            int userScore = 0;
            int compScore = 0;
            var random = new Random();

            List<string> compChoice = new List<string>(){
          "Rock",
          "Paper",
          "Scissors",
      };
            // Console.WriteLine(compChoice[index]);
            bool running = true;
                string intro = @"
 
 _______  _______  _______  _                                           
(  ____ )(  ___  )(  ____ \| \    /\                                    
| (    )|| (   ) || (    \/|  \  / /                                    
| (____)|| |   | || |      |  (_/ /                                     
|     __)| |   | || |      |   _ (                                      
| (\ (   | |   | || |      |  ( \ \                                     
| ) \ \__| (___) || (____/\|  /  \ \                                    
|/   \__/(_______)(_______/|_/    \/                                    
                                                                        
 _______  _______  _______  _______  _______                            
(  ____ )(  ___  )(  ____ )(  ____ \(  ____ )                           
| (    )|| (   ) || (    )|| (    \/| (    )|                           
| (____)|| (___) || (____)|| (__    | (____)|                           
|  _____)|  ___  ||  _____)|  __)   |     __)                           
| (      | (   ) || (      | (      | (\ (                              
| )      | )   ( || )      | (____/\| ) \ \__                           
|/       |/     \||/       (_______/|/   \__/                           
                                                                        
 _______  _______ _________ _______  _______  _______  _______  _______ 
(  ____ \(  ____ \\__   __/(  ____ \(  ____ \(  ___  )(  ____ )(  ____ \
| (    \/| (    \/   ) (   | (    \/| (    \/| (   ) || (    )|| (    \/
| (_____ | |         | |   | (_____ | (_____ | |   | || (____)|| (_____ 
(_____  )| |         | |   (_____  )(_____  )| |   | ||     __)(_____  )
      ) || |         | |         ) |      ) || |   | || (\ (         ) |
/\____) || (____/\___) (___/\____) |/\____) || (___) || ) \ \__/\____) |
\_______)(_______/\_______/\_______)\_______)(_______)|/   \__/\_______)
                                                                        
";
                System.Console.WriteLine(intro);
            while (running)
            {
                int index = random.Next(compChoice.Count);
                string compAct = compChoice[index];
                Console.WriteLine(@"What is your choice? 
            (R)ock / (P)aper / (S)cissors");
                ConsoleKeyInfo userInput = System.Console.ReadKey();
                if (userInput.Key == ConsoleKey.R && compAct == "Rock")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("It's a tie");
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);

                }
                else if (userInput.Key == ConsoleKey.R && compAct == "Paper")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("You lost");
                    compScore++;
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);
                }
                else if (userInput.Key == ConsoleKey.R && compAct == "Scissors")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("You won!");
                    // running = false;
                    userScore++;
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);
                }
                else if (userInput.Key == ConsoleKey.P && compAct == "Paper")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("It's a tie");
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);
                }
                else if (userInput.Key == ConsoleKey.P && compAct == "Rock")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("You lost");
                    compScore++;
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);
                }
                else if (userInput.Key == ConsoleKey.R && compAct == "Scissors")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("You won!");
                    userScore++;
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);
                }
                else if (userInput.Key == ConsoleKey.S && compAct == "Scissors")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("It's a tie");
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);
                }
                else if (userInput.Key == ConsoleKey.S && compAct == "Rock")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("You lost");
                    compScore++;
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);
                }
                else if (userInput.Key == ConsoleKey.S && compAct == "Paper")
                {
                    Console.WriteLine("Computer chose " + compChoice[index]);
                    System.Console.WriteLine("You won!");
                    userScore++;
                    System.Console.WriteLine("You- " + userScore + " Computer- " + compScore);
                }
                else
                {
                    System.Console.WriteLine("invalid input");
                }


                if (userScore == 10)
                {
                    System.Console.WriteLine("You reached 10 wins, you're a Champ!");
                    Thread.Sleep(2000);
                    running = false;
                }
                else if (compScore == 10)
                {
                    System.Console.WriteLine("The computer really beat you? You suck!");
                    Thread.Sleep(2000);
                    running = false;
                }
            }
        }
    }
}
