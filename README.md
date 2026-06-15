# wpf-pos-system

A point-of-sale (cash register) desktop application for Windows, built with **C# / WPF (.NET 10)**.

The app handles the *register* side of a sale — building a cart, tracking items and
stock, recording transactions, and handing the final amount to a card terminal.
It deliberately does **not** implement payment processing or card reading itself:
those sit behind a clean interface so a real terminal SDK can be plugged in later.

## Status

🚧 In development — building from scratch.

## Planned features

- [ ] Item catalog (name, SKU/barcode, category, price, stock) with add/edit/delete
- [ ] Register screen: search/filter products, build a cart, adjust quantities
- [ ] Subtotal / tax / total calculation
- [ ] Checkout that sends the amount to a (stubbed) card terminal
- [ ] Sales history with per-transaction receipt detail
- [ ] Daily totals summary
- [ ] Local persistence with SQLite

## Tech stack

| Concern        | Choice                                   |
|----------------|------------------------------------------|
| Language / UI  | C#, WPF (XAML), .NET 10                   |
| Architecture   | MVVM                                      |
| Storage        | SQLite (`Microsoft.Data.Sqlite`)         |
| Payments       | `IPaymentTerminal` interface (mock impl) |

## Architecture (target)

```
Models/      domain types (Product, CartItem, Sale, SaleLine)
Data/        SQLite access + repositories
Payment/     IPaymentTerminal boundary + mock terminal
ViewModels/  MVVM view models (register, catalog, history)
Views/       XAML screens
```

The POS never touches card data — it only calls:

```csharp
Task<PaymentResult> RequestPaymentAsync(decimal amount);
```

Swap the mock for a real terminal SDK (Stripe Terminal, Square, Adyen…) without
changing the UI.

## Getting started

```powershell
git clone https://github.com/<your-username>/wpf-pos-system.git
cd wpf-pos-system
dotnet run
```

Requires the [.NET 10 SDK](https://dotnet.microsoft.com/download).

## License

MIT
