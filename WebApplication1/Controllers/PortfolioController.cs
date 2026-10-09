using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;
    public class PortfolioController : Controller
    {
        public IActionResult ReineArabelle()
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
                    },
                    new Project { Title = "Arbitrary Image Scoring", Description = "Design and Analysis of Algorithms (May 2026)" },
                    new Project { Title = "Scholarship Form", Description = "Information Management (June 2026)", Repo = ""},
                    new Project { Title = "Four Fundamental Spaces Finder", Description = "Linear Algebra (Jan 2026)" },
                    new Project { Title = "Pila Room Reserb", Description = "OOP (Jan 2026)" },
                },

                // EXPERIENCE 
                Experiences = new List<ExperienceItem>
                {
                    new ExperienceItem { Role = "Executive Secretary", Organization = "PUP Association of Students for Computer Intelligence Integration (PUP ASCII)", Period = "Sept 2026 - Present"},
                    new ExperienceItem { Role = "Student", Organization = "GCI World by Matsuo-Iwasawa Lab-U Tokyo", Period = "Sept 2026 - Present"},
                    new ExperienceItem { Role = "Machine Learning Intern (Remote)", Organization = "FlyRank AI", Period = "June 2026 - Present"},
                },

                Certifications = new List<CertificationItem>
                {
                    new CertificationItem { Name = "Data Fundamentals", Issuer = "IBM SkillsBuild", MonthYear = "Aug 2026" },
                    new CertificationItem { Name = "Web & Mobile Designer: UI/UX, Figma, +more", Issuer = "UDEMY", MonthYear = "Sep 2025" },
                    new CertificationItem { Name = "Introduction to Generative AI Learning Path", Issuer = "Coursera", MonthYear = "Dec 2024" },
                },

                // SKILLS & TOOLS
                TechStack = new List<ToolItem>
                {
                    new ToolItem { Name = "HTML" },
                    new ToolItem { Name = "CSS" },
                    new ToolItem { Name = "JavaScript" },
                    new ToolItem { Name = "SQL" },
                    new ToolItem { Name = "Git / GitHub" }
                },

                DesignStack = new List<ToolItem>
                {
                    new ToolItem { Name = "Figma" },
                    new ToolItem { Name = "Canva" },
                    new ToolItem { Name = "Adobe Illustrator" },
                    new ToolItem { Name = "Aseprite" },
                    new ToolItem { Name = "Clip Studio Art" }
                },

                // INTERESTS
                Interests = new List<InterestCard>
                {
                    new InterestCard { Title = "UI/UX Design & Prototyping", Description = "User-centered wireframing, interactive Figma components, and intuitive web application layouts."},
                    new InterestCard { Title = "Graphic & Publication Design", Description = "Event/academic posters, branding visual identity, digital assets."},
                    new InterestCard { Title = "Media", Description = "Reading books, watching films, curating my music playlists."},
                    new InterestCard { Title = "Light Gaming", Description = "Playing Stardew Valley, Detective Database, and narrative titles like Until Then."},
                }
            };

            return View("~/Views/Portfolio/ReineArabelle.cshtml", model);
        }
    }

