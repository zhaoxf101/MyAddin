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
	public class EQ_EquipmentFactory:Common.Business.EQ_Equipment
    {
        public static Common.Business.EQ_Equipment Fetch(EQ_Equipment data)
        {
            Common.Business.EQ_Equipment item = (Common.Business.EQ_Equipment)Activator.CreateInstance(typeof(Common.Business.EQ_Equipment));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EquCode = data.EquCode;
				                item.EquName = data.EquName;
				                item.EquTypeCode = data.EquTypeCode;
				                item.CorrCode1 = data.CorrCode1;
				                item.CorrCode2 = data.CorrCode2;
				                item.LabNo = data.LabNo;
				                item.AssCode = data.AssCode;
				                item.AssTypeCode = data.AssTypeCode;
				                item.MaterialCode = data.MaterialCode;
				                item.Worth = data.Worth;
				                item.Suppor = data.Suppor;
				                item.VendorCode = data.VendorCode;
				                item.ConstructDate = data.ConstructDate;
				                item.StartTime = data.StartTime;
				                item.Depositary = data.Depositary;
				                item.FixAssets = data.FixAssets;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
				                item.Memo = data.Memo;
				                item.State = data.State;
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
				var exp = lambda.Resolve<EQ_Equipment>();
                var i = (from p in ctx.DataContext.EQ_Equipment.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EquCode = i.EquCode;
										this.EquName = i.EquName;
										this.EquTypeCode = i.EquTypeCode;
										this.CorrCode1 = i.CorrCode1;
										this.CorrCode2 = i.CorrCode2;
										this.LabNo = i.LabNo;
										this.AssCode = i.AssCode;
										this.AssTypeCode = i.AssTypeCode;
										this.MaterialCode = i.MaterialCode;
										this.Worth = i.Worth;
										this.Suppor = i.Suppor;
										this.VendorCode = i.VendorCode;
										this.ConstructDate = i.ConstructDate;
										this.StartTime = i.StartTime;
										this.Depositary = i.Depositary;
										this.FixAssets = i.FixAssets;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.Memo = i.Memo;
										this.State = i.State;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class EQ_EquipmentsFactory : Common.Business.EQ_Equipments
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.EQ_Equipment
                        select EQ_EquipmentFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.EQ_Equipment
                        select EQ_EquipmentFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<EQ_Equipment>();
                var i = (from p in ctx.DataContext.EQ_Equipment.Where(exp)
                         select EQ_EquipmentFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<EQ_Equipment>();
                var i = from p in ctx.DataContext.EQ_Equipment.Where(exp)
                         select EQ_EquipmentFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
