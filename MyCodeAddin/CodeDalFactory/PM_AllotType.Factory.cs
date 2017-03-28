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
	public class PM_AllotTypeFactory:Common.Business.PM_AllotType
    {
        public static Common.Business.PM_AllotType Fetch(PM_AllotType data)
        {
            Common.Business.PM_AllotType item = (Common.Business.PM_AllotType)Activator.CreateInstance(typeof(Common.Business.PM_AllotType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotTypeCode = data.AllotTypeCode;
				                item.AllotTypeName = data.AllotTypeName;
				                item.Memo = data.Memo;
				                item.IncRate = data.IncRate;
				                item.IsFundIn = data.IsFundIn;
				                item.IsProjIn = data.IsProjIn;
				                item.Active = data.Active;
				                item.SIncItemCode = data.SIncItemCode;
				                item.AllotModCode = data.AllotModCode;
				                item.VendorCode = data.VendorCode;
				                item.AccCode = data.AccCode;
				                item.GLMarkApp = data.GLMarkApp;
				                item.GLMarkInv = data.GLMarkInv;
				                item.GLMarkTax = data.GLMarkTax;
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
				var exp = lambda.Resolve<PM_AllotType>();
                var i = (from p in ctx.DataContext.PM_AllotType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotTypeCode = i.AllotTypeCode;
										this.AllotTypeName = i.AllotTypeName;
										this.Memo = i.Memo;
										this.IncRate = i.IncRate;
										this.IsFundIn = i.IsFundIn;
										this.IsProjIn = i.IsProjIn;
										this.Active = i.Active;
										this.SIncItemCode = i.SIncItemCode;
										this.AllotModCode = i.AllotModCode;
										this.VendorCode = i.VendorCode;
										this.AccCode = i.AccCode;
										this.GLMarkApp = i.GLMarkApp;
										this.GLMarkInv = i.GLMarkInv;
										this.GLMarkTax = i.GLMarkTax;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_AllotTypesFactory : Common.Business.PM_AllotTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotType
                        select PM_AllotTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotType
                        select PM_AllotTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotType>();
                var i = (from p in ctx.DataContext.PM_AllotType.Where(exp)
                         select PM_AllotTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotType>();
                var i = from p in ctx.DataContext.PM_AllotType.Where(exp)
                         select PM_AllotTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
