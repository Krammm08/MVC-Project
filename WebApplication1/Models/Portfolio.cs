namespace WebApplication1.Models;

public class Portfolio
{
    public string profileImage { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateOnly dateOfBirth { get; set; }
    public List<string> informationImage { get; set; } = new List<string>();
    public List<string> information { get; set; } = new List<string>();
    public List<string> socialsImage { get; set; } = new List<string>();
    public List<string> socials { get; set; } = new List<string>();
    public string aboutMe { get; set; }
    public List<string> education { get; set; } = new List<string>();
    public List<string> achievements { get; set; } = new List<string>();
    public Dictionary<string, string> projects { get; set; } = new Dictionary<string, string>();
    public List<string> techStack { get; set; } = new List<string>();
    public List<string> hobbies { get; set; } = new List<string>();

}