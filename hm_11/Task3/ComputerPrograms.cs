using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class ComputerPrograms : Store
    {
        ComputerPrograms[] _computerPrograms = new ComputerPrograms[5];
        int _count;

        public void AddComputerPrograms (ComputerPrograms computerPrograms)
        {
            if (_count >= 5) return;
            _computerPrograms[_count] = computerPrograms;
            _count++;
        }

        public ComputerPrograms[] GetComputerPrograms()
        {
            return _computerPrograms;
        }
    }
}
