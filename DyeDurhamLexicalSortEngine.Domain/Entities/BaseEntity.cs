using DyeDurhamLexicalSortEngine.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DyeDurhamLexicalSortEngine.Domain.Entities
{
    // ientity maybe not useful here but use later in Di to inject base entity or using in reflection for specfic type of data 
    public abstract class BaseEntity : IEntity
    {

        #region Ctor
        public BaseEntity()
        {
            Id = new Guid();
        }
        #endregion
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
