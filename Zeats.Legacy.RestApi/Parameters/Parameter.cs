using System;

namespace Zeats.Legacy.RestApi.Parameters
{
    public class Parameter
    {
        public Parameter()
        {
        }

        public Parameter(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public Parameter(string name, Enum value)
        {
            Name = name;
            Value = value.ToString();
        }

        public Parameter(string name, int value)
        {
            Name = name;
            Value = value.ToString();
        }

        public Parameter(string name, Guid value)
        {
            Name = name;
            Value = value.ToString();
        }

        public string Name { get; set; }
        public string Value { get; set; }
    }
}