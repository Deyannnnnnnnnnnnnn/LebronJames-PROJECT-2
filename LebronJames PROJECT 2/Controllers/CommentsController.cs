using LebronJames_PROJECT_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class CommentsController : Controller
{
    private readonly ApplicationDbContext _context;

    public CommentsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Метод за показване на последните 10 коментара
    [HttpGet]
    public IActionResult Index()
    {
        var comments = _context.Comments
            .OrderByDescending(c => c.CreatedAt)
            .Take(10) // Вземане на последните 10 коментара
            .ToList();
        return View(comments);
    }

    // Метод за добавяне на нов коментар
    [HttpPost]
    public IActionResult AddComment(string username, string content)
    {
        if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(content))
        {
            var comment = new Comment
            {
                Username = username,
                Content = content,
                CreatedAt = DateTime.Now
            };

            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        // Пренасочване към страницата с коментарите след добавяне
        return RedirectToAction("Index");
    }

    // Метод за показване на коментари, свързани с определено потребителско име
    [HttpGet]
    public IActionResult UserComments(string username)
    {
        if (string.IsNullOrEmpty(username))
        {
           
            return RedirectToAction("Index");
        }

      
        var userComments = _context.Comments
            .Where(c => c.Username == username)
            .OrderByDescending(c => c.CreatedAt)
            .ToList();

        return View(userComments);
    }
}
