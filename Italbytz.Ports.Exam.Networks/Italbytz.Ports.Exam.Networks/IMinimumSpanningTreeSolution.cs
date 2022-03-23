using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Exam.Networks
{
    public interface IMinimumSpanningTreeSolution
    {
        IEnumerable<ITagged<string>> Edges { get; set; }
    }
}
