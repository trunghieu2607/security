using System;

namespace security.Models
{
    internal class StringlengthAttribute : Attribute
    {
        private int v;

        public StringlengthAttribute(int v)
        {
            this.v = v;
        }
    }
}