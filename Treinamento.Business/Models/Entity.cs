using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento.Business.Models
{
    public class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
