using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEstudo.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}