﻿using HMS_v1._0.Commands;
using HMS_v1._0.models;
using HMS_v1._0.Views;
using System;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.Messaging;
using HMS_v1._0.Messages;

namespace HMS_v1._0.ViewModels
{
    public class RegistrationViewModel : ViewModelBase
    {
        private ObservableCollection<string> _items = null!;
        private ObservableCollection<string> _payers = null!;
        private ObservableCollection<string> _contractingAuthorities = null!;
        private ObservableCollection<string> _admissionReasoning = null!;
        private ObservableCollection<string> _hours = null!;
        private ObservableCollection<string> _minutes = null!;


        public RegistrationViewModel()
        {
            Items = new ObservableCollection<string> { "Klaudiusz Sikora", "Robert Nowak", "Asia Szymczak", "Helena Sawicka" };
            Payers = new ObservableCollection<string> { "firma", "os. prywatna" };
            ContractingAuthorities = new ObservableCollection<string> { "\"ADAD\" Specjalistyczne Centrum Medyczne", "Adax-Med Centrum Alergii i Astmy",
                                                                        "Ambulatoryjna Opieka Specjalistyczna", "Carpe Diem Centrum Medycyny Estetycznej", 
                                                                        "Centrum Chirurgii Plastycznej", "CENTRUM MEDYCZNE BEMOWO" };
            AdmissionReasoning = new ObservableCollection<string> { "tryb nagły", "tryb planowy" };
            Hours = new ObservableCollection<string> { "7:", "8:", "9:", "10:", "11:","12", "13:", "14:", "15:" };
            Minutes = new ObservableCollection<string> { "00", "15", "30", "45" };


            Messenger.Default.Register<NewlyAddedPatientMessage>(this, OnPatientAdded);

            RegisterAppointmentCommand = new RegisterAppointmentCommand(this);
            OpenAddNewPatientCommand = new OpenAddNewPatientCommand(this);
            CloseRegistrationWindowCommand = new CloseRegistrationWindowCommand(this);
        }

        private void OnPatientAdded(NewlyAddedPatientMessage message)
        {
            // Update your ViewModel properties with the added patient's information
            PatientName = message.PatientName;
            PatientAge = message.PatientAge.ToString();
            Pesel = message.Pesel;

        }

