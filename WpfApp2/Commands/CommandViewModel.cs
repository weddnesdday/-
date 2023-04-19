﻿using System;
using System.Windows.Input;

namespace WpfApp2.Commands
{
    public class CommandViewModel : ICommand
    {
        private readonly Action _action;
        public CommandViewModel(Action action)
        {
            _action = action;
        }

        public void Execute(object o)
        {
            _action();
        }

        public bool CanExecute(object o)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { }
            remove { }
        }
    }
}
