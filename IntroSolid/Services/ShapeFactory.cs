using IntroSolid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace IntroSolid.SOLID.DependencyInversion
{
    public class ShapeFactory : IShapeFactory
    {
        public IShape GetShape(string name)
        {
            var shapeType = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(t => t.Name.ToLowerInvariant() == name && t.IsClass && !t.IsInterface);

        if (shapeType == null) throw new Exception("No such type");

        return Activator.CreateInstance(shapeType) as IShape;
        }
    }
}
