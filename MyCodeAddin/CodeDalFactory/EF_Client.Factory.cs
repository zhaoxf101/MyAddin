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
	public class EF_ClientFactory:Common.Business.EF_Client
    {
        public static Common.Business.EF_Client Fetch(EF_Client data)
        {
            Common.Business.EF_Client item = (Common.Business.EF_Client)Activator.CreateInstance(typeof(Common.Business.EF_Client));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.DText = data.DText;
				                item.CType = data.CType;
				                item.City = data.City;
				                item.Address = data.Address;
				                item.Currency = data.Currency;
				                item.AccChart = data.AccChart;
				                item.CostArea = data.CostArea;
				                item.AccYearSet = data.AccYearSet;
				                item.PostPidSet = data.PostPidSet;
				                item.FieldSet = data.FieldSet;
				                item.AccStdLev = data.AccStdLev;
				                item.FIAccingX = data.FIAccingX;
				                item.NegPostX = data.NegPostX;
				                item.OnlinePayX = data.OnlinePayX;
				                item.VApprX = data.VApprX;
				                item.VApprLev = data.VApprLev;
				                item.BarPrefixLen = data.BarPrefixLen;
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
				var exp = lambda.Resolve<EF_Client>();
                var i = (from p in ctx.DataContext.EF_Client.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.DText = i.DText;
										this.CType = i.CType;
										this.City = i.City;
										this.Address = i.Address;
										this.Currency = i.Currency;
										this.AccChart = i.AccChart;
										this.CostArea = i.CostArea;
										this.AccYearSet = i.AccYearSet;
										this.PostPidSet = i.PostPidSet;
										this.FieldSet = i.FieldSet;
										this.AccStdLev = i.AccStdLev;
										this.FIAccingX = i.FIAccingX;
										this.NegPostX = i.NegPostX;
										this.OnlinePayX = i.OnlinePayX;
										this.VApprX = i.VApprX;
										this.VApprLev = i.VApprLev;
										this.BarPrefixLen = i.BarPrefixLen;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_ClientsFactory : Common.Business.EF_Clients
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_Client
                        select EF_ClientFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_Client
                        select EF_ClientFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_Client>();
                var i = (from p in ctx.DataContext.EF_Client.Where(exp)
                         select EF_ClientFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_Client>();
                var i = from p in ctx.DataContext.EF_Client.Where(exp)
                         select EF_ClientFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
