using TicketOfficeAssignment.Classes;

while (true)
{
	Console.Clear();

	Console.WriteLine("Welcome to the Ticket Office!");
	
	Console.WriteLine("Please enter your age: ");
	Console.WriteLine("Please enter seated or standing ticket: ");

	Methods.PriceSetter(int.Parse(Console.ReadLine()), Console.ReadLine().ToLower());
	Methods.TaxCalculator(Methods.price);
	Methods.TicketNumberGenerator();
	Methods.Confirmation(Methods.price, Methods.tax, Methods.ticketNumber);

	Methods.CheckPlaceAvailability(Methods.placeList, Methods.ticketNumber);
	Methods.AddPlace(Methods.ticketNumber);

	Console.WriteLine("Do you want to keep booking tickets: \nQuit = Z");
	
	if (Console.ReadKey().Key == ConsoleKey.Z)
	{
		break;
	}
}
Console.ReadKey();
