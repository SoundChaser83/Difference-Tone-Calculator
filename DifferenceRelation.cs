using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Tone_Calculator
{
    internal class DifferenceRelation
    {
        public int Harmonic {  get; set; }
        public int Source {  get; set; }
        public int Difference { get; set; }

        public DifferenceRelation(int harmonic, int source, int difference)
        {
            Harmonic = harmonic;
            Source = source;
            Difference = difference;
        }
    }
}
