using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MobileApp;

public class PageModelBase : INotifyPropertyChanged
{
	public PageModelBase()
	{
		
	}

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}