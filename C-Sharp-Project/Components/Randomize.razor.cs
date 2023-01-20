namespace C_Sharp_Project.Components
{
    //partial för att kunna deklarera samma klass i olika klasser
    public partial class Randomize
    {
        public int MyRandom { get; set; }

        public void GenerateRandomNumbers()
        {
            Random rnd = new();
            MyRandom = rnd.Next(0, 10);
        }
    }

}