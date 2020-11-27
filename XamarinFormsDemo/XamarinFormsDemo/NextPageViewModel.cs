using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsDemo
{
    public class NextPageViewModel : INotifyPropertyChanged
    {
        private int count;
        public int Count
        {
            get => count;
            set
            {
                if (count == value)
                    return;

                count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        public ICommand PlusButtonCommand => new Command(() =>
        {
            Count++;
        });

        public ICommand MinusButtonCommand => new Command(() =>
        {
            Count--;
        });

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
