using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new PortfolioModel
            {
                Name = "Reine Arabelle",
                Title = "Aspiring Data Analyst | UI/UX & Graphic Designer",
                Email = "monterey.reineal@gmail.com",

                // RECENT PROJECTS
                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "Panatiko",
                        Description = "A gritty, Filipino-inspired 2D survival horror game exploring fanaticism and exploitation. You play as Alex, a young woman whose mother has fallen victim to a mysterious and powerful cult - led by Arthur Valdez - operating out of an abandoned mall. These false promises are what slowly strips the townsfolk of their freedom and sanity.",
                        Goal = "To infiltrate a cult operating in an abandoned mall using stealth, hacking, and radio guidance to save your family.",
                        Tags = new List<string> { "Game Dev", "2D Survival Horror" },
                        SubTags = new List<string> { "Aseprite", "Godot" },
                        Details = new List<string>
                        {
                            "Game Jam Duration: Sept. 1, 2026 - Oct. 5, 2026",
                            "Status: Successfully Submitted (version2 in progress)",
                            "Event: Filipino Horror Game Jam 2026",
                            "Role: Object Assets Artist (Aseprite)"
                        },
                        Repo = "https://itch.io/jam/filipino-horror-game-jam-2026/rate/5101029",
                        ButtonText = "View on Itch.io",
                        ButtonClass = "btn-danger"
                    }
                },

                // EXPERIENCE 
                Experiences = new List<ExperienceItem>
                {
                    new ExperienceItem
                    {
                        Role = "Executive Secretary",
                        Organization = "PUP Association of Students for Computer Intelligence Integration (PUP ASCII)",
                        Period = "Sept 2026 - Present"
                    },
                    new ExperienceItem
                    {
                        Role = "Student",
                        Organization = "GCI World by Matsuo-Iwasawa Lab U-Tokyo",
                        Period = "Sept 2026 - Present"
                    },
                    new ExperienceItem
                    {
                        Role = "Machine Learning Intern",
                        Organization = "FlyRank AI",
                        Period = "June 2026 - Present"
                    }
                },

                // SKILLS & TOOLS
                TechStack = new List<ToolItem>
                {
                    new ToolItem { Name = "HTML", IconClass = "bi-filetype-html", ToolClass = "badge-custom" },
                    new ToolItem { Name = "CSS", IconClass = "bi-filetype-css", ToolClass = "badge-custom" },
                    new ToolItem { Name = "JavaScript", IconClass = "bi-filetype-js", ToolClass = "badge-custom" },
                    new ToolItem { Name = "SQL", IconClass = "bi-database", ToolClass = "badge-custom" },
                    new ToolItem { Name = "Git / GitHub", IconClass = "bi-git", ToolClass = "badge-custom" }
                },

                DesignStack = new List<ToolItem>
                {
                    new ToolItem { Name = "Figma", IconClass = "bi-vector-pen", ToolClass = "badge-custom" },
                    new ToolItem { Name = "Canva", IconClass = "bi-aspect-ratio", ToolClass = "badge-custom" },
                    new ToolItem { Name = "Adobe Illustrator", IconClass = "bi-brush", ToolClass = "badge-custom" },
                    new ToolItem { Name = "UI/UX Design", IconClass = "bi-layout-wpt", ToolClass = "badge-custom" },
                    new ToolItem { Name = "Game Design", IconClass = "bi-controller", ToolClass = "badge-custom" }
                },

                // INTERESTS
                Interests = new List<InterestCard>
                {
                    new InterestCard
                    {
                        Title = "UI/UX Design & Prototyping",
                        Description = "User-centered wireframing, interactive Figma components, and intuitive web application layouts.",
                        Tag = "UI/UX"
                    },
                    new InterestCard
                    {
                        Title = "Graphic & Publication Design",
                        Description = "Event/Academic posters, branding visual identity, vector artwork, and digital assets.",
                        Tag = "Graphic Design"
                    },
                    new InterestCard
                    {
                        Title = "Media",
                        Description = "Reading books, watching films, curating my music playlists.",
                        Tag = "Hobbies"
                    },
                    new InterestCard
                    {
                        Title = "Gaming",
                        Description = "Playing Stardew Valley, Detective Database, and narrative titles like Until Then.",
                        Tag = "Gaming"
                    }
                }
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}