using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Customer : IPerson
{
	public int SSN { get; }
	public string FirstName { get; }
	public string LastName { get; }

	public Customer(int sSN, string firstName, string lastName)
		=> (SSN, FirstName, LastName) = (sSN, firstName, lastName);
   
}
