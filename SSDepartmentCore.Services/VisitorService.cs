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

        public IEnumerable<string> ContactNumbers()
        {
            return _dataContext.Visitors.Select(dv => dv.ContactNumber);
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
            return _dataContext.Visitors
                .Where(A => A.DateVisited >= startDate && A.DateVisited <= endDate);
            //return GetAll().Where(dv => dv.DateVisited >= startDate && dv.DateVisited <= endDate);
        }

        public void Update(Visitor updateVisitor)
        {
            var update = _dataContext.Visitors.
                FirstOrDefault(dv => dv.Id == updateVisitor.Id);

            update.NeedCounselling = updateVisitor.NeedCounselling;
            update.PrayerRequest = updateVisitor.PrayerRequest;
            update.SeePastor = updateVisitor.SeePastor;
            update.Surname = updateVisitor.Surname;
            update.FirstName = updateVisitor.FirstName;
            update.ContactNumber = updateVisitor.ContactNumber;
            update.EmailAddress = updateVisitor.EmailAddress;
            update.Adventist = updateVisitor.Adventist;
            update.Address = updateVisitor.Address;
            update.Church = update.Church;
            update.DateVisited = updateVisitor.DateVisited;
           
            
          //_dataContext.Update(update);
            _dataContext.SaveChanges();
        }

        public IEnumerable<string> UserEmails()
        {
            return _dataContext.Visitors.Select(dv => dv.EmailAddress);
            
        }

        public void Delete(Visitor deleteVisitor)
        {
            var deleted = _dataContext.Visitors
                .FirstOrDefault(dv => dv.Id == deleteVisitor.Id);

            _dataContext.Entry(deleted).State = Microsoft
                .EntityFrameworkCore.EntityState.Deleted;
        }


    }
}
