using System.ComponentModel.DataAnnotations.Schema;

namespace EternalQuest
{
    class SimpleG : Goals
    {
        private bool complete;
        public SimpleG(string name, string description, int points) : base(name, description, points)
        {
            complete = false;
        }
        public override void RecordEvent()
        {
            complete = true;
        }
        public override bool IsComplete()
        {
            return complete;
        }
        public override string GetStatus()
        {
            return complete ? "[X] " + _name + _points : "[ ] ";
        }
    }
}