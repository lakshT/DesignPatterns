using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern.Interfaces
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
