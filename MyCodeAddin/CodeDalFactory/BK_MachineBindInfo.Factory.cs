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
	public class BK_MachineBindInfoFactory:Common.Business.BK_MachineBindInfo
    {
        public static Common.Business.BK_MachineBindInfo Fetch(BK_MachineBindInfo data)
        {
            Common.Business.BK_MachineBindInfo item = (Common.Business.BK_MachineBindInfo)Activator.CreateInstance(typeof(Common.Business.BK_MachineBindInfo));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.MachineId = data.MachineId;
				                item.PersonId = data.PersonId;
				                item.PersonName = data.PersonName;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.Description = data.Description;
				                item.IsSubmit = data.IsSubmit;
				                item.IsCanPay = data.IsCanPay;
				                item.IsCanView = data.IsCanView;
				                item.CreatedDate = data.CreatedDate;
				                item.CreateUser = data.CreateUser;
				                item.IsSetPass = data.IsSetPass;
				                item.PayPass = data.PayPass;
				                item.IsAllotSet = data.IsAllotSet;
				                item.IsCtrlTime = data.IsCtrlTime;
				                item.StartTime = data.StartTime;
				                item.EndTime = data.EndTime;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<BK_MachineBindInfo>();
                var i = (from p in ctx.DataContext.BK_MachineBindInfo.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.MachineId = i.MachineId;
										this.PersonId = i.PersonId;
										this.PersonName = i.PersonName;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.Description = i.Description;
										this.IsSubmit = i.IsSubmit;
										this.IsCanPay = i.IsCanPay;
										this.IsCanView = i.IsCanView;
										this.CreatedDate = i.CreatedDate;
										this.CreateUser = i.CreateUser;
										this.IsSetPass = i.IsSetPass;
										this.PayPass = i.PayPass;
										this.IsAllotSet = i.IsAllotSet;
										this.IsCtrlTime = i.IsCtrlTime;
										this.StartTime = i.StartTime;
										this.EndTime = i.EndTime;
					}
            }
        }
	}

	public class BK_MachineBindInfosFactory : Common.Business.BK_MachineBindInfos
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.BK_MachineBindInfo
                        select BK_MachineBindInfoFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.BK_MachineBindInfo
                        select BK_MachineBindInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<BK_MachineBindInfo>();
                var i = (from p in ctx.DataContext.BK_MachineBindInfo.Where(exp)
                         select BK_MachineBindInfoFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<BK_MachineBindInfo>();
                var i = from p in ctx.DataContext.BK_MachineBindInfo.Where(exp)
                         select BK_MachineBindInfoFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
