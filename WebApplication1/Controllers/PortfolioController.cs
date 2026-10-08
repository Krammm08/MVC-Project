using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class PortfolioController : Controller
{
    public IActionResult MyPortfolio()
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
            socialsImage = new List<string>
            {
                "/image/facebook.png",
                "/image/instagram.png",
                "/image/linkedin.png",
                "/image/github.png",
                "/image/discord.png"
            },
            socials = new List<string>
            {
                "https://www.facebook.com/markelijah.sevilla/",
                "https://www.instagram.com/krammm_08/",
                "https://www.linkedin.com/in/mark-elijah-sevilla-3b6063348/?isSelfProfile=true",
                "https://github.com/Krammm08",
                "https://discord.com/users/748107424149536801"
            },
            aboutMe = "Hi, I'm Mark Sevilla, a Computer Science student at the Polytechnic University of the Philippines. I'm  deeply passionate about programming and constantly exploring new facets of technology. As an avid gamer, I dont just play, I analyze. I'm dedicated to learning how to extract and interpret game data, using statistical analysis to uncover insights, solve complex problems, and determing the most efficient outcomes.",
            education = new List<string>
            {
                "Aurora A. Quezon Elementary School - Elementary (2012 - 2016)",
                "Justo Lukban Elementary School - Elementary (2016 - 2018)",
                "Manuel G. Araullo High School - Junior High School (2018 - 2022)",
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
            techStack = new List<string>
            {
                "/image/c.png", "/image/java.png", "/image/html.png", "/image/css.png", "/image/javascript.png", "/image/sql.png"
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
