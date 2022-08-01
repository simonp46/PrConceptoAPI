using IntroSolid.Models;
using IntroSolid.SOLID.DependencyInversion;
using IntroSolid.SOLID.InterfaceSegregation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;


namespace IntroSolid.Services
{
    public class ShapeTranslator
    {
        public ShapeResolver ResolveShape(string name)
        {
            var shape = new ShapeFactory().GetShape(name);

            return new ShapeResolver(shape);
        }

        public class ShapeResolver
        {
            private readonly IShape _shape;

            public ShapeResolver(IShape shape)
            {
                _shape = shape;
            }

            public string Draw() => _shape.Draw();
         }
    }
}