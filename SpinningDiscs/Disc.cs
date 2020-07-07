using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class Disc
    {
        public string Name { get; set; }
        public double maxStorage { get; set; }

        protected Disc(string name, double maxStorage)
        {
            Name = name;
            this.maxStorage = maxStorage;
        }

        public abstract string Report();
    }
}
