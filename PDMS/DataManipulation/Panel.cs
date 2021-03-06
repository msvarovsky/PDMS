﻿using PDMS.Models;
using System.Collections.Generic;

namespace PDMS.DataManipulation
{
    public class Panel
    {
        public int id { get; set; }
        public string Size { get; set; }
        public string Label { get; set; }
        public List<Field> Content { get; set; }
    }
}