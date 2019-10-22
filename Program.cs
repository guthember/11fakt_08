using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szellemek
{
  class Program
  {
    static void Main(string[] args)
    {
      // 3 db ajtó
      // életerő 50
      // feladat: választunk az ajtók közül
      // 1 ajtó mögött szellem van (véletlenszerű)
      // ha szerencsénk van tovább
      // ha nincs -10 életerő
      // ha 0 az életerő --> GAME OVER
      // ? hány szobán jutottunk keresztül
      int eletero = 50;
      int szobakSzama = 0;
      int valasztas;
      Random vel = new Random();
      int ajto;


      while (eletero > 0)
      {
        Console.WriteLine("Válassz az ajtók közül!");
        Console.WriteLine("1 - 2 - 3");

        // ember választ
        Console.Write("Válasz: ");
        valasztas = Convert.ToInt32(Console.ReadLine());

        // gép választ ahol a szellem van
        ajto = vel.Next(1, 4);

        if (valasztas == ajto)
        {
          eletero -= 10;
          Console.WriteLine("Whoooaaaa...");
        }
        else
        {
          szobakSzama++;
        }

      }
      Console.WriteLine(szobakSzama + " szobán jutottál át!");
      Console.ReadKey();

    }
  }
}
