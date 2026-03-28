namespace Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> _objects = new List<T>();

    public void AddItem(T item) => _objects.Add(item);

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (T item in _objects)
        {
            totalCost += item.CalculateCost();
        }

        return totalCost;
    }
}