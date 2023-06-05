// See https://aka.ms/new-console-template for more information

using Bilforhandler;

Console.WriteLine("Hello, World!");
var forhandler = new Forhandler("Bilforhandler A", "Adresse A");

while (true)
{
    Console.WriteLine("Velg ett tall!:");
    Console.WriteLine("1. Legg til Biler");
    Console.WriteLine("2. Hvis liste av alle bilene");
    Console.WriteLine("3. Se gamle Biler");
    Console.WriteLine("4. Fjern bil med RegNummer");
    Console.WriteLine("5. Avslutt");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Skriv inn Bil Merke:");
            string brand = Console.ReadLine();

            Console.WriteLine("Skriv regNummer:");
            string regNum = Console.ReadLine();

            Console.WriteLine("Skriv året av produksjon:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Kilometer gått:");
            int km = int.Parse(Console.ReadLine());

            forhandler.LeggTilBil(new Bil(brand, regNum, year, km));
            break;
        case "2":
            foreach (var bil in forhandler.Biler)
            {
                Console.WriteLine($"{bil.Merke}, {bil.Regnummer}, {bil.Year}, {bil.Kilometers}");
            }
            break;
        case "3":
            Console.WriteLine("Skriv antall år:");
            int age = int.Parse(Console.ReadLine());
            List<Bil> gamleBiler = forhandler.HentGamleBiler(age);
            foreach (var bil in gamleBiler)
            {
                Console.WriteLine($"{bil.Merke}, {bil.Regnummer}, {bil.Year}, {bil.Kilometers}");
            }
            break;
        case "4":
            Console.WriteLine("Skriv RegNummer på bil du vil fjerne!:");
            string regNumToRemove = Console.ReadLine();
            forhandler.RemoveBil(regNumToRemove);
            break;
        case "5":
            return;  
        default:
            Console.WriteLine("Du skrev feil, prøv på nytt!.");
            break;
    }
}