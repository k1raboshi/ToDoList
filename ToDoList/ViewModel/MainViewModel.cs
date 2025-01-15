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

		public string? Title { get; set; }

		public ICommand AddToDoCommand { get; set; }
		public ICommand RemoveToDoCommand { get; set; }
		public MainViewModel() 
		{
			ToDos = ToDoManager.GetToDos();
			AddToDoCommand = new RelayCommand(AddToDo, CanAddToDo);
			RemoveToDoCommand = new RelayCommand(RemoveToDo, CanRemoveToDo);
		}

		public bool CanAddToDo(object obj) 
		{
			return true;
		}

		public void AddToDo(object obj)
		{
			ToDoManager.AddToDo(new ToDo() { Title = Title});
		}

		public bool CanRemoveToDo(object obj)
		{
			return obj is ToDo;
		}

		public void RemoveToDo(object obj)
		{
			var toDo = obj as ToDo;
			if (toDo != null)
			{
				ToDoManager.RemoveToDo(toDo);
			}
		}
	}
}