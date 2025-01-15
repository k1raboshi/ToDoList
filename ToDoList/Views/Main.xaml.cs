using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoList.Models;
using ToDoList.ViewModel;


namespace ToDoList.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class Main : Window
	{
		
		public Main()
		{
			InitializeComponent();
			MainViewModel mainViewModel = new MainViewModel();
			this.DataContext = mainViewModel;
		}

		private void TextBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
		{
			ToDoManager.SaveToDo();
		}
	}
}