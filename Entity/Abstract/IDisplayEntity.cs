﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Abstract
{
	public interface IDisplayEntity
	{
		int DisplayOrder { get; set; }
		bool IsDisplay { get; set; }
	}
}
