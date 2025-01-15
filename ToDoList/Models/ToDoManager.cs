using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ToDoList.Models
{
	public class ToDoManager
	{
		private static ObservableCollection<ToDo> _databaseToDos = new ObservableCollection<ToDo>();
		private static readonly string PATH = "test.txt";
		private static bool readerIsOpen = false;
		public static ObservableCollection<ToDo> GetToDos()
		{
			var fileExists = File.Exists(PATH);
			if (!fileExists)
			{
				File.CreateText(PATH).Dispose();
				return _databaseToDos;
			}
			using (var reader = File.OpenText(PATH))
			{
				readerIsOpen = true;
				var fileText = reader.ReadToEnd();
				_databaseToDos = JsonSerializer.Deserialize<ObservableCollection<ToDo>>(fileText);
			}
			readerIsOpen = false;
			return _databaseToDos;
		}

		public static void AddToDo(ToDo toDo)
		{
			_databaseToDos.Add(toDo);
			SaveToDo();
		}

		public static void RemoveToDo(ToDo toDo)
		{
			_databaseToDos.Remove(toDo);
			SaveToDo();
		}

		public static void SaveToDo()
		{
			if (readerIsOpen) return;
			using (StreamWriter writer = File.CreateText(PATH))
			{
				string output = JsonSerializer.Serialize(_databaseToDos);
				writer.Write(output);
			}
		}
	}
}
