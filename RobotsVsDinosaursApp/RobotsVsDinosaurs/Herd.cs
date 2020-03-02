using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        public Dinosaur tRex;
        public Dinosaur pterodactyl;
        public Dinosaur stegosaurus;
        public Herd()
        {
            tRex = new Dinosaur("T-rex");
            pterodactyl = new Dinosaur("Pterodactyl");
            stegosaurus = new Dinosaur("stegosaurus");

        }

        public void DisplayDinosaurs(List<Dinosaur> dinosaurs)
        {
            foreach (Dinosaur dinosaur in dinosaurs)
            {
                dinosaur.DisplayDinosaur();
            }
        }
    }
}
