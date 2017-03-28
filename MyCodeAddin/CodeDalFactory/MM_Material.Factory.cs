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
	public class MM_MaterialFactory:Common.Business.MM_Material
    {
        public static Common.Business.MM_Material Fetch(MM_Material data)
        {
            Common.Business.MM_Material item = (Common.Business.MM_Material)Activator.CreateInstance(typeof(Common.Business.MM_Material));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MaterialCode = data.MaterialCode;
				                item.LText = data.LText;
				                item.IsDel = data.IsDel;
				                item.MatType = data.MatType;
				                item.MatGrp = data.MatGrp;
				                item.OldMatCode = data.OldMatCode;
				                item.UnitCode = data.UnitCode;
				                item.BUnitCode = data.BUnitCode;
				                item.RoughWT = data.RoughWT;
				                item.NetWT = data.NetWT;
				                item.WTUnit = data.WTUnit;
				                item.VOLUnit = data.VOLUnit;
				                item.Container = data.Container;
				                item.Len = data.Len;
				                item.Width = data.Width;
				                item.High = data.High;
				                item.LenUnit = data.LenUnit;
				                item.KZKUP = data.KZKUP;
				                item.DelDate = data.DelDate;
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
				var exp = lambda.Resolve<MM_Material>();
                var i = (from p in ctx.DataContext.MM_Material.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MaterialCode = i.MaterialCode;
										this.LText = i.LText;
										this.IsDel = i.IsDel;
										this.MatType = i.MatType;
										this.MatGrp = i.MatGrp;
										this.OldMatCode = i.OldMatCode;
										this.UnitCode = i.UnitCode;
										this.BUnitCode = i.BUnitCode;
										this.RoughWT = i.RoughWT;
										this.NetWT = i.NetWT;
										this.WTUnit = i.WTUnit;
										this.VOLUnit = i.VOLUnit;
										this.Container = i.Container;
										this.Len = i.Len;
										this.Width = i.Width;
										this.High = i.High;
										this.LenUnit = i.LenUnit;
										this.KZKUP = i.KZKUP;
										this.DelDate = i.DelDate;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class MM_MaterialsFactory : Common.Business.MM_Materials
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_Material
                        select MM_MaterialFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_Material
                        select MM_MaterialFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_Material>();
                var i = (from p in ctx.DataContext.MM_Material.Where(exp)
                         select MM_MaterialFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_Material>();
                var i = from p in ctx.DataContext.MM_Material.Where(exp)
                         select MM_MaterialFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
