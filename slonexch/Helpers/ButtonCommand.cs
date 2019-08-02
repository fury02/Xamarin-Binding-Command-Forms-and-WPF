using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace slonexch.Helpers
{
    class ButtonCommand : RelayCommand
    {
        private Action<object> execute;
        private Predicate<object> canExecute;

        public override event EventHandler CanExecuteChanged;

        public ButtonCommand(Action<object> execute) : this(execute, null) { }
        public ButtonCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null) { throw new ArgumentNullException("execute"); }
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public override void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        //Метод, указывающий, может ли команда выполниться в текущем состоянии.
        public override bool CanExecute(object parameter) => true;
        //Метод, вызываемый при вызове данной команды.
        public override void Execute(object parameter) => execute(parameter);
    }
}
