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
	public class SM_StudentStatusFactory:Common.Business.SM_StudentStatus
    {
        public static Common.Business.SM_StudentStatus Fetch(SM_StudentStatus data)
        {
            Common.Business.SM_StudentStatus item = (Common.Business.SM_StudentStatus)Activator.CreateInstance(typeof(Common.Business.SM_StudentStatus));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.StudentStatusCode = data.StudentStatusCode;
				                item.StudentStatusName = data.StudentStatusName;
				                item.StudentStatusTypeCode = data.StudentStatusTypeCode;
				                item.bFeeYN = data.bFeeYN;
				                item.IsFreeTax = data.IsFreeTax;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_StudentStatus>();
                var i = (from p in ctx.DataContext.SM_StudentStatus.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.StudentStatusCode = i.StudentStatusCode;
										this.StudentStatusName = i.StudentStatusName;
										this.StudentStatusTypeCode = i.StudentStatusTypeCode;
										this.bFeeYN = i.bFeeYN;
										this.IsFreeTax = i.IsFreeTax;
					}
            }
        }
	}

	public class SM_StudentStatussFactory : Common.Business.SM_StudentStatuss
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_StudentStatus
                        select SM_StudentStatusFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_StudentStatus
                        select SM_StudentStatusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_StudentStatus>();
                var i = (from p in ctx.DataContext.SM_StudentStatus.Where(exp)
                         select SM_StudentStatusFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_StudentStatus>();
                var i = from p in ctx.DataContext.SM_StudentStatus.Where(exp)
                         select SM_StudentStatusFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
