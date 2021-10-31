using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Overriding
{
  class Program
  {
    static void Main(string[] args)
    {
      Pokemon pok1 = new Pokemon("Pikachu");
      Console.WriteLine(pok1.getName());
      // Output:
      // Pikachu

      Skill pok2 = new Skill("Psyduck", "Water");
      Console.WriteLine(pok2.getName());
      Console.WriteLine(pok2.getAbility());
      // Output:
      // Psyduck
      // Water

      // now start overriding.
      // Output:
      // Raichu
      // Water

      Pokemon pok3 = new Skill("Charmander", "Fire");
      Console.WriteLine(pok3.getName());
      //Console.WriteLine(pok3.getAbility());

      /* Why pok3 can't call getAbility method?
       * Because Pokemon class don't have getAbility method. */

      // Output:
      // Raichu
      Console.ReadLine();
    }
  }
}
