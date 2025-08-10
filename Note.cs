using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Tone_Calculator
{
    internal class Note
    {
        public int Source {  get; set; }
        public List<int> HarmonicMappings { get; set; } = new List<int>();

        public Note(int source, List<int> harmonicList)
        {
            Source = source;

            foreach (int harmonic in harmonicList)
            {
                HarmonicMappings.Add(Source * harmonic);
            }
        }
    }
}
