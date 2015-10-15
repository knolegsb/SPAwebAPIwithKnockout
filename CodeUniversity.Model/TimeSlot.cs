using System;

namespace CodeUniversity.Model
{
    public class TimeSlot
    {
        public TimeSlot()
        {
            IsSessionSlot = true;
        }
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public bool IsSessionSlot { get; set; }
        public int Duration { get; set; }
    }
}