namespace PointOfSale.Models;

// A finished transaction once the customer has paid. This is what gets saved
// to the database and shows up in the sales history.
// TODO: timestamp, subtotal, tax, total, payment method, and the list of lines
public class Sale
{
}

// One product line inside a saved sale. I store the name + price here too so old
// receipts still look right even if I change the product later.
// TODO: product id, name, quantity, unit price
public class SaleLine
{
}
