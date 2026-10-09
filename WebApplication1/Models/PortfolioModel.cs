namespace WebApplication1.Models
{
    public class Project
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Goal { get; set; } = string.Empty;
        public List<string> Tags { get; set; } = new();
        public List<string> Details { get; set; } = new();
        public string Repo { get; set; } = string.Empty;
        public string ButtonText { get; set; } = string.Empty;
        public string ButtonClass { get; set; } = string.Empty;
    }

    public class ExperienceItem
    {
        public string Role { get; set; } = string.Empty;
        public string Organization { get; set; } = string.Empty;
        public string Period { get; set; } = string.Empty;
    }

    public class CertificationItem
    {
        public string Name { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string MonthYear { get; set; } = string.Empty;

    }
    public class ToolItem
    {
        public string Name { get; set; } = string.Empty;
        public string IconClass { get; set; } = string.Empty;
        public string ToolClass { get; set; } = string.Empty;
    }

    public class InterestCard
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class PortfolioModel
    {
        public string Name { get; set; } = "Reine Arabelle";
        public string Title { get; set; } = "Aspiring Data Analyst | UI/UX & Graphic Designer";
        public string Email { get; set; } = "monterey.reineal@gmail.com";

        public List<Project> Projects { get; set; } = new();
        public List<ExperienceItem> Experiences { get; set; } = new();
        public List<CertificationItem> Certifications { get; set; } = new();

        public List<ToolItem> TechStack { get; set; } = new();
        public List<ToolItem> DesignStack { get; set; } = new();
        public List<InterestCard> Interests { get; set; } = new();
    }
}