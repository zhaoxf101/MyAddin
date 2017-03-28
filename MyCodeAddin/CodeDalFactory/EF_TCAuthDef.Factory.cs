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
	public class EF_TCAuthDefFactory:Common.Business.EF_TCAuthDef
    {
        public static Common.Business.EF_TCAuthDef Fetch(EF_TCAuthDef data)
        {
            Common.Business.EF_TCAuthDef item = (Common.Business.EF_TCAuthDef)Activator.CreateInstance(typeof(Common.Business.EF_TCAuthDef));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TCode = data.TCode;
				                item.Counter = data.Counter;
				                item.AObject = data.AObject;
				                item.FieldName = data.FieldName;
				                item.Low = data.Low;
				                item.High = data.High;
				                item.LastUser = data.LastUser;
				                item.LastDate = data.LastDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_TCAuthDef>();
                var i = (from p in ctx.DataContext.EF_TCAuthDef.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TCode = i.TCode;
										this.Counter = i.Counter;
										this.AObject = i.AObject;
										this.FieldName = i.FieldName;
										this.Low = i.Low;
										this.High = i.High;
										this.LastUser = i.LastUser;
										this.LastDate = i.LastDate;
					}
            }
        }
	}

	public class EF_TCAuthDefsFactory : Common.Business.EF_TCAuthDefs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_TCAuthDef
                        select EF_TCAuthDefFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_TCAuthDef
                        select EF_TCAuthDefFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_TCAuthDef>();
                var i = (from p in ctx.DataContext.EF_TCAuthDef.Where(exp)
                         select EF_TCAuthDefFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_TCAuthDef>();
                var i = from p in ctx.DataContext.EF_TCAuthDef.Where(exp)
                         select EF_TCAuthDefFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
