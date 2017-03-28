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
	public class FI_FundAccTypeFactory:Common.Business.FI_FundAccType
    {
        public static Common.Business.FI_FundAccType Fetch(FI_FundAccType data)
        {
            Common.Business.FI_FundAccType item = (Common.Business.FI_FundAccType)Activator.CreateInstance(typeof(Common.Business.FI_FundAccType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.FundAccTypeCode = data.FundAccTypeCode;
				                item.FundAccTypeName = data.FundAccTypeName;
				                item.IsCtrlAcc = data.IsCtrlAcc;
				                item.IsEscrow = data.IsEscrow;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_FundAccType>();
                var i = (from p in ctx.DataContext.FI_FundAccType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.FundAccTypeCode = i.FundAccTypeCode;
										this.FundAccTypeName = i.FundAccTypeName;
										this.IsCtrlAcc = i.IsCtrlAcc;
										this.IsEscrow = i.IsEscrow;
					}
            }
        }
	}

	public class FI_FundAccTypesFactory : Common.Business.FI_FundAccTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_FundAccType
                        select FI_FundAccTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_FundAccType
                        select FI_FundAccTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_FundAccType>();
                var i = (from p in ctx.DataContext.FI_FundAccType.Where(exp)
                         select FI_FundAccTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_FundAccType>();
                var i = from p in ctx.DataContext.FI_FundAccType.Where(exp)
                         select FI_FundAccTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
