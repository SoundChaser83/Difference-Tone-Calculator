using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Tone_Calculator
{
    internal class DifferenceRelation
    {
        public Note From {  get; set; }
        public Note To { get; set; }
        public int Difference { get; set; }

        public DifferenceRelation(Note from, Note to, int difference)
        {
            From = from;
            To = to;
            Difference = difference;
        }
    }
}
