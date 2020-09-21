﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Xamlly.Sample
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Option> options;
        private Option selectedOption;

        public ObservableCollection<Option> Options
        {
            get => options; 
            set
            {
                options = value;
                OnPropertyChanged();
            }
        }

        public Option SelectedOption {
            get => selectedOption;
            set
            {
                selectedOption = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            Options = new ObservableCollection<Option>(new List<Option>
            {
                new Option {ID = 1, Name = "Option 1"},
                new Option {ID = 2, Name = "Option 2"},
                new Option {ID = 3, Name = "Option 3"},
                new Option {ID = 4, Name = "Option 4"},
            });
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}