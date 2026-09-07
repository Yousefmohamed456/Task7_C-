using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Parent(int x, int y) { X = x; Y = y; }
        public virtual int Product() { return X * Y; }
        public override string ToString() { return $"({X}, {Y})"; }
    }
    internal class Child : Parent { 
        public int Z { get; set; } 
        public Child(int x, int y, int z) : base(x, y) { Z = z; }
        public override string ToString() { return $"({X}, {Y}, {Z})"; }
    }
    internal class ChildNew : Parent { 
        public int Z { get; set; } 
        public ChildNew(int x, int y, int z) : base(x, y) { Z = z; } 
        public new int Product() { return X * Y * Z; } 
    }  
    internal class ChildOverride : Parent { 
        public int Z { get; set; } 
        public ChildOverride(int x, int y, int z) : base(x, y) { Z = z; }
        public override int Product() { return X * Y * Z; }
    }
}
