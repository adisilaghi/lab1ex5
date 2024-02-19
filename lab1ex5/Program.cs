

/*Se citesc doua numere de la tastatura, x, y. Scrieti un program care va afisa cele
doua valori in ordine crescatoare.
• Exemplu: citim 9,0 Afisam : 0 9 */

Console.WriteLine("Introduceti x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti y");
int y = Convert.ToInt32(Console.ReadLine());
/* x = 9
   y = 0  */

if (x < y)
{
    Console.WriteLine("Ordinea " + x+" "+y);
}
else
{
    Console.WriteLine("Ordinea " + y + " " + x);
}