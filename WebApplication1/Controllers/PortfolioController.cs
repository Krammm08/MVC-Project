using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class PortfolioController : Controller
{
    public IActionResult Elijah()
    {
        var portfolio = new Portfolio
        {
            profileImage = "/image/Mark.png",
            firstName = "Mark Elijah",
            lastName = "Sevilla",
            dateOfBirth = new DateOnly(2005, 8, 6),
            informationImage = new List<string>
            {
                "/image/location.png",
                "/image/calendar.png",
                "/image/phone.png",
                "/image/mail.png"
            },
            information = new List<string>
            {
                 "Manila, Philippines", "August 6, 2005", "0992-902-5256", "markelijahsevilla@gmail.com"
            },
            techStack = new List<string>
            {
                "/image/c.png", "/image/java.png", "/image/html.png", "/image/css.png", "/image/javascript.png", "/image/sql.png"
            },
            socials = new Dictionary<string, string>
            {
                { "/image/facebook.png", "https://www.facebook.com/markelijah.sevilla/" },
                { "/image/instagram.png", "https://www.instagram.com/krammm_08/" },
                { "/image/linkedin.png", "https://www.linkedin.com/in/mark-elijah-sevilla-3b6063348/?isSelfProfile=true" },
                { "/image/github.png", "https://github.com/Krammm08" },
                { "/image/discord.png", "https://discord.com/users/748107424149536801" }
            },
            aboutMe = "Hi, I'm Mark Sevilla, a Computer Science student at the Polytechnic University of the Philippines. I'm  deeply passionate about programming and constantly exploring new facets of technology. As an avid gamer, I dont just play, I analyze. I'm dedicated to learning how to extract and interpret game data, using statistical analysis to uncover insights, solve complex problems, and determing the most efficient outcomes.",
            education = new List<string>
            {
                "Polytechnic University of the Philippines - Senior High School (2022 - 2024)",
                "Polytechnic University of the Philippines - Bachelor of Science in Computer Science (2024 - Present)"
            },
            achievements = new List<string>
            {
                "NCII in Computer Systems Servicing", "NCIII in Computer Programming (Java)", "Participated in the SKAPTALA 2026 event"
            },
            projects = new Dictionary<string, string>
            {
                {"Pet-Clinic-System", "https://github.com/Krammm08/Pet-Clinic-System.git"},
                {"VeemahPay", "https://www.veemahpay.app/"},
                {"Applyr", "https://github.com/Krammm08/applyr"},
                {"Eigen-Stuff-Calculator", "https://github.com/Krammm08/eigen-stuff-calculator"}

            },
            projectDescription = new List<string>
            {
                " - A clinic management system designed to streamline pet records, veterinary appointments, and patient care.",
                " - A modern digital banking platform designed for seamless financial management and secure transactions.",
                " - An end-to-end recruitment portal with a multi-step job application and candidate review queue.",
                " - An interactive 3D matrix transformation and eigenvalue visualizer for linear algebra."
            },

            hobbies = new List<string>
            {
                "Playing video games", "Watching movies", "Running", "Listening to music"
            }
        };
        return View(portfolio);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
