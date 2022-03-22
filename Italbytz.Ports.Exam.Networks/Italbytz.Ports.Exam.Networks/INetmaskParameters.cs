using System;
namespace Italbytz.Ports.Exam.Networks
{
    public interface INetmaskParameters
    {
        int PrefixLength { get; set; }
        string Address { get; set; }
    }
}
