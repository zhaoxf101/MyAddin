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
	public class HR_Titles_OldFactory:Common.Business.HR_Titles_Old
    {
        public static Common.Business.HR_Titles_Old Fetch(HR_Titles_Old data)
        {
            Common.Business.HR_Titles_Old item = (Common.Business.HR_Titles_Old)Activator.CreateInstance(typeof(Common.Business.HR_Titles_Old));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TitlesCode = data.TitlesCode;
				                item.TitlesName = data.TitlesName;
				                item.TitlesType = data.TitlesType;
				                item.TitlesLevelCode = data.TitlesLevelCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_Titles_Old>();
                var i = (from p in ctx.DataContext.HR_Titles_Old.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TitlesCode = i.TitlesCode;
										this.TitlesName = i.TitlesName;
										this.TitlesType = i.TitlesType;
										this.TitlesLevelCode = i.TitlesLevelCode;
					}
            }
        }
	}

	public class HR_Titles_OldsFactory : Common.Business.HR_Titles_Olds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Titles_Old
                        select HR_Titles_OldFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Titles_Old
                        select HR_Titles_OldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Titles_Old>();
                var i = (from p in ctx.DataContext.HR_Titles_Old.Where(exp)
                         select HR_Titles_OldFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Titles_Old>();
                var i = from p in ctx.DataContext.HR_Titles_Old.Where(exp)
                         select HR_Titles_OldFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
