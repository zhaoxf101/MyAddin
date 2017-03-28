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
	public class EF_AuthObjctFactory:Common.Business.EF_AuthObjct
    {
        public static Common.Business.EF_AuthObjct Fetch(EF_AuthObjct data)
        {
            Common.Business.EF_AuthObjct item = (Common.Business.EF_AuthObjct)Activator.CreateInstance(typeof(Common.Business.EF_AuthObjct));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.AObject = data.AObject;
				                item.AClass = data.AClass;
				                item.FBlock = data.FBlock;
				                item.DText = data.DText;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_AuthObjct>();
                var i = (from p in ctx.DataContext.EF_AuthObjct.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.AObject = i.AObject;
										this.AClass = i.AClass;
										this.FBlock = i.FBlock;
										this.DText = i.DText;
					}
            }
        }
	}

	public class EF_AuthObjctsFactory : Common.Business.EF_AuthObjcts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_AuthObjct
                        select EF_AuthObjctFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_AuthObjct
                        select EF_AuthObjctFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_AuthObjct>();
                var i = (from p in ctx.DataContext.EF_AuthObjct.Where(exp)
                         select EF_AuthObjctFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_AuthObjct>();
                var i = from p in ctx.DataContext.EF_AuthObjct.Where(exp)
                         select EF_AuthObjctFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
