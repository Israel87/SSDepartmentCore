using SSDepartmentCore.Data;
using SSDepartmentCore.Data.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SSDepartmentCore.Services
{
    public class VisitorService : IVisitorInfo
    {

        // initiate the Database interactions here. 
        private DataContext _dataContext;

        // passing the variable to the initialized datacontext.
        public VisitorService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Visitor newVisitor)
        {
            _dataContext.Add(newVisitor);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Visitor> GetAll()
        {
            return _dataContext.Visitors;
        }

        public Visitor GetById(int id)
        {
            // where dv is datacontext visitors.
            return _dataContext.Visitors
                .FirstOrDefault(dv => dv.Id == id);
        }

        public string GetContactNumber(int id)
        {
           return _dataContext.Visitors
                .FirstOrDefault(dv => dv.Id == id)?.ContactNumber;
        }

        public string GetEmail(int id)
        {
            return _dataContext.Visitors.
                FirstOrDefault(dv => dv.Id == id)?.EmailAddress;
        }


        public IEnumerable<Visitor> GetVisitRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Visitor> UserEmails()
        {
            throw new NotImplementedException();
        }
    }
}
