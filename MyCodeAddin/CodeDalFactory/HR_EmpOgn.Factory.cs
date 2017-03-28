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
	public class HR_EmpOgnFactory:Common.Business.HR_EmpOgn
    {
        public static Common.Business.HR_EmpOgn Fetch(HR_EmpOgn data)
        {
            Common.Business.HR_EmpOgn item = (Common.Business.HR_EmpOgn)Activator.CreateInstance(typeof(Common.Business.HR_EmpOgn));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ID = data.ID;
				                item.Client = data.Client;
				                item.EmpCode = data.EmpCode;
				                item.DepCode = data.DepCode;
				                item.PositionCode = data.PositionCode;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.IsDel = data.IsDel;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpOgn>();
                var i = (from p in ctx.DataContext.HR_EmpOgn.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ID = i.ID;
										this.Client = i.Client;
										this.EmpCode = i.EmpCode;
										this.DepCode = i.DepCode;
										this.PositionCode = i.PositionCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.IsDel = i.IsDel;
					}
            }
        }
	}

	public class HR_EmpOgnsFactory : Common.Business.HR_EmpOgns
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpOgn
                        select HR_EmpOgnFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpOgn
                        select HR_EmpOgnFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpOgn>();
                var i = (from p in ctx.DataContext.HR_EmpOgn.Where(exp)
                         select HR_EmpOgnFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpOgn>();
                var i = from p in ctx.DataContext.HR_EmpOgn.Where(exp)
                         select HR_EmpOgnFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
