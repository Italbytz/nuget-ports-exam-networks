using System;
namespace Italbytz.Ports.Exam.Networks
{
    public interface ITaggedEdge<TVertex, TTag> : IEdge<TVertex>, ITagged<TTag>
    {
    }
}
