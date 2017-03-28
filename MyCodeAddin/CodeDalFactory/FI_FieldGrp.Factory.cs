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
	public class FI_FieldGrpFactory:Common.Business.FI_FieldGrp
    {
        public static Common.Business.FI_FieldGrp Fetch(FI_FieldGrp data)
        {
            Common.Business.FI_FieldGrp item = (Common.Business.FI_FieldGrp)Activator.CreateInstance(typeof(Common.Business.FI_FieldGrp));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.FieldSet = data.FieldSet;
				                item.FieldGrp = data.FieldGrp;
				                item.DText = data.DText;
				                item.Status = data.Status;
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
				var exp = lambda.Resolve<FI_FieldGrp>();
                var i = (from p in ctx.DataContext.FI_FieldGrp.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.FieldSet = i.FieldSet;
										this.FieldGrp = i.FieldGrp;
										this.DText = i.DText;
										this.Status = i.Status;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class FI_FieldGrpsFactory : Common.Business.FI_FieldGrps
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_FieldGrp
                        select FI_FieldGrpFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_FieldGrp
                        select FI_FieldGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_FieldGrp>();
                var i = (from p in ctx.DataContext.FI_FieldGrp.Where(exp)
                         select FI_FieldGrpFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_FieldGrp>();
                var i = from p in ctx.DataContext.FI_FieldGrp.Where(exp)
                         select FI_FieldGrpFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
