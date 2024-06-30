namespace EternalQuest
{
    class EternalG : Goals
    {
        public EternalG(string name, string description, int points) 
        : base(name, description, points) {}
        public override void RecordEvent()
        {
            //never complete, eternity is a LONG time...
        }
        public override bool IsComplete()
        {
            return false;
        }
        public override string GetStatus()
        {
            return "[ ] " + _name + _points;
        }

    }
}