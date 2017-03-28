using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF;
using EF.Data;
using EF.Linq;
using EF.Server;
using EFramework.DalLinq;

namespace Common.DalFactory
{
	public class HR_EmpBusEduFactory:Common.Business.HR_EmpBusEdu
    {
        public static Common.Business.HR_EmpBusEdu Fetch(HR_EmpBusEdu data)
        {
            Common.Business.HR_EmpBusEdu item = (Common.Business.HR_EmpBusEdu)Activator.CreateInstance(typeof(Common.Business.HR_EmpBusEdu));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Id = data.Id;
				                item.Client = data.Client;
				                item.EmpBusNo = data.EmpBusNo;
				                item.EmpCode = data.EmpCode;
				                item.SchoolName = data.SchoolName;
				                item.StartPeriod = data.StartPeriod;
				                item.EndPeriod = data.EndPeriod;
				                item.EduGrade = data.EduGrade;
				                item.IsMaxEdu = data.IsMaxEdu;
				                item.DegreeGrade = data.DegreeGrade;
				                item.IsMaxDegree = data.IsMaxDegree;
				                item.ActionType = data.ActionType;
				                item.OldId = data.OldId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpBusEdu>();
                var i = (from p in ctx.DataContext.HR_EmpBusEdu.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Id = i.Id;
										this.Client = i.Client;
										this.EmpBusNo = i.EmpBusNo;
										this.EmpCode = i.EmpCode;
										this.SchoolName = i.SchoolName;
										this.StartPeriod = i.StartPeriod;
										this.EndPeriod = i.EndPeriod;
										this.EduGrade = i.EduGrade;
										this.IsMaxEdu = i.IsMaxEdu;
										this.DegreeGrade = i.DegreeGrade;
										this.IsMaxDegree = i.IsMaxDegree;
										this.ActionType = i.ActionType;
										this.OldId = i.OldId;
					}
            }
        }
	}

	public class HR_EmpBusEdusFactory : Common.Business.HR_EmpBusEdus
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpBusEdu
                        select HR_EmpBusEduFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Paging page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = (from p in ctx.DataContext.HR_EmpBusEdu
                        select HR_EmpBusEduFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

        private void DataPortal_Fetch(PagigExpress page)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = page.Lambda.Resolve<HR_EmpBusEdu>();
                var i = (from p in ctx.DataContext.HR_EmpBusEdu.Where(exp)
                         select HR_EmpBusEduFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var exp = lambda.Resolve<HR_EmpBusEdu>();
                var i = from p in ctx.DataContext.HR_EmpBusEdu.Where(exp)
                         select HR_EmpBusEduFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
