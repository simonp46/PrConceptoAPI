using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroSolid.Models
{
    public class Circle : IShape
    {
        public string Draw()
        {
            return "o";
        }
    }
}
