using LibraryWEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWEB.Controllers
{
    public class HomeController : Controller
    {
        LibraryContext db;
        public HomeController(LibraryContext context)
        {
            db = context;
        }
        /// <summary>
        /// Shows all articles
        /// </summary>
        /// <returns>Index page</returns>
        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 3;
            
            IQueryable<Article> source = db.Articles.Include(x => x.Tags).OrderByDescending(a => a.Date);

            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Articles = items
            };

            return View(viewModel);
        }

        /// <summary>
        /// Show page with specific article
        /// </summary>
        /// <param name="id">Id of specific page</param>
        /// <returns>Index page</returns>
        [Route("Home/Article")]
        public IActionResult Article(int id)
        {
            Article article = new Article();

            var articles = db.Articles.ToList();

            foreach (var art in articles)
            {
                if (art.Id == id)
                {
                    article = art;
                }
            }

            return View(article);
        }

        public IActionResult CreateArticle()
        {
            return View(new Article());
        }

        [HttpPost]
        public RedirectResult CreateArticle(Article article, IFormCollection collection)
        {
            var str = collection["Tags"].ToString().Replace(" ", "");

            string[] tags = str.Split(',');

            Article newArticle = new Article { Title = article.Title, Text = article.Text, Date = DateTime.Now };

            foreach (var s in tags)
            {
                var tag = db.Tags
                    .FirstOrDefault(t => t.Name == s);

                if (tag != null)
                {
                    tag.Articles.Add(newArticle);
                    db.SaveChanges();
                }
                else
                {
                    Tag newTag = new Tag { Name = s, Articles = new List<Article> { newArticle } };
                    db.Tags.Add(newTag);
                    db.SaveChanges();
                }
            }

            return Redirect("/Home/Index");
        }

        public async Task<IActionResult> ShortArticles(int id, int page = 1)
        {
            var tags = db.Tags.Include(t => t.Articles).ToList();

            var tag = tags.FirstOrDefault(t => t.Id == id);

            int pageSize = 3;

            IEnumerable<Article> source = tag.Articles;

            var count = source.Count();
            var items = source.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Articles = items
            };

            return View(viewModel);
        }
    }
}
