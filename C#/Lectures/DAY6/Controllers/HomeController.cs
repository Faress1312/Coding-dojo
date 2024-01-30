using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DAY6.Models;

namespace DAY6.Controllers;

public class HomeController : Controller
{
    
public static Game[] Games = new[]{
        new Game {Title = "Elden Ring", Price=69.99, Genre= "Action RPG", Rating="M", Platform = "PC"},
        new Game {Title="League of Legends", Price=0.00, Genre="MOBA", Rating="T", Platform="PC"},
        new Game {Title="World of Warcraft", Price=49.99, Genre="MMORPG", Rating="T", Platform="PC"},
        new Game {Title="Elder Scrolls Online", Price=19.99, Genre="Action RPG", Rating="M", Platform="PC"},
        new Game {Title="Smite", Price=0.00, Genre="MOBA", Rating="T", Platform="All"},
        new Game {Title="Overwatch", Price=49.00, Genre="First-person Shooter", Rating="T", Platform="PC"},
        new Game {Title="Scarlet Nexus", Price=69.99, Genre="Action JRPG", Rating="T", Platform="All"},
        new Game {Title="Wonderlands", Price=69.99, Genre="RPG FPS", Rating="M", Platform="All"},
        new Game {Title="Rocket League", Price=19.99, Genre="Sports", Rating="E", Platform="All"},
        new Game {Title="StarCraft", Price=29.99, Genre="RTS", Rating="T", Platform="PC"},
        new Game {Title="God of War", Price=39.99, Genre="Action-adventure ", Rating="M", Platform="PC"},
        new Game {Title="Doki Doki Literature Club Plus!", Price=15.00, Genre="Casual", Rating="E", Platform="PC"},
        new Game {Title="Red Dead Redemption", Price=49.99, Genre="Action adventure", Rating="M", Platform="All"},
        new Game {Title = "FIFA 23", Price = 199.99, Genre ="Sports", Rating = "A", Platform = "All"},
        new Game {Title = "Call Of Duty", Price = 299.99, Genre  = "Action", Rating = "A", Platform = "PC"},
        new Game {Title = "PES", Price = 129.99, Genre  = "Sports", Rating = "A", Platform = "All"},
        new Game {Title = "Battlefield", Price = 59.99, Genre = "MOBA", Rating = "B"},
        new Game {Title="My Little Pony A Maretime Bay Adventure", Price=39.99, Genre="Adventure", Rating="E",Platform="All"},
        new Game {Title="Fallout New Vegas", Price=15.00, Genre="Open World RPG", Rating="M", Platform="PC"},
        new Game {Title="BattalField", Price=59.99, Genre="MOBA", Rating="B"},
        new Game {Title = "Cyberpunk 2077", Price = 49.99, Genre = "Action RPG", Rating = "M", Platform = "All"},
        new Game {Title = "Assassin's Creed Valhalla", Price = 59.99, Genre = "Action RPG", Rating = "M", Platform = "All"},
        new Game {Title = "Fortnite", Price = 0.00, Genre = "Battle Royale", Rating = "T", Platform = "All"},
        new Game {Title = "Minecraft", Price = 29.99, Genre = "Sandbox", Rating = "E10+", Platform = "All"},
        new Game {Title = "The Legend of Zelda: Breath of the Wild", Price = 59.99, Genre = "Action-adventure", Rating = "E10+", Platform = "Nintendo Switch"},
        new Game {Title = "Halo Infinite", Price = 59.99, Genre = "First-person Shooter", Rating = "T", Platform = "Xbox"},
        new Game {Title = "Among Us", Price = 4.99, Genre = "Party Game", Rating = "T", Platform = "All"},
        new Game {Title = "Apex Legends", Price = 0.00, Genre = "Battle Royale", Rating = "T", Platform = "All"},
        new Game {Title = "The Witcher 3: Wild Hunt", Price = 39.99, Genre = "Action RPG", Rating = "M", Platform = "All"},
        new Game {Title = "Persona 5", Price = 49.99, Genre = "JRPG", Rating = "M", Platform = "PlayStation"},
        new Game {Title = "Dark Souls III", Price = 39.99, Genre = "Action RPG", Rating = "M", Platform = "All"}
    };

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        /*
        All Queries esults will be displayed in the Index view 
        to transfer data we will use ViewBag
        */
        //- Display all Games : GET ALL
        //1 All games has list<Game>
        List<Game> AllGamesList = Games.ToList();
        ViewBag.AllGames = AllGamesList;

        //2 all games as IEnumerable<Game>
        IEnumerable<Game> AllGamesIEnumerable = Games;
        ViewBag.AllGamesIEnumerable = AllGamesIEnumerable;

        //?2 All PC Games
        List<Game> AllPCGames = Games.Where(g => g.Platform == "PC").ToList();
        ViewBag.AllPCGames = AllPCGames;

        //? All free games
        List<Game> AllFreeGames = Games.Where(g => g.Price == 0.00).ToList();
        ViewBag.AllFreeGames = AllFreeGames;
        //?4 First 3 games 
        List<Game> First3Games = Games.Take(3).ToList();
        ViewBag.First3Games = First3Games;
        //?  First 3 games that can be played in all platforms
        List<Game> First3GamesAllPlatforms = Games.Where(g => g.Platform == "All").Take(3).ToList();
        ViewBag.First3GamesAllPlatforms = First3GamesAllPlatforms;
        //?-6 All Games Ordered by Title
        List<Game> AllGamesOrderedByTitle = Games.OrderBy(g => g.Title).ToList();
        ViewBag.AllGamesOrderedByTitle = AllGamesOrderedByTitle;
        List<Game> AllGamesOrderedByDESCTitle = Games.OrderByDescending(g => g.Title).ToList();
        ViewBag.AllGamesOrderedByDESCTitle = AllGamesOrderedByDESCTitle;
        //? All Games Ordered by title and then by price
        List<Game> AllGamesOrderedByTitleAndPrice = Games.OrderBy(g => g.Title).OrderBy(t => t.Price).ToList();
        ViewBag.AllGamesOrderedByTitleAndPrice = AllGamesOrderedByTitleAndPrice;
        //? All Games Ordered by price and then by title
        List<Game> AllGamesOrderedByPriceAndTitle = Games.OrderBy(g => g.Price).OrderBy(t => t.Title).ToList();
        ViewBag.AllGamesOrderedByPriceAndTitle = AllGamesOrderedByPriceAndTitle;
        //? My Favourite Game
        Game MyFavouriteGame = Games.FirstOrDefault(g => g.Title == "FIFA 23");
        ViewBag.MyFavouriteGame = MyFavouriteGame;
        //? All Games Titles
        List<string> AllGamesTitles = Games.Select(g => g.Title).ToList();
        ViewBag.AllGamesTitles = AllGamesTitles;
        //? Modst Expensive Game
        double mostExpensiveGamePrice = Games.Max(f=> f.Price);
        ViewBag.mostExpensiveGamePrice = mostExpensiveGamePrice;
        //? PES exist or not
        bool GameExist = Games.Any(g => g.Title == "PES");
        return View();
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
