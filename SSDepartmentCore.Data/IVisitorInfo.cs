using SSDepartmentCore.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSDepartmentCore.Data
{
    public interface IVisitorInfo
    {
        IEnumerable<Visitor> GetAll();
        Visitor GetById(int id);
        void Add(Visitor newVisitor);
        string GetContactNumber(int id);
        IEnumerable<Visitor> GetVisitRange(DateTime startDate, DateTime endDate);

    }
}
