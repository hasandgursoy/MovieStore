﻿using MovieStore.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Repository.Seeds
{
    public interface IEntityTypeConfiguration<T> where T : BaseEntity
    {
    }
}
