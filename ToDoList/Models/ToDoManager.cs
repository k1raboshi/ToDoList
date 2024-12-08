using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
	public class ToDoManager
	{
		private static ObservableCollection<ToDo> _databaseToDos = new ObservableCollection<ToDo>();

		public static ObservableCollection<ToDo> GetToDos()
		{
			return _databaseToDos;
		}

		public static void AddToDo(ToDo toDo)
		{
			_databaseToDos.Add(toDo);
		}
	}
}
