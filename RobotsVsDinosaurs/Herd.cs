using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public List<Dinosaur> herdDinosaurs = new List<Dinosaur>();
        
        public Herd()
        {
            Dinosaur tRex = new Dinosaur("T-rex");
            Dinosaur pterodactyl = new Dinosaur("Pterodactyl");
            Dinosaur stegosaurus = new Dinosaur("stegosaurus");
            herdDinosaurs.Add(tRex);
            herdDinosaurs.Add(pterodactyl);
            herdDinosaurs.Add(stegosaurus);

        }

        public void DisplayDinosaurs()
        {
            foreach (Dinosaur dinosour in herdDinosaurs)
            {
                dinosour.DisplayDinosour();
            }
        }
    }
}
