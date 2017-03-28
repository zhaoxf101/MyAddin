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
	public class Sys_UnitFactory:Common.Business.Sys_Unit
    {
        public static Common.Business.Sys_Unit Fetch(Sys_Unit data)
        {
            Common.Business.Sys_Unit item = (Common.Business.Sys_Unit)Activator.CreateInstance(typeof(Common.Business.Sys_Unit));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.UnitCode = data.UnitCode;
				                item.UnitGrp = data.UnitGrp;
				                item.UnitName = data.UnitName;
				                item.LText = data.LText;
				                item.MSEHT = data.MSEHT;
				                item.MSEHE = data.MSEHE;
				                item.Primy = data.Primy;
				                item.ZAEHL = data.ZAEHL;
				                item.NENNR = data.NENNR;
				                item.Active = data.Active;
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
				var exp = lambda.Resolve<Sys_Unit>();
                var i = (from p in ctx.DataContext.Sys_Unit.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.UnitCode = i.UnitCode;
										this.UnitGrp = i.UnitGrp;
										this.UnitName = i.UnitName;
										this.LText = i.LText;
										this.MSEHT = i.MSEHT;
										this.MSEHE = i.MSEHE;
										this.Primy = i.Primy;
										this.ZAEHL = i.ZAEHL;
										this.NENNR = i.NENNR;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class Sys_UnitsFactory : Common.Business.Sys_Units
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.Sys_Unit
                        select Sys_UnitFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.Sys_Unit
                        select Sys_UnitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<Sys_Unit>();
                var i = (from p in ctx.DataContext.Sys_Unit.Where(exp)
                         select Sys_UnitFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<Sys_Unit>();
                var i = from p in ctx.DataContext.Sys_Unit.Where(exp)
                         select Sys_UnitFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
