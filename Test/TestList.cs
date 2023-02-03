using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
		public class UnitTest1
		{
			public class ListItem
			{
				//som har två properties 
				public int MyNumbers { get; set; }
				public bool IsSelected { get; set; }
			}

			[Fact]
			public void TestaLista()
			{
				//Arrange
				var chooseNumbers = Enumerable.Range(1, 70).Select(i => new ListItem { MyNumbers = i }).ToList();
				chooseNumbers[0].IsSelected = true;
				chooseNumbers[5].IsSelected = true;
				var expectedNumbers = new List<int> { 1, 6 };
				var actualNumbers = new List<int>();

				//Act
				foreach (var number in chooseNumbers.Where(n => n.IsSelected))
				{
					actualNumbers.Add(number.MyNumbers);
				}

				//Assert
				Assert.Equal(expectedNumbers, actualNumbers);
			}
		}
}

