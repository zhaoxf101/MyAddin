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
	public class PM_AllotModFactory:Common.Business.PM_AllotMod
    {
        public static Common.Business.PM_AllotMod Fetch(PM_AllotMod data)
        {
            Common.Business.PM_AllotMod item = (Common.Business.PM_AllotMod)Activator.CreateInstance(typeof(Common.Business.PM_AllotMod));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.AllotModCode = data.AllotModCode;
				                item.AllotModName = data.AllotModName;
				                item.AllotTypeCode = data.AllotTypeCode;
				                item.IsFixFee = data.IsFixFee;
				                item.FixFeeAmt = data.FixFeeAmt;
				                item.Memo = data.Memo;
				                item.CAccCode = data.CAccCode;
				                item.DAccCode = data.DAccCode;
				                item.Active = data.Active;
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
				var exp = lambda.Resolve<PM_AllotMod>();
                var i = (from p in ctx.DataContext.PM_AllotMod.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.AllotModCode = i.AllotModCode;
										this.AllotModName = i.AllotModName;
										this.AllotTypeCode = i.AllotTypeCode;
										this.IsFixFee = i.IsFixFee;
										this.FixFeeAmt = i.FixFeeAmt;
										this.Memo = i.Memo;
										this.CAccCode = i.CAccCode;
										this.DAccCode = i.DAccCode;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_AllotModsFactory : Common.Business.PM_AllotMods
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_AllotMod
                        select PM_AllotModFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_AllotMod
                        select PM_AllotModFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_AllotMod>();
                var i = (from p in ctx.DataContext.PM_AllotMod.Where(exp)
                         select PM_AllotModFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_AllotMod>();
                var i = from p in ctx.DataContext.PM_AllotMod.Where(exp)
                         select PM_AllotModFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
