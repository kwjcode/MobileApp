
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MobileApp.ViewModel;

public class HomePageViewModel : PageModelBase
{
	public RelayCommand OpenCameraCommand { get;set; }

    private bool _AutoStartPreview;
    public bool AutoStartPreview
    {
        get => _AutoStartPreview;
        set
        {
            _AutoStartPreview = value;
            OnPropertyChanged();
        }
    }

    private CameraInfo camera = null;
    public CameraInfo Camera
    {
        get => camera;
        set
        {
            camera = value;
            OnPropertyChanged();
            AutoStartPreview = false;
            OnPropertyChanged();
            AutoStartPreview = true;
            OnPropertyChanged();
        }
    }

    private ObservableCollection<CameraInfo> cameras = new();
    public ObservableCollection<CameraInfo> Cameras
    {
        get => cameras;
        set
        {
            cameras = value;
            OnPropertyChanged();
        }
    }

    public HomePageViewModel()
	{
		OpenCameraCommand = new RelayCommand(OpenCamera);
        

    }

	private void OpenCamera()
	{
        AutoStartPreview = true;

    }

}