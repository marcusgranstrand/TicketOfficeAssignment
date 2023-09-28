namespace TestProject
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			string someText = ",";
			int someInt = 152;
			
			string expected = "True";
			string actual = TicketOfficeAssignment.Classes.Methods.CheckPlaceAvailability(someText, someInt).ToString();

			Assert.Equal(expected, actual);
		}
	}
}