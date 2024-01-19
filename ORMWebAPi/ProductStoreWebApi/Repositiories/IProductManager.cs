using ProductStoreWebApi.Entities;

namespace ProductStoreWebApi.Repositories;

public interface IProductManager{
    public List<Product> GetAll();
    public Product GetById(int id);
    public Boolean Update(Product p);
    public Boolean Delete(int id);
    public Boolean Add(Product p);
    
}