﻿using Microsoft.VisualBasic;
using System;

namespace LoggingKata
{
    public interface ITrackable
    {
        string Name { get; set; }
        Point Location { get; set; }

       
    }
}