﻿namespace Italbytz.Ports.Exam.Networks
{
    public interface IBitencodingSolution
    {
        string[] NRZ { get; set; }
        string[] NRZI { get; set; }
        string[] MLT3 { get; set; }
    }
}