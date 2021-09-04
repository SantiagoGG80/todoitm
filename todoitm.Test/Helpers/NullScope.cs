﻿using System;
using System.Collections.Generic;
using System.Text;

namespace todoitm.Test.Helpers
{
    public class NullScope : IDisposable
    {
        public static NullScope Instance { get; set; } = new NullScope();
        
        public void Dispose() { }

        private NullScope() { }
    }
}
