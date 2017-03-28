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
	public class Rpt_ProtertyFactory:Common.Business.Rpt_Proterty
    {
        public static Common.Business.Rpt_Proterty Fetch(Rpt_Proterty data)
        {
            Common.Business.Rpt_Proterty item = (Common.Business.Rpt_Proterty)Activator.CreateInstance(typeof(Common.Business.Rpt_Proterty));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PropertyId = data.PropertyId;
				                item.PropertyName = data.PropertyName;
				                item.AccType = data.AccType;
				                item.TableName = data.TableName;
				                item.FieldName = data.FieldName;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<Rpt_Proterty>();
                var i = (from p in ctx.DataContext.Rpt_Proterty.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PropertyId = i.PropertyId;
										this.PropertyName = i.PropertyName;
										this.AccType = i.AccType;
										this.TableName = i.TableName;
										this.FieldName = i.FieldName;
					}
            }
        }
	}

	public class Rpt_ProtertysFactory : Common.Business.Rpt_Protertys
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Rpt_Proterty
                        select Rpt_ProtertyFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Rpt_Proterty
                        select Rpt_ProtertyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Rpt_Proterty>();
                var i = (from p in ctx.DataContext.Rpt_Proterty.Where(exp)
                         select Rpt_ProtertyFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Rpt_Proterty>();
                var i = from p in ctx.DataContext.Rpt_Proterty.Where(exp)
                         select Rpt_ProtertyFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
