﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFramework.FMySQL
{
    public class DatabaseTable : Attribute
    {
        public string Name
        {
            get;
            private set;
        }

        public DatabaseTable(string name)
        {
            Name = name;
        }
    }
}