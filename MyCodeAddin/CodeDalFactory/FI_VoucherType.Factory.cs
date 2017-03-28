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
	public class FI_VoucherTypeFactory:Common.Business.FI_VoucherType
    {
        public static Common.Business.FI_VoucherType Fetch(FI_VoucherType data)
        {
            Common.Business.FI_VoucherType item = (Common.Business.FI_VoucherType)Activator.CreateInstance(typeof(Common.Business.FI_VoucherType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.VouType = data.VouType;
				                item.NegPostX = data.NegPostX;
				                item.AssPostX = data.AssPostX;
				                item.CustPostX = data.CustPostX;
				                item.VendPostX = data.VendPostX;
				                item.MMPostX = data.MMPostX;
				                item.GLPostX = data.GLPostX;
				                item.ParkRNR = data.ParkRNR;
				                item.PostRNR = data.PostRNR;
				                item.DText = data.DText;
				                item.CVType = data.CVType;
				                item.PVType = data.PVType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_VoucherType>();
                var i = (from p in ctx.DataContext.FI_VoucherType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.VouType = i.VouType;
										this.NegPostX = i.NegPostX;
										this.AssPostX = i.AssPostX;
										this.CustPostX = i.CustPostX;
										this.VendPostX = i.VendPostX;
										this.MMPostX = i.MMPostX;
										this.GLPostX = i.GLPostX;
										this.ParkRNR = i.ParkRNR;
										this.PostRNR = i.PostRNR;
										this.DText = i.DText;
										this.CVType = i.CVType;
										this.PVType = i.PVType;
					}
            }
        }
	}

	public class FI_VoucherTypesFactory : Common.Business.FI_VoucherTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_VoucherType
                        select FI_VoucherTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_VoucherType
                        select FI_VoucherTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_VoucherType>();
                var i = (from p in ctx.DataContext.FI_VoucherType.Where(exp)
                         select FI_VoucherTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_VoucherType>();
                var i = from p in ctx.DataContext.FI_VoucherType.Where(exp)
                         select FI_VoucherTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
