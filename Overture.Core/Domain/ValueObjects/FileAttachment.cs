﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Overture.Core.Domain.ValueObjects
{
    public class FileAttachment
    {
		public string FileReference { get; set; }
		public string FileName { get; set; }
		public string FileType { get; set; }
		public int FileSize { get; set;  }
    }
}
