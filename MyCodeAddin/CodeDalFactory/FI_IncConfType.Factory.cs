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
	public class FI_IncConfTypeFactory:Common.Business.FI_IncConfType
    {
        public static Common.Business.FI_IncConfType Fetch(FI_IncConfType data)
        {
            Common.Business.FI_IncConfType item = (Common.Business.FI_IncConfType)Activator.CreateInstance(typeof(Common.Business.FI_IncConfType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.IncConfTypeCode = data.IncConfTypeCode;
				                item.IncConfTypeName = data.IncConfTypeName;
				                item.BusType = data.BusType;
				                item.VendorCode = data.VendorCode;
				                item.GLMark = data.GLMark;
				                item.VendorX = data.VendorX;
				                item.GovPayX = data.GovPayX;
				                item.IsAdj = data.IsAdj;
				                item.CollOpenX = data.CollOpenX;
				                item.GovType = data.GovType;
				                item.IncTypeCode = data.IncTypeCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_IncConfType>();
                var i = (from p in ctx.DataContext.FI_IncConfType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.IncConfTypeCode = i.IncConfTypeCode;
										this.IncConfTypeName = i.IncConfTypeName;
										this.BusType = i.BusType;
										this.VendorCode = i.VendorCode;
										this.GLMark = i.GLMark;
										this.VendorX = i.VendorX;
										this.GovPayX = i.GovPayX;
										this.IsAdj = i.IsAdj;
										this.CollOpenX = i.CollOpenX;
										this.GovType = i.GovType;
										this.IncTypeCode = i.IncTypeCode;
					}
            }
        }
	}

	public class FI_IncConfTypesFactory : Common.Business.FI_IncConfTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_IncConfType
                        select FI_IncConfTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_IncConfType
                        select FI_IncConfTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_IncConfType>();
                var i = (from p in ctx.DataContext.FI_IncConfType.Where(exp)
                         select FI_IncConfTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_IncConfType>();
                var i = from p in ctx.DataContext.FI_IncConfType.Where(exp)
                         select FI_IncConfTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
