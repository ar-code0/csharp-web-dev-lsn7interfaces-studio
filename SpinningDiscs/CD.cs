using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SpinningDiscs
{
    public class CD : Disc, Interface
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 
        private List<List<string>> Content { get; set; } //title, artist, album, size

        public CD(string Name, double MaxStorage, List<List<string>> content) : base(Name, MaxStorage)
        {
            Content = content;
        }

        public double LeftStorage()
        {
            double used = 0;
            foreach(List<string> item in Content)
            {
                used += int.Parse(item[3]);
            }
            return maxStorage - used;
        }

        public override string Report()
        {
            string result = " The CD features these titles ";
            foreach (List<string> item in Content)
            {
                for (int i =0; i<item.Count; i++) 
                {
                    result += item[0] + ", ";
                }
            }
            return result.Remove(result.Length - 1, 2) + ".";
        }
    }
}
