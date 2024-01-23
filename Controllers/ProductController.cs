using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMapper _mapper;
        public ProductController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public FakeDb db = new FakeDb();
        // GET: ProductController
        public ActionResult Index()
        {
            var viewModel = new ProductListViewModel();
            viewModel.Products = _mapper.Map<List<ProductViewModel>>(db.Products);
            return View("Views/ActualViews/Products.cshtml", viewModel);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View("Views/ActualViews/CreateProduct.cshtml");
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel viewModel)
        {
            try
            {
                Product product = _mapper.Map<Product>(viewModel);
                db.Products.Add(product);
                var viewModelProducts = new ProductListViewModel();
                viewModelProducts.Products = _mapper.Map<List<ProductViewModel>>(db.Products);
                return View("Views/ActualViews/Products.cshtml", viewModelProducts);
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            db.Products.Clear();
            return View("Views/ActualViews/Products.cshtml", null);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = db.Products.Where(p => p.Id == id).FirstOrDefault();
            db.Products.Remove(product);
            var viewModelProducts = new ProductListViewModel();
            viewModelProducts.Products = _mapper.Map<List<ProductViewModel>>(db.Products);

            return View("Views/ActualViews/Products.cshtml", viewModelProducts);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
