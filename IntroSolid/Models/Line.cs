using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroSolid.Models
{
    public class Line : IShape
    {
        public string Draw()
        {
            return "_";
        }
    }
}