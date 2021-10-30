﻿namespace WebListContato.Domain.Entities
{
    public abstract class BaseEntity<TKeyType>
    {
        protected BaseEntity(TKeyType id = default)
        {
            Id = id;
        }
        public virtual TKeyType Id { get; set; }
    }
}
