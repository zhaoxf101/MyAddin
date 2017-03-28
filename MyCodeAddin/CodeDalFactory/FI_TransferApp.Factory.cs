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
	public class FI_TransferAppFactory:Common.Business.FI_TransferApp
    {
        public static Common.Business.FI_TransferApp Fetch(FI_TransferApp data)
        {
            Common.Business.FI_TransferApp item = (Common.Business.FI_TransferApp)Activator.CreateInstance(typeof(Common.Business.FI_TransferApp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TransferAppNo = data.TransferAppNo;
				                item.TransferAppText = data.TransferAppText;
				                item.TransferTypeCode = data.TransferTypeCode;
				                item.ProfitCtr = data.ProfitCtr;
				                item.InvItemCode = data.InvItemCode;
				                item.SIncItemCode = data.SIncItemCode;
				                item.IncDetCode = data.IncDetCode;
				                item.IsSubmit = data.IsSubmit;
				                item.ExpProjCode = data.ExpProjCode;
				                item.TransDepCode = data.TransDepCode;
				                item.AppAmt = data.AppAmt;
				                item.OrdAmt = data.OrdAmt;
				                item.TransAmt = data.TransAmt;
				                item.Approved = data.Approved;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
				                item.TaskCode = data.TaskCode;
				                item.DepCode = data.DepCode;
				                item.FundCode = data.FundCode;
				                item.IsAllot = data.IsAllot;
				                item.IsCheck = data.IsCheck;
				                item.CheckUser = data.CheckUser;
				                item.CheckDate = data.CheckDate;
				                item.VendorCode = data.VendorCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_TransferApp>();
                var i = (from p in ctx.DataContext.FI_TransferApp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TransferAppNo = i.TransferAppNo;
										this.TransferAppText = i.TransferAppText;
										this.TransferTypeCode = i.TransferTypeCode;
										this.ProfitCtr = i.ProfitCtr;
										this.InvItemCode = i.InvItemCode;
										this.SIncItemCode = i.SIncItemCode;
										this.IncDetCode = i.IncDetCode;
										this.IsSubmit = i.IsSubmit;
										this.ExpProjCode = i.ExpProjCode;
										this.TransDepCode = i.TransDepCode;
										this.AppAmt = i.AppAmt;
										this.OrdAmt = i.OrdAmt;
										this.TransAmt = i.TransAmt;
										this.Approved = i.Approved;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
										this.TaskCode = i.TaskCode;
										this.DepCode = i.DepCode;
										this.FundCode = i.FundCode;
										this.IsAllot = i.IsAllot;
										this.IsCheck = i.IsCheck;
										this.CheckUser = i.CheckUser;
										this.CheckDate = i.CheckDate;
										this.VendorCode = i.VendorCode;
					}
            }
        }
	}

	public class FI_TransferAppsFactory : Common.Business.FI_TransferApps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_TransferApp
                        select FI_TransferAppFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_TransferApp
                        select FI_TransferAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_TransferApp>();
                var i = (from p in ctx.DataContext.FI_TransferApp.Where(exp)
                         select FI_TransferAppFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_TransferApp>();
                var i = from p in ctx.DataContext.FI_TransferApp.Where(exp)
                         select FI_TransferAppFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
