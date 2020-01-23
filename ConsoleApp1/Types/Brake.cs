using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Types
{
    public abstract class Brake
    {
        protected Brake() { }

        public abstract void On();

        public abstract void Off();
    }
}
