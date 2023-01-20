namespace C_Sharp_Project.Components
{
	public partial class Numbers
	{
		public int MyNumbers { get; set; }
		
		public void ChosenNumber(int number)
		{
			Console.WriteLine("The chosen number is: " + number);
		}
	}
}


