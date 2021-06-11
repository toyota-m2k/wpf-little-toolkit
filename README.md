# wpf-little-toolkit

Some useful views, extensions and helper classes to develop WPF applications.
Someone will be very happy with it and they would die without it.

## ■Views

## CircleProgressView

  "Progress Ring" with a percent label, customizable from xaml.
 
## PathView

  The view drawing "SVG path" on it, similar to PathIcon in UWP.
  
## StretchListView

  ListView which has a column to strech and fit to view width.

## NumericTextBox

  TextBox which accept only numbers character.
 
## CheckButton

  A button which has the IsChecked attribute.
  This is similar to ToggleButton, but it's IsChecked attribute will not be changed by click action but can be changed it only programatically.
  It's useful in specal cases to handle "un-bindable property" of view for example "Play" property of MediaElement.
  
## MenuButton

  A button which is intended to bind its IsChecked property to DropDownMenu.IsOpen property.
  
## WaitCursor

  Disposable wait cursor class.
  A heavy task can be executed in it's "using block" like this.
  ```
  using(WaitCuror.Start(this)) {
    HeavyTask();
  }
  ```
 
 ## ViewModelBase
 
  A common implementation of ViewModel which support  INotifyPropertyChanged.
  This class is intended to work with [ReactiveProperty](https://github.com/runceel/ReactiveProperty), it can dispose all properties which implements IDisposable automatically.
  
