using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace PropertyChangedHiddenRepro;
public class ReproPage :ContentPage,INotifyPropertyChanged
{
// In current config gives warning...
// Severity	Code	Description	Project	File	Line	Suppression State
// Warning CS0108	'ReproPage.PropertyChanged' hides inherited member 'BindableObject.PropertyChanged'. Use the new keyword if hiding was intended.PropertyChangedHiddenRepro(net6.0), PropertyChangedHiddenRepro(net6.0-android), PropertyChangedHiddenRepro(net6.0-ios), PropertyChangedHiddenRepro(net6.0-maccatalyst), PropertyChangedHiddenRepro(net6.0-windows10.0.19041.0) D:\Source\Repos\Testing\PropertyChangedHiddenRepro\PropertyChangedHiddenRepro\ReproPage.cs	8	Active
// If you comment out PropertyChanged  you get error...
// Severity	Code	Description	Project	File	Line	Suppression State
// Error CS0079  The event 'BindableObject.PropertyChanged' can only appear on the left hand side of += or -=	PropertyChangedHiddenRepro (net6.0), PropertyChangedHiddenRepro(net6.0-android), PropertyChangedHiddenRepro(net6.0-ios), PropertyChangedHiddenRepro(net6.0-maccatalyst), PropertyChangedHiddenRepro(net6.0-windows10.0.19041.0) D:\Source\Repos\Testing\PropertyChangedHiddenRepro\PropertyChangedHiddenRepro\ReproPage.cs	19	Active
public event PropertyChangedEventHandler PropertyChanged;
private string _StringProperty=string.Empty;
public string StringProperty {
    get{return _StringProperty;}
    set {
        if (_StringProperty!=value) {
            _StringProperty=value;
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(StringProperty));
            }
        }
    }
}