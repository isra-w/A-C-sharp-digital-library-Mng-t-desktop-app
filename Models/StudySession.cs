namespace d.labdemo.Models
{
    public class StudySession
    {
        public int StudySessionId { get; set; }
        public int UserId { get; set; }
        public int DurationSeconds { get; set; }
        public DateTime StartedAt { get; set; }
    }
}