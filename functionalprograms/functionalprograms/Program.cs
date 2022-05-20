// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("1.flip coin\n2.leap year\n3.power of two\n4.harmonic number\n5.Prime Factors\n6.quotient and remainder\n7.Swapp two numbers\n8.even or odd\n9.vowel or consonant\n10.largest number.\n");
Console.WriteLine("Enter Your Choice:");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        functionalprograms.flipcoin function = new functionalprograms.flipcoin();
        function.Coinflip();
        break;
    case 2:
        functionalprograms.leapyear year = new functionalprograms.leapyear();
        year.leap();
        break;
    case 3:
        functionalprograms.power power = new functionalprograms.power();
        power.powerOfTwo();
        break;
    case 4:
        functionalprograms.harmonic harmonic = new functionalprograms.harmonic();
        harmonic.Main();
        break;
    case 5:
        functionalprograms.primefactor prime = new functionalprograms.primefactor();
        prime.pfactor();
        break;
    case 6:
        functionalprograms.quotientandremainder cal = new functionalprograms.quotientandremainder();
        cal.Main();
        break;
    case 7:
        functionalprograms.swapptwonumberscs se = new functionalprograms.swapptwonumberscs();
        se.swap();
        break;
    case 8:
        functionalprograms.evenorodd eo = new functionalprograms.evenorodd();
        eo.even();
        break;
    case 9:
        functionalprograms.vowelorconsonent alphabet = new functionalprograms.vowelorconsonent();
        alphabet.vowel();
        break;
    case 10:
        functionalprograms.largestnumber value = new functionalprograms.largestnumber();
        value.largest();
        break;
    default:
        Console.WriteLine("Enter valid Option.");
        break;
}