﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    internal class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Code}:{Name}";
        }

    }
}
