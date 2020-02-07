using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            BattleField battleField = new BattleField();
            Console.WriteLine("Battlefield initialized");
            battleField.Battle();
        }
    }
}
