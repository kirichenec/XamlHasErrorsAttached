using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestValidation
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private int _numberOne;

        public int NumberOne
        {
            get { return _numberOne; }
            set
            {
                if (_numberOne == value)
                {
                    return;
                }
                _numberOne = value;
                OnPropertyChanged();
            }
        }

        private int _numberTwo;

        public int NumberTwo
        {
            get { return _numberTwo; }
            set
            {
                if (_numberTwo == value)
                {
                    return;
                }
                _numberTwo = value;
                OnPropertyChanged();
            }
        }

        private int _numberThree;

        public int NumberThree
        {
            get { return _numberThree; }
            set
            {
                if (_numberThree == value)
                {
                    return;
                }
                _numberThree = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
