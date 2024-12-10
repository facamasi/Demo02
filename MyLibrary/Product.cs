namespace MyLibrary;
public class Product (int id, string name, decimal unitPrice, int unitInStock)
{
    //Field, Campo, Variable

    private int Id_Field;

    //Prpiedades
    public int Id { get; } = id;
    public string Name { get; } = name;
    public decimal UnitPrice { get; } = unitPrice;
    public int UnitInStock { get; } = unitInStock;

    public bool Discontinued { get; private set; }

    public void SetDiscontinued() => Discontinued = true; 
    
    //Herencia

    //public class Producto2(int id, string name, decimal unitPrice, int unitInStock, bool discontinue) 
    //    : Product (id, name, unitPrice,unitInStock)
    //{
    //    public bool Discontinue { get;  set; } = discontinue;
    //}


}


