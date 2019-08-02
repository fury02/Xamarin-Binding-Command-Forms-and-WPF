using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;

namespace slonexch.Helpers
{
    public abstract class RelayCommand : ICommand
    {
        public abstract event EventHandler CanExecuteChanged;
        public abstract void RaiseCanExecuteChanged();
        public abstract bool CanExecute(object parameter);
        public abstract void Execute(object parameter);
    }
}
