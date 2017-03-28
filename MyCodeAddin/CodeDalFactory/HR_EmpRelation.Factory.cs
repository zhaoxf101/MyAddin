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
	public class HR_EmpRelationFactory:Common.Business.HR_EmpRelation
    {
        public static Common.Business.HR_EmpRelation Fetch(HR_EmpRelation data)
        {
            Common.Business.HR_EmpRelation item = (Common.Business.HR_EmpRelation)Activator.CreateInstance(typeof(Common.Business.HR_EmpRelation));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.EmpCode = data.EmpCode;
				                item.RelationCode = data.RelationCode;
				                item.RelationValue = data.RelationValue;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.DText = data.DText;
				                item.IsDel = data.IsDel;
				                item.CreateDate = data.CreateDate;
				                item.CreateUser = data.CreateUser;
				                item.ChangeDate = data.ChangeDate;
				                item.ChangeUser = data.ChangeUser;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpRelation>();
                var i = (from p in ctx.DataContext.HR_EmpRelation.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.EmpCode = i.EmpCode;
										this.RelationCode = i.RelationCode;
										this.RelationValue = i.RelationValue;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.DText = i.DText;
										this.IsDel = i.IsDel;
										this.CreateDate = i.CreateDate;
										this.CreateUser = i.CreateUser;
										this.ChangeDate = i.ChangeDate;
										this.ChangeUser = i.ChangeUser;
					}
            }
        }
	}

	public class HR_EmpRelationsFactory : Common.Business.HR_EmpRelations
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpRelation
                        select HR_EmpRelationFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpRelation
                        select HR_EmpRelationFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpRelation>();
                var i = (from p in ctx.DataContext.HR_EmpRelation.Where(exp)
                         select HR_EmpRelationFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpRelation>();
                var i = from p in ctx.DataContext.HR_EmpRelation.Where(exp)
                         select HR_EmpRelationFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
