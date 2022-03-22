using System;
using System.Net;

namespace Italbytz.Ports.Exam.Networks
{
    public interface INetmaskSolution
    {
        IPAddress NetworkAddress { get; set; }
        IPAddress HostAddress { get; set; }
    }
}
