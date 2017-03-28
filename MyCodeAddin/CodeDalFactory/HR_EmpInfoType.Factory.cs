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
	public class HR_EmpInfoTypeFactory:Common.Business.HR_EmpInfoType
    {
        public static Common.Business.HR_EmpInfoType Fetch(HR_EmpInfoType data)
        {
            Common.Business.HR_EmpInfoType item = (Common.Business.HR_EmpInfoType)Activator.CreateInstance(typeof(Common.Business.HR_EmpInfoType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.InfoType = data.InfoType;
				                item.DText = data.DText;
				                item.WebObject = data.WebObject;
				                item.WinObject = data.WinObject;
				                item.DefautObject = data.DefautObject;
				                item.Memo = data.Memo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpInfoType>();
                var i = (from p in ctx.DataContext.HR_EmpInfoType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.InfoType = i.InfoType;
										this.DText = i.DText;
										this.WebObject = i.WebObject;
										this.WinObject = i.WinObject;
										this.DefautObject = i.DefautObject;
										this.Memo = i.Memo;
					}
            }
        }
	}

	public class HR_EmpInfoTypesFactory : Common.Business.HR_EmpInfoTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpInfoType
                        select HR_EmpInfoTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpInfoType
                        select HR_EmpInfoTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpInfoType>();
                var i = (from p in ctx.DataContext.HR_EmpInfoType.Where(exp)
                         select HR_EmpInfoTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpInfoType>();
                var i = from p in ctx.DataContext.HR_EmpInfoType.Where(exp)
                         select HR_EmpInfoTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
