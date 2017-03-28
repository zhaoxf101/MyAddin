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
	public class FE_SuggestionFactory:Common.Business.FE_Suggestion
    {
        public static Common.Business.FE_Suggestion Fetch(FE_Suggestion data)
        {
            Common.Business.FE_Suggestion item = (Common.Business.FE_Suggestion)Activator.CreateInstance(typeof(Common.Business.FE_Suggestion));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.SuggestionId = data.SuggestionId;
				                item.OpenId = data.OpenId;
				                item.PersonName = data.PersonName;
				                item.Tel = data.Tel;
				                item.Email = data.Email;
				                item.SuggestText = data.SuggestText;
				                item.SuggestDateTime = data.SuggestDateTime;
				                item.IsReaded = data.IsReaded;
				                item.IsReplyed = data.IsReplyed;
				                item.ReplyText = data.ReplyText;
				                item.ReplyDateTime = data.ReplyDateTime;
				                item.IsClose = data.IsClose;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FE_Suggestion>();
                var i = (from p in ctx.DataContext.FE_Suggestion.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.SuggestionId = i.SuggestionId;
										this.OpenId = i.OpenId;
										this.PersonName = i.PersonName;
										this.Tel = i.Tel;
										this.Email = i.Email;
										this.SuggestText = i.SuggestText;
										this.SuggestDateTime = i.SuggestDateTime;
										this.IsReaded = i.IsReaded;
										this.IsReplyed = i.IsReplyed;
										this.ReplyText = i.ReplyText;
										this.ReplyDateTime = i.ReplyDateTime;
										this.IsClose = i.IsClose;
					}
            }
        }
	}

	public class FE_SuggestionsFactory : Common.Business.FE_Suggestions
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FE_Suggestion
                        select FE_SuggestionFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FE_Suggestion
                        select FE_SuggestionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FE_Suggestion>();
                var i = (from p in ctx.DataContext.FE_Suggestion.Where(exp)
                         select FE_SuggestionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FE_Suggestion>();
                var i = from p in ctx.DataContext.FE_Suggestion.Where(exp)
                         select FE_SuggestionFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
