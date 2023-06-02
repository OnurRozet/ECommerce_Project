using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.BaseEntities
{
	public class AuditableEntity : BaseEntity, ICreatedEntity, IUpdateEntity
	{
		public int CreatedUserId { get; set; }
		public DateTime CreatedDate { get; set; }
		public int? UpdatedUserId { get; set; }
		public DateTime? UpdateDate { get; set; }
		
	}
}
