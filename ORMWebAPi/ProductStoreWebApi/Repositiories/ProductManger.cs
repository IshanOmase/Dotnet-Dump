using ProductStoreWebApi.Entities;

namespace ProductStoreWebApi.Repositories;

public class ProductManager : IProductManager
{
    public ProductManager(){
        Console.WriteLine("In prod mgr");
    }
    public bool Add(Product p)
    {
        using(var context = new CollectionContext()){
            context.Add(p);
            context.SaveChanges();
            return true;
        }
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        using(var context = new CollectionContext()){
            context.Remove(context.Products.Find(id));
            context.SaveChanges();
            return true;
        }
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        using(var context = new CollectionContext()){
            var products = from prod in context.Products select prod;
            return products.ToList<Product>();
        }
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        using(var context = new CollectionContext()){
            var product = context.Products.Find(id);
            return product;
        }
        throw new NotImplementedException();
    }

    public bool Update(Product p)
    {
        using(var context = new CollectionContext()){
            Product product = context.Products.Find(p.Pid);
            product.Name = p.Name;
            product.Price = p.Price;
            product.Brand = p.Brand;
            product.Type = p.Type;
            context.SaveChanges();
            return true;
        }
        throw new NotImplementedException();
    }
}