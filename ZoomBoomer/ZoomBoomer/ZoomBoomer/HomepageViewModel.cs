using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ZoomBoomer
{
    public class HomepageViewModel : INotifyPropertyChanged
    {
        HomePage _homePage;
        public HomepageViewModel(Page page)
        {
            _homePage = page as HomePage;
        }
        private string _mainText = "Hello World!";
        public string MainText {
            get
            {
                return _mainText;
            }
            set
            {
                _mainText = value;
                OnPropertyChanged();
            }
        }

        private string _inputText = "abc";
        public string InputText {
            get { return _inputText; }
            set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }

        private int _fontSize = 50;
        public int FontSize
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
                OnPropertyChanged();
            }
        }

        private double _scaleFactor = 1D;
        public double ScaleFactor
        {
            get
            {
                return _scaleFactor;
            }
            set
            {
                _scaleFactor = value;
                OnPropertyChanged();
            }
        }

        private Command _incrementSize;
        public ICommand IncrementCommand
        {
            get
            {
                if (_incrementSize == null)
                    _incrementSize = new Command(OnIncrementSize);

                return _incrementSize;
            }
        }
        private void OnIncrementSize() => this.FontSize+=50;

        private Command _decrementSize;
        public ICommand DecrementCommand
        {
            get
            {
                if (_decrementSize == null)
                    _decrementSize = new Command(OnDecrementSize);

                return _decrementSize;
            }
        }
        private void OnDecrementSize() => this.FontSize-=50;

        private Command _updateCommand;
        public ICommand UpdateCommand {
            get
            {
                if(_updateCommand == null)
                    _updateCommand = new Command(OnUpdateCommand);
                return _updateCommand;
            }
        }

        private void OnUpdateCommand()
        {
            this.MainText = this.InputText;
        }

        #region Scale
        private Command _incrementScale;
        public ICommand IncrementScaleCommand
        {
            get
            {
                if (_incrementScale == null)
                    _incrementScale = new Command(OnIncrementScale);

                return _incrementScale;
            }
        }
        private void OnIncrementScale() => this.ScaleFactor++;

        private Command _decrementScale;
        public ICommand DecrementScaleCommand
        {
            get
            {
                if (_decrementScale == null)
                    _decrementScale = new Command(OnDecrementScale);

                return _decrementScale;
            }
        }
        private void OnDecrementScale() => this.ScaleFactor--; 
        #endregion

        #region INotify stuff
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
