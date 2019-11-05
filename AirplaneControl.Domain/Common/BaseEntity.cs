using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain.Common
{
    public abstract class BaseEntity : IIdProperty
    {
        public int Id { get; set; }

        public DateTime? CreationDate { get; set; }
    }
}
