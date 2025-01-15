using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
	public class ToDo
	{
		private bool _completed;
		public bool Completed { 
			get => _completed;
			set
			{
				if (value != _completed)
				{
					_completed = value;
					ToDoManager.SaveToDo();
				} 
			}
		}
		public string? Title { get; set; }
		public DateTime? Date { get; set; }
		
		public ToDo() 
		{
			//Completed = false;
			Date = DateTime.Now;
		}
	}
}
