namespace Test
{
	public class TestWins
	{
		int[][] winArray = new int[][]	//Simulerar vinstplan från riktigt keno
		{
			new int[] { 10 },
			new int[] { 170 },
			new int[] { 0, 30 },
			new int[] { 40, 240 },
			new int[] { 0, 5, 60 },
			new int[] { 25, 50, 400 },
			new int[] { 0, 5, 10, 120 },
			new int[] { 30, 30, 60, 800 },
			new int[] { 0, 0, 5, 40, 800 },
			new int[] { 30, 15, 30, 150, 2500 },
			new int[] { 0, 0, 5, 15, 90, 1700 },
			new int[] { 30, 10, 15, 50, 300, 10000 },
			new int[] { 0, 0, 0, 5, 50, 400, 10000 },
			new int[] { 30, 10, 10, 30, 150, 1000, 25000 },
			new int[] { 0, 0, 0, 5, 15, 100, 1000, 45000 },
			new int[] { 30, 10, 10, 15, 30, 300, 2000, 130000 },
			new int[] { 0, 0, 0, 0, 5, 50, 250, 5000, 250000 },
			new int[] { 15, 10, 10, 10, 15, 100, 500, 10000, 600000 },
			new int[] { 0, 0, 0, 0, 5, 15, 100, 800, 15000, 1000000 },
			new int[] { 30, 10, 10, 10, 15, 50, 200, 1600, 30000, 2000000 },
			new int[] { 0, 0, 0, 0, 5, 10, 30, 200, 2000, 80000, 5000000 },
			new int[] { 30, 10, 10, 10, 15, 15, 100, 500, 4000, 160000, 20000000 }
		};

		public int CalculateWin(int pairs, bool hasKingKeno, int count)
		{
			if (pairs > 0)
			{
				if (hasKingKeno)
				{
					Console.WriteLine("Money + " + winArray[count * 2 - 1][pairs - 1]);
					return winArray[count * 2 - 1][pairs - 1];
				}
				else
				{
					Console.WriteLine("Money + " + winArray[count * 2 - 2][pairs - 1]);
					return winArray[count * 2 - 2][pairs - 1];
				}
			}
			else
				return 0;
		}


		[Theory]    // Testar vinstuträkningen (spelnivå, antal rätt, om spelaren har kung keno, förväntad vinst)
		[InlineData(1, 1, false, 10)]
		[InlineData(1, 1, true, 170)]
		[InlineData(1, 0, false, 0)]
		[InlineData(2, 0, false, 0)]
		[InlineData(2, 1, true, 40)]
		[InlineData(2, 2, true, 240)]
		[InlineData(2, 1, false, 0)]
		[InlineData(2, 2, false, 30)]
		[InlineData(6, 3, false, 5)]
		[InlineData(6, 3, true, 15)]
		[InlineData(11, 7, true, 100)]
		[InlineData(11, 7, false, 30)]
		[InlineData(11, 11, false, 5000000)]
		[InlineData(11, 11, true, 20000000)]
		public void Test(int count, int pairs, bool hasKingKeno, int expected)
		{
			Assert.Equal(expected, CalculateWin(pairs, hasKingKeno, count));
		}
	}
}