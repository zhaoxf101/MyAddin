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
	public class zproFactory:Common.Business.zpro
    {
        public static Common.Business.zpro Fetch(zpro data)
        {
            Common.Business.zpro item = (Common.Business.zpro)Activator.CreateInstance(typeof(Common.Business.zpro));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.xh = data.xh;
				                item.pcode = data.pcode;
				                item.pname = data.pname;
				                item.projfund = data.projfund;
				                item.typepcode = data.typepcode;
				                item.mcode = data.mcode;
				                item.lperno = data.lperno;
				                item.dcode = data.dcode;
				                item.dposicode = data.dposicode;
				                item.cldcode = data.cldcode;
				                item.clposicode = data.clposicode;
				                item.sclposicode = data.sclposicode;
				                item.projmem = data.projmem;
				                item.con = data.con;
				                item.isbud = data.isbud;
				                item.isfin = data.isfin;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<zpro>();
                var i = (from p in ctx.DataContext.zpro.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.xh = i.xh;
										this.pcode = i.pcode;
										this.pname = i.pname;
										this.projfund = i.projfund;
										this.typepcode = i.typepcode;
										this.mcode = i.mcode;
										this.lperno = i.lperno;
										this.dcode = i.dcode;
										this.dposicode = i.dposicode;
										this.cldcode = i.cldcode;
										this.clposicode = i.clposicode;
										this.sclposicode = i.sclposicode;
										this.projmem = i.projmem;
										this.con = i.con;
										this.isbud = i.isbud;
										this.isfin = i.isfin;
					}
            }
        }
	}

	public class zprosFactory : Common.Business.zpros
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.zpro
                        select zproFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.zpro
                        select zproFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<zpro>();
                var i = (from p in ctx.DataContext.zpro.Where(exp)
                         select zproFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<zpro>();
                var i = from p in ctx.DataContext.zpro.Where(exp)
                         select zproFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
