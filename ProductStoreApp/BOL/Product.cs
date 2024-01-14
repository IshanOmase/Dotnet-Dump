//pid | pname| pdesc| pqty| pprice

namespace BOL;

[Serializable]
public class Product{
    public int Pid{get;set;}
    public string Pname{get; set;}
    public string Pdesc{get; set;}
    public double Pqty{get;set;}
    public double Pprice{get;set;}

    public override string ToString()
    {
        return "Product[ID: " + Pid
                + " |Name: " + Pname
                +" |Quantity: " + Pqty
                +" |Price: " + Pprice
                +"]";
    }
}

