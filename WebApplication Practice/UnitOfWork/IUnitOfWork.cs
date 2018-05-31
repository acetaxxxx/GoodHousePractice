using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication_Practice.UnitOfWork
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Commit
        /// </summary>
        void Commit();

        /// <summary>
        /// Reject
        /// </summary>
        void RejectChange();

        void Dispose();
    }
}