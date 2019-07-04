using Strategy.Algorithms;
using System;
using System.Collections.Generic;

namespace Strategy
{
	public class Client
	{
        private IGreeter _formatter;
        public Client (IGreeter formatter)
		{
            this._formatter = formatter;
		}

		public IEnumerable<string> ProcessNames(IEnumerable<string> names) 
		{
			return _formatter.Execute (names);
		}
	}
}
	