using MiniFarm_Patterns_MVP_Wpf_App.Core;
using MiniFarm_Patterns_MVP_Wpf_App.ViewModel.AnimalViews;
using System.Windows;

namespace MiniFarm_Patterns_MVP_Wpf_App.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand ShutDownWindowCommand { get; set; }
        public RelayCommand MaximizeWindowCommand { get; set; }
        public RelayCommand MinimizeWindowCommand { get; set; }
        public RelayCommand ShowCowWindow { get; set; }
        public RelayCommand ShowChickenWindow { get; set; }
        public RelayCommand ShowTurtleWindow { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public CowViewModel CowVM { get; set; }
        public ChickenViewModel ChickenVM { get; set; }
        public TurtleViewModel TurtleVM { get; set; }

        public MainViewModel()
        {
            CowVM = new();
            ChickenVM = new();
            TurtleVM = new();
            CurrentView = CowVM;
            CurrentView = ChickenVM;
            CurrentView = TurtleVM;

            Application.Current.MainWindow.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;

            MoveWindowCommand = new(o => { Application.Current.MainWindow.DragMove(); });
            ShutDownWindowCommand = new(o => { Application.Current.Shutdown(); });
            MaximizeWindowCommand = new(o =>
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                else
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
            });

            MinimizeWindowCommand = new(o =>
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Minimized)
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                else
                    Application.Current.MainWindow.WindowState = WindowState.Minimized;
            });
            ShowCowWindow = new(o => { CurrentView = CowVM; });
            ShowChickenWindow = new(o => { CurrentView = ChickenVM; });
            ShowTurtleWindow = new(o => { CurrentView = TurtleVM; });
        }
    }
}
