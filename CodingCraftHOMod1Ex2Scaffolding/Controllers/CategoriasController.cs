using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using CodingCraftHOMod1Ex2Scaffolding.Models;

namespace CodingCraftHOMod1Ex2Scaffolding.Controllers
{
    public class CategoriasController : Controller
    {
        private CodingCraftHOMod1Ex2ScaffoldingContext db = new CodingCraftHOMod1Ex2ScaffoldingContext();

        //
        // GET: /Categorias/

        public async Task<ActionResult> Indice()
        {
            return View(await db.Categorias.Include(categoria => categoria.Produtos).ToListAsync());
        }

        //
        // GET: /Categorias/Detalhes/5

        public async Task<ActionResult> Detalhes(int? id)
        {
			if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = await db.Categorias.FirstOrDefaultAsync(x => x.CategoriaId == id);

			if (categoria == null)
            {
                return HttpNotFound();
            }

            return View(categoria);
        }

        //
        // GET: /Categorias/Criar

        public ActionResult Criar()
        {
            return View();
        }

        //
        // POST: /Categorias/Criar

        [HttpPost]
        public async Task<ActionResult> Criar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categoria);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Indice));  
            }

            return View(categoria);
        }
        
        //
        // GET: /Categorias/Editar/5
 
        public async Task<ActionResult> Editar(int? id)
        {
			if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = await db.Categorias.FirstOrDefaultAsync(x => x.CategoriaId == id);

			if (categoria == null)
            {
                return HttpNotFound();
            }

            return View(categoria);
        }

        //
        // POST: /Categorias/Editar/5

        [HttpPost]
        public async Task<ActionResult> Editar(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoria).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Indice));
            }
            return View(categoria);
        }

        //
        // GET: /Categorias/Excluir/5
 
        public async Task<ActionResult> Excluir(int? id)
        {
			if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = await db.Categorias.FirstOrDefaultAsync(x => x.CategoriaId == id);

			if (categoria == null)
            {
                return HttpNotFound();
            }

            return View(categoria);
        }

        //
        // POST: /Categorias/Excluir/5

        [HttpPost, ActionName(nameof(Excluir))]
        public async Task<ActionResult> ConfirmarExclusao(int id)
        {
            Categoria categoria = await db.Categorias.SingleAsync(x => x.CategoriaId == id);
            db.Categorias.Remove(categoria);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Indice));
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}