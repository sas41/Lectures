using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public interface IPet
    {
        string Name { get; set; }
        string Owner { get; set; }
        float Joy { get; set; }
        void Play();
    }
}
