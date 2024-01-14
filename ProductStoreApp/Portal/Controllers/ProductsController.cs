using BOL;
using Microsoft.AspNetCore.Mvc;
using SAL;

namespace ProductStoreApp.Controllers;

public class ProductsController:Controller{
    string _conString=@"server=localhost; port=3306; user=root; password=Strong@123; database=transflower";
    private readonly IProductService _svc;
    private readonly IConfiguration _configuration;

    public ProductsController(IProductService svc, IConfiguration configuration){
        this._svc = svc;
        this._configuration = configuration;
        Console.WriteLine("In Product's Controller");
    }
    
    [HttpGet]
    public IActionResult Index(){
        Console.WriteLine("in prod cntler index  get");
        //var connString = _configuration.GetConnectionString("Iascd0923Db");
        List<Product> products = _svc.GetAll();
        // foreach(Product p in products){
        //     Console.WriteLine(p.Pname);
        // }
        TempData["allProducts"] = products;
        return View();
    }

    public IActionResult Details(int id){
        Console.WriteLine("in prod cntler details get");
        Product product = _svc.GetById(id);
        return View(product);
    }

    public IActionResult Add(){
        Console.WriteLine("in prod cntler add get");
        return View();
    }

    [HttpPost]
    public IActionResult Add(IFormCollection form){
        Console.WriteLine("in prod cntler add post");
        var id = int.Parse(form["id"].ToString());
        var name = form["name"].ToString();
        var desc = form["desc"].ToString();
        var qty = int.Parse(form["qty"].ToString());
        var price = double.Parse(form["price"].ToString());
        Product product = new Product
        {
            Pid = id,
            Pname = name,
            Pdesc = desc,
            Pqty = qty,
            Pprice = price
        };

        _svc.Save(product);

        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Edit(int id){
        Console.WriteLine("in prod cntler edit get");
        List<Product> products = _svc.GetAll();
        var p = products.Find(p => p.Pid == id);
        return View(p);
    }

    [HttpPost]
    public IActionResult Edit(IFormCollection form){
        Console.WriteLine("in prod cntler edit post");
        var id=int.Parse(form["id"].ToString());
        var name = form["name"].ToString();
        var desc = form["desc"].ToString();
        var qty = int.Parse(form["qty"].ToString());
        var price = double.Parse(form["price"].ToString());
        Product product = new Product
        {
            Pid = id,
            Pname = name,
            Pdesc = desc,
            Pqty = qty,
            Pprice = price
        };

        _svc.Update(product);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id){
        Console.WriteLine("in prod cntler detete get");
        List<Product> products = _svc.GetAll();
        var p = products.Find(p => p.Pid == id);
        return View(p);
    }

    [HttpPost]
    public IActionResult Delete(IFormCollection form){
        Console.WriteLine("in prod cntler detete post");
        var id=int.Parse(form["id"].ToString());
        Console.WriteLine(_svc.Remove(id));
        return RedirectToAction("Index");
    }


    
}