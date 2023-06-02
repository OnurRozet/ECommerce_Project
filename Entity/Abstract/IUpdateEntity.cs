using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Abstract
{
	public interface IUpdateEntity
	{
		int? UpdatedUserId { get; set; }
		DateTime? UpdateDate { get; set; }
	}
}
