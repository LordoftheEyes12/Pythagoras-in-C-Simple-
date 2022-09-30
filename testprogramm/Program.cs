Console.WriteLine("Geben Sie H ein, wenn sie Eine Hypothenuse Berechnen müssen und K, wenn sie eine Kathete Berechen Müssen");
string Eingabe = Console.ReadLine();
if (Eingabe == "H" ^ Eingabe == "h")
{
    Console.WriteLine("Geben Sie Eine Zahl ein");
    string z = Console.ReadLine();
    Console.WriteLine("Geben Sie Eine Zahl ein");
    string y = Console.ReadLine();
    double a = Convert.ToDouble(z);
    double b = Convert.ToDouble(y);
    double c = Math.Pow(a, 2) + Math.Pow(b, 2);
    c = Math.Sqrt(c);
    Console.WriteLine("Die Hypothenuse eines Rechtwinkelingen Dreiecks mit den Kathethen " + a + " & " + b + " ist " + c);
}

if (Eingabe == "K" ^ Eingabe == "k") ;
{
    Console.WriteLine("Geben Sie Die Hypothenuse ein");
    string q = Console.ReadLine();
    Console.WriteLine("Geben Sie die zweite Kathete ein");
    string p = Console.ReadLine();
    double r = Convert.ToDouble(q);
    double s = Convert.ToDouble(p);
    double t = Math.Pow(r, 2) - Math.Pow(s, 2);
    t = Math.Sqrt(t);
    t = Math.Round(t);
    Console.WriteLine("Die zweite Kathete eines Rechtwinkeligen Dreiecks mit der Hypothenuse " + r + " und der Kathete " + s + " ist " + t);
}
