﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoList.Commands
{
	public class RelayCommand : ICommand
	{
		public event EventHandler? CanExecuteChanged;

		private Action<object> _execute { get; set; }
		private Predicate<object> _canExecute { get; set; }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute1)
        {
            _execute = execute;
			_canExecute = canExecute1;
        }

        public bool CanExecute(object? parameter)
		{
			return _canExecute(parameter);
		}

		public void Execute(object? parameter)
		{
			_execute(parameter);
		}
	}
}