        public ObservableCollection<string> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    OnPropertyChanged(nameof(Items));
                }
            }
        }

        public ObservableCollection<string> Payers
        {
            get { return _payers; }
            set
            {
                if (_payers != value)
                {
                    _payers = value;
                    OnPropertyChanged(nameof(Payers));
                }
            }
        }

        public ObservableCollection<string> ContractingAuthorities
        {
            get { return _contractingAuthorities; }
            set
            {
                if (_contractingAuthorities != value)
                {
                    _contractingAuthorities = value;
                    OnPropertyChanged(nameof(ContractingAuthorities));
                }
            }
        }

        public ObservableCollection<string> AdmissionReasoning
        {
            get { return _admissionReasoning; }
            set
            {
                if (_admissionReasoning != value)
                {
                    _admissionReasoning = value;
                    OnPropertyChanged(nameof(AdmissionReasoning));
                }
            }
        }

        public ObservableCollection<string> Hours
        {
            get { return _hours; }
            set
            {
                if (_hours != value)
                {
                    _hours = value;
                    OnPropertyChanged(nameof(Hours));
                }
            }
        }

        public ObservableCollection<string> Minutes
        {
            get { return _minutes; }
            set
            {
                if (_minutes != value)
                {
                    _minutes = value;
                    OnPropertyChanged(nameof(Minutes));
                }
            }
        }

        private string _patientName = null!;
        public string PatientName
        {
            get
            {
                return _patientName;
            }
            set
            {
                if (_patientName != value)
                {
                    _patientName = value;
                    OnPropertyChanged("PatientName");
                    OnPropertyChanged(nameof(PayerName));
                }
            }
        }

        private string _patientAge = null!;
        public string PatientAge
        {
            get
            {
                return _patientAge;
            }
            set
            {
                if (_patientAge != value)
                {
                    _patientAge = value;
                    OnPropertyChanged("PatientAge");
                    OnPropertyChanged(nameof(AgeWithUnit));
                    OnPropertyChanged(nameof(PayerName));
                }
            }
        }

        public string AgeWithUnit
        {
            get { return $"{PatientAge} L."; }
        }



        private string _pesel = null!;
        public string Pesel
        {
            get
            {
                return _pesel;
            }
            set
            {
                if (_pesel != value)
                {
                    _pesel = value;
                    OnPropertyChanged("Pesel");
                    OnPropertyChanged(nameof(PayerName));
                }
            }
        }

        private string _procedure = "Wizyta poradnia dermatologiczna";
        public string Procedure
        {
            get
            {
                return _procedure;
            }
            set
            {
                if (_procedure != value)
                {
                    _procedure = value;
                    OnPropertyChanged("Procedure");
                }
            }
        }

        private string _priority = null!;
        public string Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                if (_priority != value)
                {
                    _priority = value;
                    OnPropertyChanged("Priority");
                }
            }
        }

        private DateTime _time = DateTime.Now.Date;
        public DateTime Time
        {
            get { return _time; }
            set
            {
                if (_time != value)
                {
                    _time = value;
                    OnPropertyChanged(nameof(Time));
                }
            }
        }

        public string PayerName
        { 
            get { return $"{PatientName}, {Pesel} ({PatientAge} L.)"; }
           
        }
       

        private string _payerExtraNote = null!;
        public string PayerExtraNote
        {
            get
            {
                return _payerExtraNote;
            }
            set
            {
                if (_payerExtraNote != value)
                {
                    _payerExtraNote = value;
                    OnPropertyChanged("PayerExtraNote");
                }
            }
        }

        private DateTime _dateOfIssue = DateTime.Now.Date;
        public DateTime DateOfIssue
        {
            get { return _dateOfIssue; }
            set
            {
                if (_dateOfIssue != value)
                {
                    _dateOfIssue = value;
                    OnPropertyChanged(nameof(DateOfIssue));
                }
            }
        }


        private string _codeICD = null!;
        public string CodeICD
        {
            get
            {
                return _codeICD;
            }
            set
            {
                if (_codeICD != value)
                {
                    _codeICD = value;
                    OnPropertyChanged("CodeICD");
                }
            }
        }

        private string _codeICDName = null!;
        public string CodeICDName
        {
            get
            {
                return _codeICDName;
            }
            set
            {
                if (_codeICDName != value)
                {
                    _codeICDName = value;
                    OnPropertyChanged("CodeICDName");
                }
            }
        }

        private string _nfzContractNr = null!;
        public string NFZContractNr
        {
            get
            {
                return _nfzContractNr;
            }
            set
            {
                if (_nfzContractNr != value)
                {
                    _nfzContractNr = value;
                    OnPropertyChanged("NFZContractNumber");
                }
            }
        }

        public RegisterAppointmentCommand RegisterAppointmentCommand { get; set; }
        public OpenAddNewPatientCommand OpenAddNewPatientCommand { get; set; }
        public CloseRegistrationWindowCommand CloseRegistrationWindowCommand { get; set; }

        public void CloseWindow()
        {
            Registration window = new();
           
        }

        public void OpenWindow()
        {
            AddNewPatient addNewPatient = new();
            addNewPatient.Show();
        }

        public void OnExecute()
        {
            RegistrationModel registration = new()
            {
                PatientName =this.PatientName,
                PatientAge = this.PatientAge,
                Pesel = this.Pesel,
                Procedure = this.Procedure,
                Priority = this.Priority,
                PayerName = this.PayerName,
                PayerExtraNote = this.PayerExtraNote,
                CodeICD = this.CodeICD,
                Time = this.Time
            };
            
        }

    }
}
