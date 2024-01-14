using BOL;
using BLL;

namespace SAL;
public class ProductService:IProductService {

    public List<Product> GetAll(){
        Console.WriteLine("in prod serv get all");
        BIManager mgr = new BIManager();
        List<Product> products = new List<Product>();
        products = mgr.GetAll();
        return products;
    }

    public Product GetById(int id){
        Console.WriteLine("in prod serv get by id");
        BIManager mgr = new BIManager();
        Product product = new Product();
        product = mgr.GetById(id);
        return product;
    }

    public bool Remove(int id)
    {
        Console.WriteLine("in prod serv remove");
        BIManager mgr = new BIManager();
        return mgr.Delete(id);
    }

    public bool Save(Product product)
    {
        Console.WriteLine("in prod serv save");
        BIManager mgr = new BIManager();
        return mgr.Insert(product);
    }

    public bool Update(Product product)
    {
        Console.WriteLine("in prod serv update");
        BIManager mgr = new BIManager();
        return mgr.Update(product);
    }
}