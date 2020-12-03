using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class Motorcycle
    {
        internal const ushort _maxSpeed = 300;
        readonly string _vinNumber = "jfjfjfjfjfjjfjf_jjfjfj";
        string _vinNumber1 = "jfjfjfjfjfjjfjf_jjfjfj";
        internal int _odometr = 20_000;
        protected internal int _odometr1 = 10_000;
        protected int _odometr2 = 10_000;
        private protected int _odometr3 = 10_000;
        internal int _speed;
        
        public Motorcycle()
            {
            }

        public int Odometr { get; private set; }

        private void StartEngine()
        {
            Odometr = 25;
            int number1 = _odometr1;
            int number2 = _odometr2;
            int number3 = _odometr3;
            StartEngine1();
        }

        public void StartEngine1()
        {
            _odometr = 80;
            StartEngine2();
        }

        internal void StartEngine2()
        {
            string vin = _vinNumber;
            string vin2 = _vinNumber1;
        }

        protected void StartProtected()
        {
        }
        private protected void StartProtectedPrivate()
        {
        }
    }
}
