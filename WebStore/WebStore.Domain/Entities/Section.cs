﻿using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;

namespace WebStore.Domain.Entities
{
    public class Section : OrderedEntity
    {
        public int? ParentId { get; set; }
    }
}
