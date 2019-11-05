using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneControl.Domain.Common
{
    public interface IIdProperty
    {
        Guid Id { get; set; }
    }
}
