
public class Product {
    private string _name;
    private int _productID;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, double pricePerUnit, int quantity) {
        _name = name;
        _productID = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }



    public double GetTotalCost() {
        return _pricePerUnit * _quantity;
    }

    public string GetName() {
        return _name;
    }

    public int GetID() {
        return _productID;
    }
}