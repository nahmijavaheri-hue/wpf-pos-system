namespace PointOfSale.Mvvm;

// Base class for my view models. Lets them tell the UI when a property changed
// so bindings refresh. Saves me repeating the same notify code everywhere.
// TODO: implement INotifyPropertyChanged + a SetProperty helper
public abstract class ObservableObject
{
}
