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
	public class HR_EduBackgroundFactory:Common.Business.HR_EduBackground
    {
        public static Common.Business.HR_EduBackground Fetch(HR_EduBackground data)
        {
            Common.Business.HR_EduBackground item = (Common.Business.HR_EduBackground)Activator.CreateInstance(typeof(Common.Business.HR_EduBackground));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.EduBackground = data.EduBackground;
				                item.EduBackgroundName = data.EduBackgroundName;
				                item.Flag = data.Flag;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EduBackground>();
                var i = (from p in ctx.DataContext.HR_EduBackground.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.EduBackground = i.EduBackground;
										this.EduBackgroundName = i.EduBackgroundName;
										this.Flag = i.Flag;
					}
            }
        }
	}

	public class HR_EduBackgroundsFactory : Common.Business.HR_EduBackgrounds
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EduBackground
                        select HR_EduBackgroundFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EduBackground
                        select HR_EduBackgroundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EduBackground>();
                var i = (from p in ctx.DataContext.HR_EduBackground.Where(exp)
                         select HR_EduBackgroundFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EduBackground>();
                var i = from p in ctx.DataContext.HR_EduBackground.Where(exp)
                         select HR_EduBackgroundFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
