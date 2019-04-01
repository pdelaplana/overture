﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Overture.Core.Domain.Entities
{
    public class BusinessService : IEntity
    {
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string CategoryName { get; set; }
    }
}
