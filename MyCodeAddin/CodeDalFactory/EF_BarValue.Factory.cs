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
	public class EF_BarValueFactory:Common.Business.EF_BarValue
    {
        public static Common.Business.EF_BarValue Fetch(EF_BarValue data)
        {
            Common.Business.EF_BarValue item = (Common.Business.EF_BarValue)Activator.CreateInstance(typeof(Common.Business.EF_BarValue));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BarObject = data.BarObject;
				                item.PrefixName = data.PrefixName;
				                item.FromNum = data.FromNum;
				                item.ToNum = data.ToNum;
				                item.CurrentNum = data.CurrentNum;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_BarValue>();
                var i = (from p in ctx.DataContext.EF_BarValue.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BarObject = i.BarObject;
										this.PrefixName = i.PrefixName;
										this.FromNum = i.FromNum;
										this.ToNum = i.ToNum;
										this.CurrentNum = i.CurrentNum;
					}
            }
        }
	}

	public class EF_BarValuesFactory : Common.Business.EF_BarValues
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_BarValue
                        select EF_BarValueFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_BarValue
                        select EF_BarValueFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_BarValue>();
                var i = (from p in ctx.DataContext.EF_BarValue.Where(exp)
                         select EF_BarValueFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_BarValue>();
                var i = from p in ctx.DataContext.EF_BarValue.Where(exp)
                         select EF_BarValueFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
