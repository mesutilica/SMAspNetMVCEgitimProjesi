using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreMvcProjeUygulamasi.Data;
using NetCoreMvcProjeUygulamasi.Entities;

namespace NetCoreMvcProjeUygulamasi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly DatabaseContext _context;

        public CategoriesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: CategoriesController
        public async Task<ActionResult> IndexAsync()
        {
            var model = await _context.Categories.ToListAsync();
            return View(model);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category, IFormFile? Image)
        {
            try
            {
                if (Image is not null)
                {
                    string klasor = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName; // yükleme yapacağımız klasörü belirttik
                    using var stream = new FileStream(klasor, FileMode.Create); // yükleme için gerekli veri akışı oluşturduk
                    Image.CopyTo(stream); // veri akışını kullanarak yükleme yaptık
                    category.Image = Image.FileName;
                }
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _context.Categories.FirstOrDefault(c => c.Id == id);
            return View(model);
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category, IFormFile? Image)
        {
            try
            {
                if (Image is not null)
                {
                    string klasor = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName;
                    using var stream = new FileStream(klasor, FileMode.Create);
                    Image.CopyTo(stream);
                    category.Image = Image.FileName;
                }
                _context.Categories.Update(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
            return View(model);
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            try
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
