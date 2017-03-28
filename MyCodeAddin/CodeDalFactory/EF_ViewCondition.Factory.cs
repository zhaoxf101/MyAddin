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
	public class EF_ViewConditionFactory:Common.Business.EF_ViewCondition
    {
        public static Common.Business.EF_ViewCondition Fetch(EF_ViewCondition data)
        {
            Common.Business.EF_ViewCondition item = (Common.Business.EF_ViewCondition)Activator.CreateInstance(typeof(Common.Business.EF_ViewCondition));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.ViewName = data.ViewName;
				                item.RowStatus = data.RowStatus;
				                item.Position = data.Position;
				                item.TableName = data.TableName;
				                item.FieldName = data.FieldName;
				                item.Negation = data.Negation;
				                item.Operator = data.Operator;
				                item.Constants = data.Constants;
				                item.AndOr = data.AndOr;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<EF_ViewCondition>();
                var i = (from p in ctx.DataContext.EF_ViewCondition.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.ViewName = i.ViewName;
										this.RowStatus = i.RowStatus;
										this.Position = i.Position;
										this.TableName = i.TableName;
										this.FieldName = i.FieldName;
										this.Negation = i.Negation;
										this.Operator = i.Operator;
										this.Constants = i.Constants;
										this.AndOr = i.AndOr;
					}
            }
        }
	}

	public class EF_ViewConditionsFactory : Common.Business.EF_ViewConditions
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EF_ViewCondition
                        select EF_ViewConditionFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EF_ViewCondition
                        select EF_ViewConditionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EF_ViewCondition>();
                var i = (from p in ctx.DataContext.EF_ViewCondition.Where(exp)
                         select EF_ViewConditionFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EF_ViewCondition>();
                var i = from p in ctx.DataContext.EF_ViewCondition.Where(exp)
                         select EF_ViewConditionFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
