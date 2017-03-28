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
	public class HR_RelationFactory:Common.Business.HR_Relation
    {
        public static Common.Business.HR_Relation Fetch(HR_Relation data)
        {
            Common.Business.HR_Relation item = (Common.Business.HR_Relation)Activator.CreateInstance(typeof(Common.Business.HR_Relation));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.RelationCode = data.RelationCode;
				                item.RelationName = data.RelationName;
				                item.IsOnly = data.IsOnly;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_Relation>();
                var i = (from p in ctx.DataContext.HR_Relation.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.RelationCode = i.RelationCode;
										this.RelationName = i.RelationName;
										this.IsOnly = i.IsOnly;
					}
            }
        }
	}

	public class HR_RelationsFactory : Common.Business.HR_Relations
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Relation
                        select HR_RelationFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Relation
                        select HR_RelationFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Relation>();
                var i = (from p in ctx.DataContext.HR_Relation.Where(exp)
                         select HR_RelationFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Relation>();
                var i = from p in ctx.DataContext.HR_Relation.Where(exp)
                         select HR_RelationFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
