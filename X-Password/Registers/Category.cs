using System.Collections.Generic;

namespace X_Password.Registers
{
    public class Category
    {
        public Category(string name) 
            : this(name, new List<Register>()) { }

        public Category(string name, List<Register> registers)
        {
            Name = name;
            Registers = registers;
        }

        public string Name { get; }
        public List<Register> Registers { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
