using Microsoft.AspNetCore.Mvc;
using ProductStoreWebApi.Entities;
using ProductStoreWebApi.Services;

namespace ProductStoreWebApi.Controllers;

public class ProductController:Controller{
    private readonly ProductService svc = new ProductService();

    public ProductController(){
        Console.WriteLine("In prod ctlr");
    }

    public IActionResult Index(){
        List<Product> products = svc.GetAll();
        return View(products);
    }

    public IActionResult Details(int id){
        return View(svc.GetById(id));
    }

    public IActionResult AddForm(){
        return View();
    }

    public IActionResult Add(Product p){
        svc.Add(p);
        return RedirectToAction("Index","Product");
    }

    public IActionResult Edit(int id){
        Product p = svc.GetById(id);
        return View(p);
    }

    public IActionResult Update(Product p){
        svc.Update(p);
        return RedirectToAction("Index", "Product");
    }

}
