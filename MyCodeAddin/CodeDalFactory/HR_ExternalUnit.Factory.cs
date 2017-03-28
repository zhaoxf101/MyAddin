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
	public class HR_ExternalUnitFactory:Common.Business.HR_ExternalUnit
    {
        public static Common.Business.HR_ExternalUnit Fetch(HR_ExternalUnit data)
        {
            Common.Business.HR_ExternalUnit item = (Common.Business.HR_ExternalUnit)Activator.CreateInstance(typeof(Common.Business.HR_ExternalUnit));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExtUnitCode = data.ExtUnitCode;
				                item.ExtUnitName = data.ExtUnitName;
				                item.PersonId = data.PersonId;
				                item.IdNo = data.IdNo;
				                item.BankCardId = data.BankCardId;
				                item.BankName = data.BankName;
				                item.IsPublic = data.IsPublic;
				                item.IsShare = data.IsShare;
				                item.DepCode = data.DepCode;
				                item.CreateUser = data.CreateUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.UnitedBankId = data.UnitedBankId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_ExternalUnit>();
                var i = (from p in ctx.DataContext.HR_ExternalUnit.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExtUnitCode = i.ExtUnitCode;
										this.ExtUnitName = i.ExtUnitName;
										this.PersonId = i.PersonId;
										this.IdNo = i.IdNo;
										this.BankCardId = i.BankCardId;
										this.BankName = i.BankName;
										this.IsPublic = i.IsPublic;
										this.IsShare = i.IsShare;
										this.DepCode = i.DepCode;
										this.CreateUser = i.CreateUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.UnitedBankId = i.UnitedBankId;
					}
            }
        }
	}

	public class HR_ExternalUnitsFactory : Common.Business.HR_ExternalUnits
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_ExternalUnit
                        select HR_ExternalUnitFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_ExternalUnit
                        select HR_ExternalUnitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_ExternalUnit>();
                var i = (from p in ctx.DataContext.HR_ExternalUnit.Where(exp)
                         select HR_ExternalUnitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_ExternalUnit>();
                var i = from p in ctx.DataContext.HR_ExternalUnit.Where(exp)
                         select HR_ExternalUnitFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
