﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIOFile
{
    [Serializable]
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
