using BOL;

namespace SAL;

public interface IProductService{
    public List<Product> GetAll();
    public Product GetById(int id);
    public bool Save(Product product);
    public bool Update(Product product);
    public bool Remove(int id);
}