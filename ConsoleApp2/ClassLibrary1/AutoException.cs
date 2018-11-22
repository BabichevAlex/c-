using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class AutoException : Exception
    {
        public AutoException(string message) : base(message) { }
    }

    class InvalidPriceException : AutoException
    {
        public InvalidPriceException() : base("Авто даной ценовой категории нет в наличии") { }
    }
    class InvalidhaswarrantyException : AutoException
    {
        public InvalidhaswarrantyException() : base("Авто не имеет гарантии") { }
    }
}
