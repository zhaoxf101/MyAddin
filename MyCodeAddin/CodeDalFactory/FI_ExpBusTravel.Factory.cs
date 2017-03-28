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
	public class FI_ExpBusTravelFactory:Common.Business.FI_ExpBusTravel
    {
        public static Common.Business.FI_ExpBusTravel Fetch(FI_ExpBusTravel data)
        {
            Common.Business.FI_ExpBusTravel item = (Common.Business.FI_ExpBusTravel)Activator.CreateInstance(typeof(Common.Business.FI_ExpBusTravel));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpBusCode = data.ExpBusCode;
				                item.TravelRowId = data.TravelRowId;
				                item.PersonId = data.PersonId;
				                item.UserId = data.UserId;
				                item.UserType = data.UserType;
				                item.ExpItemId = data.ExpItemId;
				                item.ExpItemCode = data.ExpItemCode;
				                item.PBudExpEcoCode = data.PBudExpEcoCode;
				                item.StartTime = data.StartTime;
				                item.EndTime = data.EndTime;
				                item.StartLocation = data.StartLocation;
				                item.EndLoaction = data.EndLoaction;
				                item.TravelDays = data.TravelDays;
				                item.Memo = data.Memo;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.ExpAmt = data.ExpAmt;
				                item.ActAmt = data.ActAmt;
				                item.TimeStamp = data.TimeStamp;
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
				var exp = lambda.Resolve<FI_ExpBusTravel>();
                var i = (from p in ctx.DataContext.FI_ExpBusTravel.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpBusCode = i.ExpBusCode;
										this.TravelRowId = i.TravelRowId;
										this.PersonId = i.PersonId;
										this.UserId = i.UserId;
										this.UserType = i.UserType;
										this.ExpItemId = i.ExpItemId;
										this.ExpItemCode = i.ExpItemCode;
										this.PBudExpEcoCode = i.PBudExpEcoCode;
										this.StartTime = i.StartTime;
										this.EndTime = i.EndTime;
										this.StartLocation = i.StartLocation;
										this.EndLoaction = i.EndLoaction;
										this.TravelDays = i.TravelDays;
										this.Memo = i.Memo;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.ExpAmt = i.ExpAmt;
										this.ActAmt = i.ActAmt;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_ExpBusTravelsFactory : Common.Business.FI_ExpBusTravels
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpBusTravel
                        select FI_ExpBusTravelFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpBusTravel
                        select FI_ExpBusTravelFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpBusTravel>();
                var i = (from p in ctx.DataContext.FI_ExpBusTravel.Where(exp)
                         select FI_ExpBusTravelFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpBusTravel>();
                var i = from p in ctx.DataContext.FI_ExpBusTravel.Where(exp)
                         select FI_ExpBusTravelFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
