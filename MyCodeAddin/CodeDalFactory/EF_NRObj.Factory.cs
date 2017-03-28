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
	public class EF_NRObjFactory:Common.Business.EF_NRObj
    {
        public static Common.Business.EF_NRObj Fetch(EF_NRObj data)
        {
            Common.Business.EF_NRObj item = (Common.Business.EF_NRObj)Activator.CreateInstance(typeof(Common.Business.EF_NRObj));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.NRObject = data.NRObject;
				                item.DText = data.DText;
				                item.PidType = data.PidType;
				                item.PidToPrefix = data.PidToPrefix;
				                item.Buffer = data.Buffer;
				                item.BufferSize = data.BufferSize;
				                item.SerialLen = data.SerialLen;
				                item.Single = data.Single;
				                item.Reusable = data.Reusable;
				                item.TimeStamp = data.TimeStamp;
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
				var exp = lambda.Resolve<EF_NRObj>();
                var i = (from p in ctx.DataContext.EF_NRObj.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.NRObject = i.NRObject;
										this.DText = i.DText;
										this.PidType = i.PidType;
										this.PidToPrefix = i.PidToPrefix;
										this.Buffer = i.Buffer;
										this.BufferSize = i.BufferSize;
										this.SerialLen = i.SerialLen;
										this.Single = i.Single;
										this.Reusable = i.Reusable;
										this.TimeStamp = i.TimeStamp;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EF_NRObjsFactory : Common.Business.EF_NRObjs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_NRObj
                        select EF_NRObjFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_NRObj
                        select EF_NRObjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_NRObj>();
                var i = (from p in ctx.DataContext.EF_NRObj.Where(exp)
                         select EF_NRObjFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_NRObj>();
                var i = from p in ctx.DataContext.EF_NRObj.Where(exp)
                         select EF_NRObjFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
