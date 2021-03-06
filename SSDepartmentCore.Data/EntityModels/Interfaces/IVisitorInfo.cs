﻿using SSDepartmentCore.Data.EntityModels;
using SSDepartmentCore.Data.EntityModels.Visitors;
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
        string GetEmail(int id);
        IEnumerable<Visitor> GetVisitRange(DateTime startDate, DateTime endDate);
        IEnumerable<string> UserEmails();
        IEnumerable<string> ContactNumbers();
        void Update(Visitor updateVisitor);
        void Delete(Visitor deleteVisitor);

    }
}
