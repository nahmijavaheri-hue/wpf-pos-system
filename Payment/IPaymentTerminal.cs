namespace PointOfSale.Payment;

// The line between my app and a real card reader. The POS just hands over an
// amount and waits for a result - it never sees actual card details.
// Later I can write a real version of this for an actual terminal (Stripe/Square/etc).
// TODO: a method that takes the amount and returns whether it was approved
public interface IPaymentTerminal
{
}
