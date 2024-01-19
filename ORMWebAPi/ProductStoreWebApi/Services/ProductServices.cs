using ProductStoreWebApi.Entities;
using ProductStoreWebApi.Repositories;

namespace ProductStoreWebApi.Services;

public class ProductService : IProductService
{
    private ProductManager mgr = new ProductManager();
    public bool Add(Product p)
    {
        return mgr.Add(p);
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        return mgr.Delete(id);
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return mgr.GetAll();
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        return mgr.GetById(id);
        throw new NotImplementedException();
    }

    public bool Update(Product p)
    {
        return mgr.Update(p);
        throw new NotImplementedException();
    }
}