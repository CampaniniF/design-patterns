using System.Collections.Generic;

namespace Strategy.Algorithms
{
    public interface IGreeter
    {
        IEnumerable<string> Execute(IEnumerable<string> inputList);
    }
}