using System.ComponentModel;

namespace C_Sharp_Project.Components
{

	public partial class Numbers
	{
		
		//en klass som heter ListItem
		public class ListItem
		{
			//som har två properties 
			public int MyNumbers { get; set; }
			public bool IsSelected { get; set; }
			

		}
		/*
		//partial för att kunna deklarera samma klass i olika klasser
		public partial class Randomize
		{
			public int MyRandom { get; set; }

		}
		*/
	}
}

