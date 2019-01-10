using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using PizzaPlace070.Shared;
using System.Runtime.CompilerServices;

namespace PizzaPlace070.Shared
{
  // NOTE : In some browsers you can get a TypeLoadException
  // Please update your version of your browser, or use a different browser
  // You can also add to your Blazor client project a class implementing
  // the INotifyDataErrorInfo, INotifyPropertyChanged interfaces.
  public class Customer : INotifyDataErrorInfo, INotifyPropertyChanged
  {
    public int Id { get; set; }

    private string name;

    public string Name
    {
      get { return name; }
      set { name = value; OnPropertyChanged(); }
    }

    private string street;

    public string Street
    {
      get { return street; }
      set { street = value; OnPropertyChanged(); }
    }

    private string city;

    public string City
    {
      get { return city; }
      set { city = value; OnPropertyChanged(); }
    }

    public Order Order { get; set; }

    public bool HasErrors => GetErrors(string.Empty).Any();

    public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(
             [CallerMemberName] string propertyName = "")
    {
      PropertyChanged?.Invoke(this,
        new PropertyChangedEventArgs(propertyName));
    }

    public IEnumerable GetErrors(string propertyName)
    {
      if (string.IsNullOrEmpty(propertyName)
          || propertyName == nameof(Name))
      {
        if (string.IsNullOrEmpty(Name))
        {
          yield return $"A customer's name is mandatory";
        }
        else if (Name.Contains("Pizza"))
        {
          yield return $"Name should not contain \"Pizza\"";
        }
      }
      if (string.IsNullOrEmpty(propertyName)
          || propertyName == nameof(Street))
      {
        if (string.IsNullOrEmpty(Street))
        {
          yield return $"{propertyName} is mandatory";
        }
      }
      if (string.IsNullOrEmpty(propertyName)
          || propertyName == nameof(City))
      {
        if (string.IsNullOrEmpty(City))
        {
          yield return $"{propertyName} is mandatory";
        }
      }
    }
  }
}
