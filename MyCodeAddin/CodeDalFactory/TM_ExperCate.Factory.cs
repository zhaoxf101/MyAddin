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
	public class TM_ExperCateFactory:Common.Business.TM_ExperCate
    {
        public static Common.Business.TM_ExperCate Fetch(TM_ExperCate data)
        {
            Common.Business.TM_ExperCate item = (Common.Business.TM_ExperCate)Activator.CreateInstance(typeof(Common.Business.TM_ExperCate));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ExperCateCode = data.ExperCateCode;
				                item.ExperCateName = data.ExperCateName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<TM_ExperCate>();
                var i = (from p in ctx.DataContext.TM_ExperCate.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ExperCateCode = i.ExperCateCode;
										this.ExperCateName = i.ExperCateName;
					}
            }
        }
	}

	public class TM_ExperCatesFactory : Common.Business.TM_ExperCates
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.TM_ExperCate
                        select TM_ExperCateFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.TM_ExperCate
                        select TM_ExperCateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<TM_ExperCate>();
                var i = (from p in ctx.DataContext.TM_ExperCate.Where(exp)
                         select TM_ExperCateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<TM_ExperCate>();
                var i = from p in ctx.DataContext.TM_ExperCate.Where(exp)
                         select TM_ExperCateFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
