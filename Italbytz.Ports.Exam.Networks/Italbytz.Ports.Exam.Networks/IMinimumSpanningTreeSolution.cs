using System;
using System.Collections.Generic;
using Italbytz.Ports.Graph;

namespace Italbytz.Ports.Exam.Networks
{
    public interface IMinimumSpanningTreeSolution
    {
        IEnumerable<ITaggedEdge<string, double>> Edges { get; set; }
    }
}
