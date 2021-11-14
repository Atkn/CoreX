using SpaceX.Backoffice.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpaceX.Backoffice.Core
{
    public class BaseEntity 
    {
        [Key]
        public Guid Id { get; set; }

        [EntityElementUI(UIElementType: UIElementType.TextArea, formOrder: 25, tableOrder: 55 )]
        public virtual string Title { get; set; }

        [EntityElementUI(UIElementType: UIElementType.DateTimePicker, formOrder: 99, tableOrder: 99)]
        public virtual DateTime CreatedAt { get; set; }

        [EntityElementUI(UIElementType: UIElementType.DateTimePicker, formOrder: 25, tableOrder: 99)]
        public virtual DateTime ModifiedAt { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }

    }
}
