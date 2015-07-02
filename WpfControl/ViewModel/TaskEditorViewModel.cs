using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

namespace WpfControl.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class TaskEditorViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the TaskEditor class.
        /// </summary>
        public TaskEditorViewModel(string taskName)
        {
            _taskName = taskName;
            _clickCommand = new RelayCommand(Click);
        }

        public string DisplayName
        {
            get { return string.Format("Edit Task {0}", _taskName); }
        }

        public string InputValue
        {
            get { return _inputValue; }
            set
            {
                _inputValue = value; 
                RaisePropertyChanged();
            }
        }

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value; 
                RaisePropertyChanged();
            }
        }

        public ICommand ClickCommand
        {
            get { return _clickCommand; }
        }

        private string _taskName;
        private string _inputValue;
        private int _count;
        private readonly ICommand _clickCommand;

        private void Click()
        {
            Count++;
            _taskName = InputValue;

            RaisePropertyChanged(() => DisplayName);
        }
    }
}