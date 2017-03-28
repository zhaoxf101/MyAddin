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
	public class FE_PayTemplateFactory:Common.Business.FE_PayTemplate
    {
        public static Common.Business.FE_PayTemplate Fetch(FE_PayTemplate data)
        {
            Common.Business.FE_PayTemplate item = (Common.Business.FE_PayTemplate)Activator.CreateInstance(typeof(Common.Business.FE_PayTemplate));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TCode = data.TCode;
				                item.TName = data.TName;
				                item.LText = data.LText;
				                item.AssemblyName = data.AssemblyName;
				                item.ProgramName = data.ProgramName;
				                item.ViewName = data.ViewName;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_PayTemplate>();
                var i = (from p in ctx.DataContext.FE_PayTemplate.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TCode = i.TCode;
										this.TName = i.TName;
										this.LText = i.LText;
										this.AssemblyName = i.AssemblyName;
										this.ProgramName = i.ProgramName;
										this.ViewName = i.ViewName;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
					}
            }
        }
	}

	public class FE_PayTemplatesFactory : Common.Business.FE_PayTemplates
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_PayTemplate
                        select FE_PayTemplateFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_PayTemplate
                        select FE_PayTemplateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_PayTemplate>();
                var i = (from p in ctx.DataContext.FE_PayTemplate.Where(exp)
                         select FE_PayTemplateFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_PayTemplate>();
                var i = from p in ctx.DataContext.FE_PayTemplate.Where(exp)
                         select FE_PayTemplateFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
