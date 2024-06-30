namespace EternalQuest
{
    class CheckListG : Goals
    {
        public int _targetCount { get; set; }
        public int _currentCount { get; set; }
        public int _bonusPoints { get; set; }
        public CheckListG(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
        {
            _targetCount = targetCount;
            _currentCount = 0;
            _bonusPoints = bonusPoints;
        }
        public override void RecordEvent()
        {
            if (_currentCount < _targetCount)
            {
                _currentCount++;
            }
        }
        public override bool IsComplete()
        {
            return _currentCount >= _targetCount;
        }
        public override string GetStatus()
        {
            return $"[{_currentCount}/{_targetCount}] " + _name + _points; 
        }
    }
}