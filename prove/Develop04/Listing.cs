using System;

namespace Mindfullness
{
    public class Listing : Activity
    {
        private List<string> _listPrompts;
        private List<string> _usersList;
        public Listing(int time) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ", time)
        {
            _listPrompts = new List<string>
            {
                "List people who make you smile",
                "List books that make you happy",
                "List times you helped another feel loved"
            };
            _usersList = new List<string>();
        }
       public void StartActivity()
        {}
        protected override void ShowPrompt(int time)
        {
            Console.WriteLine("Think of a time when you were laughing.");
            ShowAnimation();
        }
        public List<string> ListItems()
        {
            List<string> items = new List<string>();
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine("One Item Per Line");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "done")
                    break;
                items.Add(input);
            }
            return items;
        }
    }
}

// How long, in seconds, would you like your session to last?
// Get ready... (spinning dash)
// ---When have you felt the Holy Ghost this month? ---
// You may begin in : (counts down at each interval)
// User types list (spinning dash)
// You listed [int] items! (spinning dash)

// Well DONE!!
// (spinning dash)
// You've completed another [int] seconds of the Listening Activity.

// Activity = new Activity();
// Console.WriteLine("Welcome to Develop04 World!");
// Breathe = new Breathe();
// Lists = new Lists();
// Reflect = new Reflect();
//how to make the computer to wait for 1 second (1000 milliseconds):

                    // Console.WriteLine("Going to sleep for a second...");
                    // Thread.Sleep(1000);
                    // Console.WriteLine("I'm back!!");


//To display an animation, such as the spinner or the countdown timer, 
//you need to have the computer pause for a period of time, and then 
//replace the previous character with a new one. This can be done by 
//writing the backspace character "\b" and which works like pushing the left arrow. 
//Then, you can write a new character over the top of it.

//Because the backspace character works like pressing the left arrow, 
//instead of a backspace, it does not delete the character on the screen. 
//With this in mind, it is common to write "\b \b" which moves left, 
//writes a blank space over the previous character and then moves left again 
//so it is ready for your new character.

//The following example shows how to overwrite a character after half a second:
                        // Console.Write("+");

                        // Thread.Sleep(500);

                        // Console.Write("\b \b"); // Erase the + character
                        // Console.Write("-"); // Replace it with the - character


// The C# language has a powerful Date and Time library. 
//You might find it useful to get the current time, add a 
//number of seconds to it, and then check if the current time 
//is less than the new time.

// This can be accomplished with the DateTime class. 
//An object with the current time can be obtained withe DateTime.Now 
//Then, it has methods such as .AddSeconds(numberOfSeconds), 
//and it works with the less than < operator as you would expect.

// The following code snippet shows an example:
                        // DateTime startTime = DateTime.Now;
                        // DateTime futureTime = startTime.AddSeconds(5);

                        // Thread.Sleep(3000);

                        // DateTime currentTime = DateTime.Now;
                        // if (currentTime < futureTime)
                        // {
                        //     Console.WriteLine("We have not arrived at our future time yet...")
                        // }