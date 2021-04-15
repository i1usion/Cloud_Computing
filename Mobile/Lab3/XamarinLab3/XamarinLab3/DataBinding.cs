using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XamarinLab3
{
    public class DataBinding : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        string firstName = String.Empty;

        public string LabelName
        {
            get => firstName;

            set
            {
                if (firstName == value)
                {
                    return;
                }
                firstName = value;
                OnPropertyChanged(nameof(firstName));
                OnPropertyChanged(nameof(BindingName));
            }

        }

        public string BindingName => $"Entered First name: {LabelName}";
        void OnPropertyChanged(string firstName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(firstName));
        }

        string lastName = String.Empty;

        public string LabelLastName
        {
            get => lastName;

            set
            {
                if (lastName == value)
                {
                    return;
                }
                lastName = value;
                OnPropertyChangedLastName(nameof(lastName));
                OnPropertyChangedLastName(nameof(BindingLastName));
            }

        }

        public string BindingLastName => $"Entered Last name: {LabelLastName}";

        void OnPropertyChangedLastName(string lastName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(lastName));
        }

        string phoneNumber = String.Empty;

        public string LabelPhoneNumber
        {
            get => phoneNumber;

            set
            {
                if (phoneNumber == value)
                {
                    return;
                }
                phoneNumber = value;
                OnPropertyChangedPhoneNumber(nameof(phoneNumber));
                OnPropertyChangedPhoneNumber(nameof(BindingPhoneNumber));
            }

        }

        public string BindingPhoneNumber => $"Entered Phone number: {LabelPhoneNumber}";
        void OnPropertyChangedPhoneNumber(string phoneNumber)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(phoneNumber));
        }

    }
}
