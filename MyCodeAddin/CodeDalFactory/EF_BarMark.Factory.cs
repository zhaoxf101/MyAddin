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
	public class EF_BarMarkFactory:Common.Business.EF_BarMark
    {
        public static Common.Business.EF_BarMark Fetch(EF_BarMark data)
        {
            Common.Business.EF_BarMark item = (Common.Business.EF_BarMark)Activator.CreateInstance(typeof(Common.Business.EF_BarMark));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.BarMark = data.BarMark;
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
				var exp = lambda.Resolve<EF_BarMark>();
                var i = (from p in ctx.DataContext.EF_BarMark.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.BarMark = i.BarMark;
										this.DText = i.DText;
					}
            }
        }
	}

	public class EF_BarMarksFactory : Common.Business.EF_BarMarks
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_BarMark
                        select EF_BarMarkFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_BarMark
                        select EF_BarMarkFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_BarMark>();
                var i = (from p in ctx.DataContext.EF_BarMark.Where(exp)
                         select EF_BarMarkFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_BarMark>();
                var i = from p in ctx.DataContext.EF_BarMark.Where(exp)
                         select EF_BarMarkFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
