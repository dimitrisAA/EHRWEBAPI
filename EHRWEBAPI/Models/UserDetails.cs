﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EHRWEBAPI.Models
{
    public class UserDetails
    {
        public Nullable<int> PersonID { get; set; }
        public bool IsDoctor { get; set; }
    }
}