namespace PointOfSale.Payment;

// Fake card terminal so I can test checkout without real hardware. Just pretends
// the amount went to a reader and got approved.
// TODO: implement IPaymentTerminal - small delay then return approved
public class MockPaymentTerminal // : IPaymentTerminal
{
}
