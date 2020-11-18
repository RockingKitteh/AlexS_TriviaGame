using System;
/*
* Trivia App by Alex Sperry
* Intro to Programming, 9/23/2020
*/

namespace AlexSperry_TriviaGame
{
    class Game
    {
        string gameName = "Trivia Game by Alex";
        string Name = "Anonymous";
        
        public Game()
        {
            Console.Title = gameName;
            Console.WriteLine("Welcome to the " + gameName + "!");
            Console.WriteLine("Enter your name.");
            Name = Console.ReadLine();
            Console.WriteLine("Welcome " + Name + "!");
            Console.WriteLine("Press any key to start.");
            Console.ReadKey();
            Play();
        }
        
        private void Play()
        {
            Console.WriteLine("Question 1: A Cat is an animal. True or False?");
            Console.ReadLine();
            Console.WriteLine("The correct answer is TRUE");
            Console.ReadKey();
            Console.WriteLine("Question 2: Mtn. Dew is water. True or False?");
            Console.ReadLine();
            Console.WriteLine("The correct andswer is FALSE");
            Console.ReadKey();
            TriviaItem item1 = new TriviaItem();
            TriviaItem item2 = new TriviaItem();
        }
        
    }
    
    class Player
    {
        public string Name = "Anonymous";
        int score = 0;
    }
    
    class TriviaItem
    {
        public string question = "";
        public string answer = "";
    }
    class Program
    {
        static void Main()
        {
            new Game();
        }
    }
}
