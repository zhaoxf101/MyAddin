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
	public class CO_CostElemFactory:Common.Business.CO_CostElem
    {
        public static Common.Business.CO_CostElem Fetch(CO_CostElem data)
        {
            Common.Business.CO_CostElem item = (Common.Business.CO_CostElem)Activator.CreateInstance(typeof(Common.Business.CO_CostElem));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.CostArea = data.CostArea;
				                item.CostElem = data.CostElem;
				                item.CostElemType = data.CostElemType;
				                item.FirstElemX = data.FirstElemX;
				                item.PCAElemX = data.PCAElemX;
				                item.CostCtr = data.CostCtr;
				                item.SText = data.SText;
				                item.LText = data.LText;
				                item.WDelX = data.WDelX;
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
				var exp = lambda.Resolve<CO_CostElem>();
                var i = (from p in ctx.DataContext.CO_CostElem.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.CostArea = i.CostArea;
										this.CostElem = i.CostElem;
										this.CostElemType = i.CostElemType;
										this.FirstElemX = i.FirstElemX;
										this.PCAElemX = i.PCAElemX;
										this.CostCtr = i.CostCtr;
										this.SText = i.SText;
										this.LText = i.LText;
										this.WDelX = i.WDelX;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class CO_CostElemsFactory : Common.Business.CO_CostElems
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.CO_CostElem
                        select CO_CostElemFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.CO_CostElem
                        select CO_CostElemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<CO_CostElem>();
                var i = (from p in ctx.DataContext.CO_CostElem.Where(exp)
                         select CO_CostElemFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<CO_CostElem>();
                var i = from p in ctx.DataContext.CO_CostElem.Where(exp)
                         select CO_CostElemFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
