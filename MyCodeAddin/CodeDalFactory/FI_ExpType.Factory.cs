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
	public class FI_ExpTypeFactory:Common.Business.FI_ExpType
    {
        public static Common.Business.FI_ExpType Fetch(FI_ExpType data)
        {
            Common.Business.FI_ExpType item = (Common.Business.FI_ExpType)Activator.CreateInstance(typeof(Common.Business.FI_ExpType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExpTypeCode = data.ExpTypeCode;
				                item.ExpTypeName = data.ExpTypeName;
				                item.ExpGroup = data.ExpGroup;
				                item.IsAutoProj = data.IsAutoProj;
				                item.IsProjWF = data.IsProjWF;
				                item.ProjCode = data.ProjCode;
				                item.TaskCode = data.TaskCode;
				                item.WorkFlowId = data.WorkFlowId;
				                item.IsEco = data.IsEco;
				                item.IsRes = data.IsRes;
				                item.AccCode = data.AccCode;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<FI_ExpType>();
                var i = (from p in ctx.DataContext.FI_ExpType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExpTypeCode = i.ExpTypeCode;
										this.ExpTypeName = i.ExpTypeName;
										this.ExpGroup = i.ExpGroup;
										this.IsAutoProj = i.IsAutoProj;
										this.IsProjWF = i.IsProjWF;
										this.ProjCode = i.ProjCode;
										this.TaskCode = i.TaskCode;
										this.WorkFlowId = i.WorkFlowId;
										this.IsEco = i.IsEco;
										this.IsRes = i.IsRes;
										this.AccCode = i.AccCode;
					}
            }
        }
	}

	public class FI_ExpTypesFactory : Common.Business.FI_ExpTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.FI_ExpType
                        select FI_ExpTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.FI_ExpType
                        select FI_ExpTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<FI_ExpType>();
                var i = (from p in ctx.DataContext.FI_ExpType.Where(exp)
                         select FI_ExpTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<FI_ExpType>();
                var i = from p in ctx.DataContext.FI_ExpType.Where(exp)
                         select FI_ExpTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
