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
	public class FE_MessageFactory:Common.Business.FE_Message
    {
        public static Common.Business.FE_Message Fetch(FE_Message data)
        {
            Common.Business.FE_Message item = (Common.Business.FE_Message)Activator.CreateInstance(typeof(Common.Business.FE_Message));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MessageID = data.MessageID;
				                item.TemplateID = data.TemplateID;
				                item.TemplateName = data.TemplateName;
				                item.TemplateDesc = data.TemplateDesc;
				                item.IsActive = data.IsActive;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_Message>();
                var i = (from p in ctx.DataContext.FE_Message.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MessageID = i.MessageID;
										this.TemplateID = i.TemplateID;
										this.TemplateName = i.TemplateName;
										this.TemplateDesc = i.TemplateDesc;
										this.IsActive = i.IsActive;
					}
            }
        }
	}

	public class FE_MessagesFactory : Common.Business.FE_Messages
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_Message
                        select FE_MessageFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_Message
                        select FE_MessageFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_Message>();
                var i = (from p in ctx.DataContext.FE_Message.Where(exp)
                         select FE_MessageFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_Message>();
                var i = from p in ctx.DataContext.FE_Message.Where(exp)
                         select FE_MessageFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
