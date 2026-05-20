namespace d.labdemo.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public int UserId { get; set; }
        public string? Bio { get; set; }
        public string? AvatarPath { get; set; }
    }
}