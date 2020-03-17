using System;

namespace DevIO.Business.Models
{
    public abstract class Entity
    {
        /// <summary>
        /// Todas as classe que Herdan do Entity já estão configuradas para setar um novo Guid
        /// </summary>
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}
