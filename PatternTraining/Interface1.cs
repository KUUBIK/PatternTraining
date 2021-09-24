using System;
using System.Collections.Generic;
using System.Text;

namespace PatternTraining
{
    interface IStrategy
    {
        public int SomeData { get; set; }

        void Algorithm();

        virtual string Test()
        {
            return "1";
        }
    }
}
