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
	public class EQ_LabFactory:Common.Business.EQ_Lab
    {
        public static Common.Business.EQ_Lab Fetch(EQ_Lab data)
        {
            Common.Business.EQ_Lab item = (Common.Business.EQ_Lab)Activator.CreateInstance(typeof(Common.Business.EQ_Lab));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.LabNo = data.LabNo;
				                item.LabName = data.LabName;
				                item.LabLevCode = data.LabLevCode;
				                item.DepCode = data.DepCode;
				                item.LPersonId = data.LPersonId;
				                item.Location = data.Location;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<EQ_Lab>();
                var i = (from p in ctx.DataContext.EQ_Lab.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.LabNo = i.LabNo;
										this.LabName = i.LabName;
										this.LabLevCode = i.LabLevCode;
										this.DepCode = i.DepCode;
										this.LPersonId = i.LPersonId;
										this.Location = i.Location;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EQ_LabsFactory : Common.Business.EQ_Labs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EQ_Lab
                        select EQ_LabFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EQ_Lab
                        select EQ_LabFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EQ_Lab>();
                var i = (from p in ctx.DataContext.EQ_Lab.Where(exp)
                         select EQ_LabFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EQ_Lab>();
                var i = from p in ctx.DataContext.EQ_Lab.Where(exp)
                         select EQ_LabFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
