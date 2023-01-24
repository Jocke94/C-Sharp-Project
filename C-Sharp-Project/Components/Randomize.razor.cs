namespace C_Sharp_Project.Components
{
    //partial för att kunna deklarera samma klass i olika klasser
    public partial class Randomize
    {
        public int MyRandom { get; set; }
        List<int> randomNumbers = new List<int>();
        public void GenerateRandomNumbers()
        {
           randomNumbers.Clear();
            Random rnd = new Random();
            Console.WriteLine("Kenos lottonummer är: ");
         
            while(randomNumbers.Count < 20) 
            {
                MyRandom = rnd.Next(1,71);
                if (!randomNumbers.Contains(MyRandom))
                    randomNumbers.Add(MyRandom);
			}	
                Console.WriteLine( String.Join(", ", randomNumbers));

           
        }
    }

}