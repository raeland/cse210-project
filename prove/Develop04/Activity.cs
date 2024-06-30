using System;

namespace Mindfullness
{
    public abstract class Activity
    {
        protected int _time;
        protected string _activityName;
        protected string _activityDescription;


        public Activity(string activityName, string activityDescription, int time)
        {
            _time = time;
            _activityName = activityName;
            _activityDescription = activityDescription;
        }
        public void StartActivity() //string activityName, string activityDescription
        {
            Console.WriteLine($"Begin Your Mindfullness Journey with the {_activityName} Activity");
            Console.WriteLine($"{_activityDescription}");
            Thread.Sleep(3000);
//            DateTime currentTime = DateTime.Now;
            for (int i = 1; i <= _time; i++)
            {
                ShowPrompt(i);
            }
            EndActivity();
        }
        protected abstract void ShowPrompt(int time);
        public void EndActivity()
        {
            Console.WriteLine("Well Done! ");
            Console.WriteLine($"You completed {_time} seconds of the {_activityName} Activity.");
            Thread.Sleep(3000);
        }

        protected void ShowAnimation()
        {
            Console.Write("...Loading...");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine();
        }
    }
}
