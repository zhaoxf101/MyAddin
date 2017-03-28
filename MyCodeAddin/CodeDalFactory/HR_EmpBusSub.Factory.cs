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
	public class HR_EmpBusSubFactory:Common.Business.HR_EmpBusSub
    {
        public static Common.Business.HR_EmpBusSub Fetch(HR_EmpBusSub data)
        {
            Common.Business.HR_EmpBusSub item = (Common.Business.HR_EmpBusSub)Activator.CreateInstance(typeof(Common.Business.HR_EmpBusSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EmpBusNo = data.EmpBusNo;
				                item.InfoType = data.InfoType;
				                item.EventType = data.EventType;
				                item.Sort = data.Sort;
				                item.IsValidate = data.IsValidate;
				                item.IsConfirm = data.IsConfirm;
				                item.IsDefaut = data.IsDefaut;
				                item.IsShow = data.IsShow;
				                item.DefautPara = data.DefautPara;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpBusSub>();
                var i = (from p in ctx.DataContext.HR_EmpBusSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EmpBusNo = i.EmpBusNo;
										this.InfoType = i.InfoType;
										this.EventType = i.EventType;
										this.Sort = i.Sort;
										this.IsValidate = i.IsValidate;
										this.IsConfirm = i.IsConfirm;
										this.IsDefaut = i.IsDefaut;
										this.IsShow = i.IsShow;
										this.DefautPara = i.DefautPara;
					}
            }
        }
	}

	public class HR_EmpBusSubsFactory : Common.Business.HR_EmpBusSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpBusSub
                        select HR_EmpBusSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpBusSub
                        select HR_EmpBusSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpBusSub>();
                var i = (from p in ctx.DataContext.HR_EmpBusSub.Where(exp)
                         select HR_EmpBusSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpBusSub>();
                var i = from p in ctx.DataContext.HR_EmpBusSub.Where(exp)
                         select HR_EmpBusSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
