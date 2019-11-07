using System;
using System.Collections.Generic;
using System.Text;

namespace AirPlaneControl.Repository.Infra
{
    public interface IUnitOfWork:IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
