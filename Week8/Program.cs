using Week8;

var letter1 = new Letter("153", 15);
var letter2 = new Letter("415", 5);

var parcel1 = new Parcel("513", 50, "30x10x50");
var parcel2 = new Parcel("541", 23, "35x15x60");

letter1.PrintInfo();
Console.WriteLine();
parcel2.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(letter1);
myCargo.AddItem(parcel1);
myCargo.AddItem(letter2);
myCargo.AddItem(parcel2);

Console.WriteLine();
Console.WriteLine($"Total cost: {myCargo.GetTotalCost()}");