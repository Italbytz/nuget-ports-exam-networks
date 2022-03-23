using System;
namespace Italbytz.Ports.Exam.Networks
{
    public interface IShortestPathsParameters
    {
        IUndirectedGraph<string, ITaggedEdge<string, double>> Graph { get; set; }
        String[] Vertices { get; set; }
    }
}
