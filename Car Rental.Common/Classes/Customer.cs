using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Customer : IPerson
{
	public string SSN { get; }
	public string FirstName { get; }
	public string LastName { get; }

	public Customer(string sSN, string firstName, string lastName)
		=> (SSN, FirstName, LastName) = (sSN, firstName, lastName);
   
}
