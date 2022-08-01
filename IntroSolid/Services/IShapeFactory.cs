using IntroSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace IntroSolid.SOLID.DependencyInversion
{
    public interface IShapeFactory
    {
        IShape GetShape(string name);
    }
}
