using BOL;
using MySql.Data.MySqlClient;

namespace DAL.Connected;

public class MySqlDBManager{
    public MySqlDBManager(){}

    public List<Product> GetALL(){
        Console.WriteLine("In dbmanager get all");
        List<Product> products = new List<Product>();
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString=@"server=localhost; port=3306; user=root; password=Strong@123; database=transflower";
        MySqlCommand command = new MySqlCommand();
        command.Connection=connection;
        command.CommandText="SELECT * FROM product";
        try
        {  //pid | pname| pdesc| pqty| pprice
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["pid"].ToString());
                string? name = reader["pname"].ToString();
                string? desc = reader["pdesc"].ToString();
                double qty = double.Parse(reader["pqty"].ToString());
                double price = double.Parse(reader["pprice"].ToString());
                Product prod = new Product();
                prod.Pid = id;
                prod.Pname = name;
                prod.Pdesc = desc;
                prod.Pqty = qty;
                prod.Pprice = price;
                products.Add(prod);
            }
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally
        {
            // Console.WriteLine(products[0]);
            connection.Close();
        }

        return products;
    }

    public Product GetById(int id){
        Console.WriteLine("In dbmanager get ny id");
        Product prod = new Product();       
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString=@"server=localhost; port=3306; user=root; password=Strong@123; database=transflower";
        MySqlCommand command = new MySqlCommand();
        command.Connection=connection;
        command.CommandText="SELECT * FROM product where pid="+id;
        try
        {  //pid | pname| pdesc| pqty| pprice
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.Read()){
                prod.Pid = id;
                string? name = reader["pname"].ToString();
                string? desc = reader["pdesc"].ToString();
                double qty = double.Parse(reader["pqty"].ToString());
                double price = double.Parse(reader["pprice"].ToString());
                
                prod.Pid = id;
                prod.Pname = name;
                prod.Pdesc = desc;
                prod.Pqty = qty;
                prod.Pprice = price;
            }

        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally
        {
            // Console.WriteLine(products[0]);
            connection.Close();
        }

        return prod;
    }

    public bool Insert(Product product){
        Console.WriteLine("In dbmanager insert");      
        bool status = false;
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString=@"server=localhost; port=3306; user=root; password=Strong@123; database=transflower";
        MySqlCommand command = new MySqlCommand();
        command.Connection=connection;

        command.CommandText="INSERT INTO product values("+product.Pid+",'"+product.Pname+"','"+product.Pdesc+"','"+product.Pqty+"','"+product.Pprice+"')";
        try
        {  //pid | pname| pdesc| pqty| pprice
            connection.Open();
            command.ExecuteNonQuery();
            status =true;    
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally
        {
            // Console.WriteLine(products[0]);
            connection.Close();
        }
        return status;
    }

    public bool Update(Product product){
        Console.WriteLine("In dbmanager update");
        bool status = false;
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString=@"server=localhost; port=3306; user=root; password=Strong@123; database=transflower";
        MySqlCommand command = new MySqlCommand();
        command.Connection=connection;
        command.CommandText="Update product set pname='"+product.Pname+"',pdesc='"+product.Pdesc+"',pqty="+product.Pqty+",pprice="+product.Pprice+" where pid="+product.Pid;
        try
        {  //pid | pname| pdesc| pqty| pprice
            connection.Open();
            command.ExecuteNonQuery();
            status = true;
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally
        {
            // Console.WriteLine(products[0]);
            connection.Close();
        }

        return status;
        
    }

    public bool DeleteByID(int id){
        
        Console.WriteLine("In dbmanager delete");
        bool status = false;
        MySqlConnection connection = new MySqlConnection();
        connection.ConnectionString=@"server=localhost; port=3306; user=root; password=Strong@123; database=transflower";
        MySqlCommand command = new MySqlCommand();
        command.Connection=connection;
        command.CommandText="delete from product where pid="+ id;
        try
        {  //pid | pname| pdesc| pqty| pprice
            connection.Open();
            command.ExecuteNonQuery();
            status = true;
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally
        {
            // Console.WriteLine(products[0]);
            connection.Close();
        }

        return status;
        
    }


    

}

