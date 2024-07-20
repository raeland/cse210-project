namespace EventPlanning
{
    public abstract class Event
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public string Time { get; private set; }
        public Address Address { get; private set; }

        public Event(string title, string description, DateTime date, string time, Address address)
        {
            Title = title;
            Description = description;
            Date = date;
            Time = time;
            Address = address;
        }

        public virtual string GetStandardDetails()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
        }

        public abstract string GetFullDetails();
        public virtual string GetShortDescription()
        {
            return $"Type: {this.GetType().Name}\nTitle: {Title}\nDate: {Date.ToShortDateString()}";
        }
    }
}