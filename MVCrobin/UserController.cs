using Microsoft.AspNetCore.Mvc;
using MVCrobin.Data;

namespace MVCrobin.Controllers;

public class UserController : Controller
{
    private readonly MySqlDBContext _context;
    public UserController(MySqlDBContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        
        return View();
    }

    public IActionResult Edit()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    public IActionResult Listar()
    {
        var users = _context.users.ToList();
        return View(users);
    }
}