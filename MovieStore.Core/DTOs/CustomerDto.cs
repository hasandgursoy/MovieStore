﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Core.DTOs
{
    public class CustomerDto : BaseDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
