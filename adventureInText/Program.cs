using System;

namespace adventureInText
{
    class Program
    {
        static void Main(string[] args)
        {
            gameIntro();
        }

        public static void gameIntro()
        {
            Console.WriteLine("How's about we play a game!");
            Console.WriteLine("Hit 'Enter' to start.");
            Console.ReadLine();
            Console.Clear();
            act1();
        }

        public static void act1()
        {
            string userChoice;
            Console.WriteLine("You wake up on a bench beside a city building and find you're in a time that isn't your own. " +
                              "You see a disheveled man lying 10 feet away, what appears to be an android walking past you, and a news terminal on the street corner.");
            Console.WriteLine("What's your next move?");
            Console.WriteLine("1. You have to talk to another human being! Wake up the man near you and see what he knows.");
            Console.WriteLine("2. Back in your time, robots were the way of the future. You might as well talk to the android while you're here.");
            Console.WriteLine("3. You always have the itch to scroll through your feed upon waking and today's no different! Go to the news terminal and have at it.");
            Console.Write("Enter a number: ");
            userChoice = Console.ReadLine();
            Console.Clear();

            switch (userChoice)
            {
                case "1":
                    {
                        Console.WriteLine("You get up and walk toward the man near you where you hear wheezing that trails into soft indiscernable rambling.");
                        Console.WriteLine("You say, 'Excuse me, Mister!' and hear him make a loud grunt. Then the man turns onto his side to face the building wall.");
                        Console.WriteLine("You decide to reach down and shake the man's shoulder to stir him awake but the soft rambling turns into loud profanity.");
                        Console.WriteLine("As you begin to pull your arm back in fear, the man turns over and stabs you in the chest with a knife!");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        youLost();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("You rise and catch up to the android who turns to you with a face eerily similar to a human with boxlike features.");
                        Console.WriteLine("You nervously blurt out, 'This is gonna sound strange but what year is it?!' The android replies, 'The year 3000.'");
                        Console.WriteLine("The android's eyes glow bright blue and then it says, 'My scan shows you live in this building, floor 42, unit 5.'");
                        Console.WriteLine("Well, I guess you're going home! You walk toward the entrance.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        act2();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("You pull yourself up and pat any dust off. Of all the times you've woken up on the street, this one takes the cake.");
                        Console.WriteLine("You shuffle down to the street corner and examine the news terminal. It shows a news article dated in the year 3000!");
                        Console.WriteLine("You see a finger scanner and give it a whirl. The terminal flashes and says you live in the building you woke up by.");
                        Console.WriteLine("Home never sounded sweeter! You walk toward the entrance.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        act2();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("The command you entered is invalid.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        act1();
                        break;
                    }
            }
        }

        public static void act2()
        {
            Random rand = new Random();
            string[] secEvents = { "You reach the entrance and the doorman says, 'Mr. Allagash is looking for you and he doesn't look happy.'",
                                   "Right before the entrance, you cross paths with a woman who frantically says, 'You're back?! I told you to leave and " +
                                   "NEVER come back because of what they'll do to you!' She then storms off in a hurry.",
                                   "As you're about to walk through the entrance, you hear a loud commotion inside. It doesn't sound good."};
            int randNum = rand.Next(3);
            string eventText = secEvents[randNum];
            string secChoice;
            Console.WriteLine(eventText);
            Console.WriteLine("Do you walk through the entrance anyway?");
            Console.WriteLine("Please enter Yes or No: ");
            secChoice = Console.ReadLine().ToLower();
            if (secChoice == "yes" || secChoice == "y")
            {
                Console.WriteLine("You walk through the entrance to find a gang of android bandits who all pull out laser guns and vaporize you!");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                youLost();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.Clear();
                act3();
            }
            else
            {
                Console.WriteLine("The command you entered is invalid.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                Console.Clear();
                act2();
            }
        }

        public static void act3()
        {
            
            string tempYear;
            DateTime userYear = new DateTime();            
            var currentYear = DateTime.Now;
            var thisYear = new DateTime(currentYear.Year, currentYear.Month, currentYear.Day, 0, 0, 0);
            Console.WriteLine("You decide to walk past the entrance with a swiftness and are firmly in the territory of wanting this nightmare to end now.");
            Console.WriteLine("Right on queue, a blinding light materializes before you with a near-deafening bang and your brother appears!");
            Console.WriteLine("He says, 'I lost you last night! That New Year's Eve party got crazy and ended with a trip to an alternate universe.'");
            Console.WriteLine("You thank him for finding you and then he casually says, 'Remind me which year you're from again, I've been hopping around a lot.'");
            Console.WriteLine("Enter the year you came from: ");
            tempYear = Console.ReadLine();
            tempYear = $"{tempYear},12,31";
            userYear = DateTime.Parse(tempYear);
            userYear = userYear.Add(new TimeSpan(23, 59, 59));
            int result = DateTime.Compare(userYear, thisYear);

            while (result < 0)
            {
                Console.WriteLine("Your brother says, 'I could've swore it was later than that. Pick a year after that.'");
                Console.WriteLine("Enter the year you came from: ");
                tempYear = Console.ReadLine();
                tempYear = $"{tempYear},12,31";
                userYear = DateTime.Parse(tempYear);
                int nextResult = DateTime.Compare(userYear, thisYear);
                result = nextResult;
            }
            Console.WriteLine("Oh that's right! Your brother puts his arm around you and tells you to close your eyes so you do it.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            youWon();
        }

        public static void youLost()
        {
            Console.WriteLine("You woke up in a future far beyond your present and lasted all of 15 minutes.");
            Console.WriteLine("Death isn't quite like you pictured it but it can't get any worse from here, right?.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            gameIntro();
        }

        public static void youWon()
        {
            Console.WriteLine("After a cacophonous churning of sounds, you open your eyes and find yourself back in your sunlit house.");
            Console.WriteLine("Your brother says, 'Looks like this is your stop! Sorry for the mix-up but I'm glad you're back home.'");
            Console.WriteLine("You feel ten times better being in more familiar surroundings and tell him, 'That's okay; it was quite an adventure!'");
            Console.WriteLine("You don't think any New Year's Eve celebration will ever top this one and are glad it's all over now.");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            Console.Clear();
            gameIntro();
        }
    }
}
