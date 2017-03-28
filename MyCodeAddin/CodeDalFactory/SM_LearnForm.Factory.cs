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
	public class SM_LearnFormFactory:Common.Business.SM_LearnForm
    {
        public static Common.Business.SM_LearnForm Fetch(SM_LearnForm data)
        {
            Common.Business.SM_LearnForm item = (Common.Business.SM_LearnForm)Activator.CreateInstance(typeof(Common.Business.SM_LearnForm));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.LearnFormCode = data.LearnFormCode;
				                item.LearnFormName = data.LearnFormName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<SM_LearnForm>();
                var i = (from p in ctx.DataContext.SM_LearnForm.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.LearnFormCode = i.LearnFormCode;
										this.LearnFormName = i.LearnFormName;
					}
            }
        }
	}

	public class SM_LearnFormsFactory : Common.Business.SM_LearnForms
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_LearnForm
                        select SM_LearnFormFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_LearnForm
                        select SM_LearnFormFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_LearnForm>();
                var i = (from p in ctx.DataContext.SM_LearnForm.Where(exp)
                         select SM_LearnFormFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_LearnForm>();
                var i = from p in ctx.DataContext.SM_LearnForm.Where(exp)
                         select SM_LearnFormFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
