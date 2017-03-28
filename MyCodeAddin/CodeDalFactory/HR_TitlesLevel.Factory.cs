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
	public class HR_TitlesLevelFactory:Common.Business.HR_TitlesLevel
    {
        public static Common.Business.HR_TitlesLevel Fetch(HR_TitlesLevel data)
        {
            Common.Business.HR_TitlesLevel item = (Common.Business.HR_TitlesLevel)Activator.CreateInstance(typeof(Common.Business.HR_TitlesLevel));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TitlesLevelCode = data.TitlesLevelCode;
				                item.TitlesLevelName = data.TitlesLevelName;
				                item.Memo = data.Memo;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_TitlesLevel>();
                var i = (from p in ctx.DataContext.HR_TitlesLevel.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TitlesLevelCode = i.TitlesLevelCode;
										this.TitlesLevelName = i.TitlesLevelName;
										this.Memo = i.Memo;
					}
            }
        }
	}

	public class HR_TitlesLevelsFactory : Common.Business.HR_TitlesLevels
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_TitlesLevel
                        select HR_TitlesLevelFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_TitlesLevel
                        select HR_TitlesLevelFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_TitlesLevel>();
                var i = (from p in ctx.DataContext.HR_TitlesLevel.Where(exp)
                         select HR_TitlesLevelFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_TitlesLevel>();
                var i = from p in ctx.DataContext.HR_TitlesLevel.Where(exp)
                         select HR_TitlesLevelFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
