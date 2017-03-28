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
	public class RD_BankReceivedFactory:Common.Business.RD_BankReceived
    {
        public static Common.Business.RD_BankReceived Fetch(RD_BankReceived data)
        {
            Common.Business.RD_BankReceived item = (Common.Business.RD_BankReceived)Activator.CreateInstance(typeof(Common.Business.RD_BankReceived));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RecipName = data.RecipName;
				                item.RecipAccNo = data.RecipAccNo;
				                item.RecipBkNo = data.RecipBkNo;
				                item.TranAmt = data.TranAmt;
				                item.TranTime = data.TranTime;
				                item.PostScript = data.PostScript;
				                item.BankNote = data.BankNote;
				                item.BusType = data.BusType;
				                item.BankTranNO = data.BankTranNO;
				                item.BKName = data.BKName;
				                item.AccNo = data.AccNo;
				                item.AccName = data.AccName;
				                item.PreAllotAmt = data.PreAllotAmt;
				                item.FIAudit = data.FIAudit;
				                item.ProjectCode = data.ProjectCode;
				                item.ProjectName = data.ProjectName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<RD_BankReceived>();
                var i = (from p in ctx.DataContext.RD_BankReceived.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RecipName = i.RecipName;
										this.RecipAccNo = i.RecipAccNo;
										this.RecipBkNo = i.RecipBkNo;
										this.TranAmt = i.TranAmt;
										this.TranTime = i.TranTime;
										this.PostScript = i.PostScript;
										this.BankNote = i.BankNote;
										this.BusType = i.BusType;
										this.BankTranNO = i.BankTranNO;
										this.BKName = i.BKName;
										this.AccNo = i.AccNo;
										this.AccName = i.AccName;
										this.PreAllotAmt = i.PreAllotAmt;
										this.FIAudit = i.FIAudit;
										this.ProjectCode = i.ProjectCode;
										this.ProjectName = i.ProjectName;
					}
            }
        }
	}

	public class RD_BankReceivedsFactory : Common.Business.RD_BankReceiveds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.RD_BankReceived
                        select RD_BankReceivedFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.RD_BankReceived
                        select RD_BankReceivedFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<RD_BankReceived>();
                var i = (from p in ctx.DataContext.RD_BankReceived.Where(exp)
                         select RD_BankReceivedFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<RD_BankReceived>();
                var i = from p in ctx.DataContext.RD_BankReceived.Where(exp)
                         select RD_BankReceivedFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
