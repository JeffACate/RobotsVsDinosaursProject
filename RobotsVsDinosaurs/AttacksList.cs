using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class AttacksList
    {
        public Attack bite;
        public Attack kick;
        public Attack scratch;
        public AttacksList()
        {
            bite = new Attack("bite", 10);
            kick = new Attack("kick", 15);
            scratch = new Attack("scratch", 15);
        }
    }
}
