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
	public class HR_SociSecImportFactory:Common.Business.HR_SociSecImport
    {
        public static Common.Business.HR_SociSecImport Fetch(HR_SociSecImport data)
        {
            Common.Business.HR_SociSecImport item = (Common.Business.HR_SociSecImport)Activator.CreateInstance(typeof(Common.Business.HR_SociSecImport));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.SociSecCode = data.SociSecCode;
				                item.Period = data.Period;
				                item.ModeCode = data.ModeCode;
				                item.Memo = data.Memo;
				                item.ProjCode = data.ProjCode;
				                item.IsConf = data.IsConf;
				                item.BillNo = data.BillNo;
				                item.IsHaveTax = data.IsHaveTax;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_SociSecImport>();
                var i = (from p in ctx.DataContext.HR_SociSecImport.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.SociSecCode = i.SociSecCode;
										this.Period = i.Period;
										this.ModeCode = i.ModeCode;
										this.Memo = i.Memo;
										this.ProjCode = i.ProjCode;
										this.IsConf = i.IsConf;
										this.BillNo = i.BillNo;
										this.IsHaveTax = i.IsHaveTax;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_SociSecImportsFactory : Common.Business.HR_SociSecImports
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_SociSecImport
                        select HR_SociSecImportFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_SociSecImport
                        select HR_SociSecImportFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_SociSecImport>();
                var i = (from p in ctx.DataContext.HR_SociSecImport.Where(exp)
                         select HR_SociSecImportFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_SociSecImport>();
                var i = from p in ctx.DataContext.HR_SociSecImport.Where(exp)
                         select HR_SociSecImportFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
