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
	public class EF_NRValueFactory:Common.Business.EF_NRValue
    {
        public static Common.Business.EF_NRValue Fetch(EF_NRValue data)
        {
            Common.Business.EF_NRValue item = (Common.Business.EF_NRValue)Activator.CreateInstance(typeof(Common.Business.EF_NRValue));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.NRArea = data.NRArea;
				                item.NRObject = data.NRObject;
				                item.YearPid = data.YearPid;
				                item.RangeNR = data.RangeNR;
				                item.PrefixName = data.PrefixName;
				                item.FromNum = data.FromNum;
				                item.ToNum = data.ToNum;
				                item.CurrentNum = data.CurrentNum;
				                item.ExternFlag = data.ExternFlag;
				                item.IsUsing = data.IsUsing;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_NRValue>();
                var i = (from p in ctx.DataContext.EF_NRValue.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.NRArea = i.NRArea;
										this.NRObject = i.NRObject;
										this.YearPid = i.YearPid;
										this.RangeNR = i.RangeNR;
										this.PrefixName = i.PrefixName;
										this.FromNum = i.FromNum;
										this.ToNum = i.ToNum;
										this.CurrentNum = i.CurrentNum;
										this.ExternFlag = i.ExternFlag;
										this.IsUsing = i.IsUsing;
					}
            }
        }
	}

	public class EF_NRValuesFactory : Common.Business.EF_NRValues
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_NRValue
                        select EF_NRValueFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_NRValue
                        select EF_NRValueFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_NRValue>();
                var i = (from p in ctx.DataContext.EF_NRValue.Where(exp)
                         select EF_NRValueFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_NRValue>();
                var i = from p in ctx.DataContext.EF_NRValue.Where(exp)
                         select EF_NRValueFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
