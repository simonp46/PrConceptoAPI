using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroSolid.Models
{
    public class Triangle : IShape
    {
        public string Draw()
        {
            return "/\\";
        }
    }
}