﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HMS_v1._0.Commands
{
    public class AddPatientCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Predicate<object> canExecute;

        public event EventHandler? CanExecuteChanged;

        public AddPatientCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged.Invoke(this,new EventArgs());
        }
        public bool CanExecute(object? parameter) 
        {
            return this.canExecute(parameter); 
        }
        public void Execute(object? parameter)
        {
            this.execute(parameter);
        }
    }
}
