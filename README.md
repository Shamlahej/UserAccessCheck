# Har brugt Console.writeline som vist i undervisning til at få programmet til at forespørge om Username, Password og også UserID. string betyder at vores variabel er "tekst". Vi bruger nu Console.Readline, for at få programmet til at læse og gemme input under username. Vi gør det samme for Password og UserID. Ved UserId er forskellen at vi nu bruger uint.parse, til at omskrive til et heltal som kun er positivt. 

Console.Write("Indtast Username:");
string username = Console.ReadLine();

Console.Write("Indtast Password:");
string password = Console.ReadLine();

Console.Write("Indtast UserID: ");
uint UserID = uint.Parse(Console.ReadLine());

# Første bool er for at tjekke betingelsen om User er Admin eller ikke. Hvis UserID er større end 65536, så er brugeren en Admin. 
# Anden bool er for at tjekke om Username er valid. Username.length giver antal tegn i navnet, og her siger vi at hvis længden er mindst 3 er Username valid, ellers er det invalid. 

//Boolean betingelser:
bool userIsAdmin = UserID > 65536;
bool UsernameValid = username.Length >= 3;

# Nu skal vi kode betingelsen for længdekrav for Password for normal User og Admin. Vi laver variablen int RequiredLenght, som er i heltal. Her siger vi så at hvis brugeren er Admin så skal koden være mindst 20 tegn og ellers (normal bruger) skal koden være mindst 16 tegn.

//Længdekrav for Admin eller bare normal user.
int requiredLength;
if (userIsAdmin)
    requiredLength = 20;  
else
    requiredLength = 16; 

# Nu laver vi Bool for at password er valid, hvilket vi gør ved at sige at password skal opfylde betingelsen om at indeholde mindst et af specialtegnene ($,[ eller @). Her bruger vi password.contains(tegn) for at checke om tegnet findes i password. vi bruger ||, som er (or) fordi betingelsen er at ét af tegnene skal bruges. Så tilføjer vi også vores betingelse vi lavede før for required length på password. vi bruger && (and) fordi begge krav SKAL opfyldes. 

bool PasswordValid =
    (password.Contains('$') || password.Contains('[') || password.Contains('@')) &&
    (password.Length >= requiredLength);

if (UsernameValid && PasswordValid)
{string role = userIsAdmin ? "Admin" : "User"; Console.WriteLine("Login successfull - " + role); }

# Her bruger vi else til at sige at hvis Username ikke (!) er valid så skal konsollen skrive "Username is invalid (need min. 3 characters).", og hvis password ikke (!) er valid så printes "Password is invalid (Must contain $, [ or @ and be long enough). Her bruger vi også Console.Writeline som tidligere. 

else

{ 
    if (!UsernameValid) Console.WriteLine("Username is invalid (Need min. 3 characters).");
    if (!PasswordValid) Console.WriteLine("Password is invalid(Must contain $, [ or @ and be long enough).");}
