using BOL;
using DAL.Connected;

namespace BLL;
public class BIManager{
    
    public List<Product> GetAll(){
        Console.WriteLine("In BIManager get all");
        MySqlDBManager mgr = new MySqlDBManager();
        List<Product> products = mgr.GetALL();
        return products;
    }
    
    public Product GetById(int id){
        Console.WriteLine("in bimanager get by id");
        MySqlDBManager mgr = new MySqlDBManager();
        Product prod = mgr.GetById(id);
        return prod;
    }

    public bool Insert(Product product){
        Console.WriteLine("in bimanager insert");
        MySqlDBManager mgr = new MySqlDBManager();
        return mgr.Insert(product);
    }
    
    public bool Update(Product product){
        Console.WriteLine("in bimanager update");
        MySqlDBManager mgr = new MySqlDBManager();
        return mgr.Update(product);
    }

    public bool Delete(int id){
        Console.WriteLine("in bimanager delete");
        MySqlDBManager mgr = new MySqlDBManager();
        return mgr.DeleteByID(id);
    }
}
