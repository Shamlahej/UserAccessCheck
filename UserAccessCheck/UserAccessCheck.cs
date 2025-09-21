Console.Write("Indtast Username:");
string username = Console.ReadLine();

Console.Write("Indtast Password:");
string password = Console.ReadLine();

Console.Write("Indtast UserID: ");
uint UserID = uint.Parse(Console.ReadLine());

//Bool for vores betingelser
bool userIsAdmin = UserID > 65536;
bool UsernameValid = username.Length >= 3;

//Længdekrav for Admin eller bare normal user.
int requiredLength;
if (userIsAdmin)
    requiredLength = 20;  
else
    requiredLength = 16; 

bool PasswordValid =
    (password.Contains('$') || password.Contains('[') || password.Contains('@')) &&
    (password.Length >= requiredLength);

if (UsernameValid && PasswordValid)
{string role = userIsAdmin ? "Admin" : "User"; Console.WriteLine("Login successfull - " + role); }

else

{ 
    if (!UsernameValid) Console.WriteLine("Username is invalid (Need min. 3 characters).");
    if (!PasswordValid) Console.WriteLine("Password is invalid(Must contain $, [ or @ and be long enough).");}

