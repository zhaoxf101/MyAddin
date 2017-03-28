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
	public class FI_TaxAdjFactory:Common.Business.FI_TaxAdj
    {
        public static Common.Business.FI_TaxAdj Fetch(FI_TaxAdj data)
        {
            Common.Business.FI_TaxAdj item = (Common.Business.FI_TaxAdj)Activator.CreateInstance(typeof(Common.Business.FI_TaxAdj));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.TaxAdjCode = data.TaxAdjCode;
				                item.TaxAdjText = data.TaxAdjText;
				                item.IsClear = data.IsClear;
				                item.Period = data.Period;
				                item.PersonId = data.PersonId;
				                item.IsSubmit = data.IsSubmit;
				                item.Appovel = data.Appovel;
				                item.Description = data.Description;
				                item.AccDateTime = data.AccDateTime;
				                item.VouchNo = data.VouchNo;
				                item.AccYear = data.AccYear;
				                item.AccPid = data.AccPid;
				                item.LineNR = data.LineNR;
				                item.VouchText = data.VouchText;
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
				var exp = lambda.Resolve<FI_TaxAdj>();
                var i = (from p in ctx.DataContext.FI_TaxAdj.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.TaxAdjCode = i.TaxAdjCode;
										this.TaxAdjText = i.TaxAdjText;
										this.IsClear = i.IsClear;
										this.Period = i.Period;
										this.PersonId = i.PersonId;
										this.IsSubmit = i.IsSubmit;
										this.Appovel = i.Appovel;
										this.Description = i.Description;
										this.AccDateTime = i.AccDateTime;
										this.VouchNo = i.VouchNo;
										this.AccYear = i.AccYear;
										this.AccPid = i.AccPid;
										this.LineNR = i.LineNR;
										this.VouchText = i.VouchText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_TaxAdjsFactory : Common.Business.FI_TaxAdjs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_TaxAdj
                        select FI_TaxAdjFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_TaxAdj
                        select FI_TaxAdjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_TaxAdj>();
                var i = (from p in ctx.DataContext.FI_TaxAdj.Where(exp)
                         select FI_TaxAdjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_TaxAdj>();
                var i = from p in ctx.DataContext.FI_TaxAdj.Where(exp)
                         select FI_TaxAdjFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
