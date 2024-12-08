using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
	public class ToDo
	{
		public bool Completed { get; set; }
		public string? Title { get; set; }
		public DateTime? Date { get; set; }
		
		public ToDo() 
		{
			Completed = false;
			Date = DateTime.Now;
		}
	}
}
