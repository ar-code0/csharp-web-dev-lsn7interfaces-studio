using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : Disc, Interface
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
        private List<Dictionary<string, double>> Content { get; set; } // list of {videoTitle, size}

        public DVD(string Name, double MaxStorage, List<Dictionary<string, double>> content) : base(Name, MaxStorage) 
        {
            Content = content;
        }

        public double LeftStorage()
        {
            double used = 0;
            foreach (Dictionary<string, double> item in Content)
            {
                foreach (KeyValuePair<string, double> unit in item)
                {
                    used += unit.Value;
                }
            }
            return maxStorage - used;
        }

        public override string Report()
        {
            string result = " The DVD features these videos ";
            foreach (Dictionary<string, double> item in Content)
            {
                foreach (KeyValuePair<string, double> unit in item)
                {
                    result += unit.Key + ", ";
                }
            }
            return result.Remove(result.Length - 1, 2) + ".";
        }
    }
}
