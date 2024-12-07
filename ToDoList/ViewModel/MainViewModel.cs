using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoList.Commands;
using ToDoList.Models;
using ToDoList.Views;

namespace ToDoList.ViewModel
{
	public class MainViewModel
	{
		public ObservableCollection<ToDo> ToDos { get; set; }

		public ICommand ShowWindowCommand { get; set; }

		public MainViewModel() 
		{
			ToDos = ToDoManager.GetToDos();
			ShowWindowCommand = new RelayCommand(ShowWindow, CanShowWindow);
		}

		public bool CanShowWindow(object obj) 
		{
			return true;
		}

		public void ShowWindow(object obj)
		{
			AddToDo addToDoWin = new AddToDo();
			addToDoWin.Show();
		}
	}
}
