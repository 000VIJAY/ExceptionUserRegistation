using ExeceptionHandlingUserRegistrartion;

Pattern GetPattern = new Pattern();
Console.WriteLine("Enter First Name");
string FN = Console.ReadLine();
GetPattern.ValidateFirstName(FN);

