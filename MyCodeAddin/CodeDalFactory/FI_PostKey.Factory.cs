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
	public class FI_PostKeyFactory:Common.Business.FI_PostKey
    {
        public static Common.Business.FI_PostKey Fetch(FI_PostKey data)
        {
            Common.Business.FI_PostKey item = (Common.Business.FI_PostKey)Activator.CreateInstance(typeof(Common.Business.FI_PostKey));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.PostKey = data.PostKey;
				                item.DeCrX = data.DeCrX;
				                item.AccCls = data.AccCls;
				                item.AccType = data.AccType;
				                item.OffsetKey = data.OffsetKey;
				                item.BPostKey = data.BPostKey;
				                item.FundMark = data.FundMark;
				                item.PostBus = data.PostBus;
				                item.GovPayX = data.GovPayX;
				                item.Status = data.Status;
				                item.DText = data.DText;
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
				var exp = lambda.Resolve<FI_PostKey>();
                var i = (from p in ctx.DataContext.FI_PostKey.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.PostKey = i.PostKey;
										this.DeCrX = i.DeCrX;
										this.AccCls = i.AccCls;
										this.AccType = i.AccType;
										this.OffsetKey = i.OffsetKey;
										this.BPostKey = i.BPostKey;
										this.FundMark = i.FundMark;
										this.PostBus = i.PostBus;
										this.GovPayX = i.GovPayX;
										this.Status = i.Status;
										this.DText = i.DText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_PostKeysFactory : Common.Business.FI_PostKeys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_PostKey
                        select FI_PostKeyFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_PostKey
                        select FI_PostKeyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_PostKey>();
                var i = (from p in ctx.DataContext.FI_PostKey.Where(exp)
                         select FI_PostKeyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_PostKey>();
                var i = from p in ctx.DataContext.FI_PostKey.Where(exp)
                         select FI_PostKeyFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
