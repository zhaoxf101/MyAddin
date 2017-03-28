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
	public class EF_ControlerFactory:Common.Business.EF_Controler
    {
        public static Common.Business.EF_Controler Fetch(EF_Controler data)
        {
            Common.Business.EF_Controler item = (Common.Business.EF_Controler)Activator.CreateInstance(typeof(Common.Business.EF_Controler));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Controler = data.Controler;
				                item.DText = data.DText;
				                item.PgmName = data.PgmName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_Controler>();
                var i = (from p in ctx.DataContext.EF_Controler.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Controler = i.Controler;
										this.DText = i.DText;
										this.PgmName = i.PgmName;
					}
            }
        }
	}

	public class EF_ControlersFactory : Common.Business.EF_Controlers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_Controler
                        select EF_ControlerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_Controler
                        select EF_ControlerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_Controler>();
                var i = (from p in ctx.DataContext.EF_Controler.Where(exp)
                         select EF_ControlerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_Controler>();
                var i = from p in ctx.DataContext.EF_Controler.Where(exp)
                         select EF_ControlerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
