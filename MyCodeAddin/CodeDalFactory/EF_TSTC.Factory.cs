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
	public class EF_TSTCFactory:Common.Business.EF_TSTC
    {
        public static Common.Business.EF_TSTC Fetch(EF_TSTC data)
        {
            Common.Business.EF_TSTC item = (Common.Business.EF_TSTC)Activator.CreateInstance(typeof(Common.Business.EF_TSTC));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.TCode = data.TCode;
				                item.UIType = data.UIType;
				                item.DText = data.DText;
				                item.PgmName = data.PgmName;
				                item.WebURL = data.WebURL;
				                item.Share = data.Share;
				                item.CallParams = data.CallParams;
				                item.CreatedUser = data.CreatedUser;
				                item.CreatedDate = data.CreatedDate;
				                item.ChangedUser = data.ChangedUser;
				                item.ChangedDate = data.ChangedDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_TSTC>();
                var i = (from p in ctx.DataContext.EF_TSTC.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.TCode = i.TCode;
										this.UIType = i.UIType;
										this.DText = i.DText;
										this.PgmName = i.PgmName;
										this.WebURL = i.WebURL;
										this.Share = i.Share;
										this.CallParams = i.CallParams;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_TSTCsFactory : Common.Business.EF_TSTCs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_TSTC
                        select EF_TSTCFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_TSTC
                        select EF_TSTCFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_TSTC>();
                var i = (from p in ctx.DataContext.EF_TSTC.Where(exp)
                         select EF_TSTCFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_TSTC>();
                var i = from p in ctx.DataContext.EF_TSTC.Where(exp)
                         select EF_TSTCFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
