﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Virgo.Dapper
{
    public class DbConfiguration
    {
        public string ConnectionString { get; set; }
        public int? CommandTimeout { get; set; }
    }
}