using Syncfusion.SfCalendar.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CalendarXamarin.ViewModel
{
    class CalendarViewModel : INotifyPropertyChanged
    {
        private bool isSelected { get; set; }
        public string DayNumber => Date.Day.ToString();
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                this.isSelected = value;
                NotifyPropertyChanged("IsSelected");
            }
        }
        public DateTime Date { get; set; }
        public Color TextColor { get; set; } = Color.Black;
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

