
public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;


    public Order(List<Product> products, Customer customer) {
        _products = products;
        _customer = customer;
    }



    public double GetTotalCost() {
        double totalCost = 0;
        foreach (Product p in _products) {
            totalCost += p.GetTotalCost();
        }
        if (_customer.IsInUSA()) {
            totalCost += 5;
        }
        else {totalCost += 35;}
        return totalCost;
    }

    public string GetPackingLabel() {
        string label = "";
        foreach (Product p in _products) {
            label += $"{p.GetID()}    {p.GetName()}\n";
        }
        return label;
    }

    public string GetShippingLabel() {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}