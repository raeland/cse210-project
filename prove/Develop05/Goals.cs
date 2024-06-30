namespace EternalQuest
{
    abstract class Goals
    {
        public string _name { get; set; }
        public string _description { get; set; }
        public int _points { get; set; }

        public Goals(string name, string description, int points)
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public abstract string GetStatus();
    }
}