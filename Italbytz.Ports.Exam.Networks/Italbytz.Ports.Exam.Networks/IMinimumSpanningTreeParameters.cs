using System;
namespace Italbytz.Ports.Exam.Networks
{
    public interface IMinimumSpanningTreeParameters
    {
        IUndirectedGraph<string, ITaggedEdge<string,double>> Graph { get; set; }
    }
}
