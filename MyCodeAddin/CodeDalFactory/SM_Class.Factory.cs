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
	public class SM_ClassFactory:Common.Business.SM_Class
    {
        public static Common.Business.SM_Class Fetch(SM_Class data)
        {
            Common.Business.SM_Class item = (Common.Business.SM_Class)Activator.CreateInstance(typeof(Common.Business.SM_Class));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ClassCode = data.ClassCode;
				                item.Year = data.Year;
				                item.DegreeCode = data.DegreeCode;
				                item.ClassName = data.ClassName;
				                item.DepartCode = data.DepartCode;
				                item.SpecialityCode = data.SpecialityCode;
				                item.EntranceDate = data.EntranceDate;
				                item.EntDate = data.EntDate;
				                item.Grade = data.Grade;
				                item.Graduated = data.Graduated;
				                item.FeeTypeCode = data.FeeTypeCode;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
				                item.IsExternal = data.IsExternal;
				                item.IsConEdu = data.IsConEdu;
				                item.IsTuiAllot = data.IsTuiAllot;
				                item.Memo = data.Memo;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
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
				var exp = lambda.Resolve<SM_Class>();
                var i = (from p in ctx.DataContext.SM_Class.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ClassCode = i.ClassCode;
										this.Year = i.Year;
										this.DegreeCode = i.DegreeCode;
										this.ClassName = i.ClassName;
										this.DepartCode = i.DepartCode;
										this.SpecialityCode = i.SpecialityCode;
										this.EntranceDate = i.EntranceDate;
										this.EntDate = i.EntDate;
										this.Grade = i.Grade;
										this.Graduated = i.Graduated;
										this.FeeTypeCode = i.FeeTypeCode;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
										this.IsExternal = i.IsExternal;
										this.IsConEdu = i.IsConEdu;
										this.IsTuiAllot = i.IsTuiAllot;
										this.Memo = i.Memo;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class SM_ClasssFactory : Common.Business.SM_Classs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.SM_Class
                        select SM_ClassFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.SM_Class
                        select SM_ClassFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<SM_Class>();
                var i = (from p in ctx.DataContext.SM_Class.Where(exp)
                         select SM_ClassFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<SM_Class>();
                var i = from p in ctx.DataContext.SM_Class.Where(exp)
                         select SM_ClassFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
