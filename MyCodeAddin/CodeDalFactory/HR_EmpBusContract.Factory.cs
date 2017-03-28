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
	public class HR_EmpBusContractFactory:Common.Business.HR_EmpBusContract
    {
        public static Common.Business.HR_EmpBusContract Fetch(HR_EmpBusContract data)
        {
            Common.Business.HR_EmpBusContract item = (Common.Business.HR_EmpBusContract)Activator.CreateInstance(typeof(Common.Business.HR_EmpBusContract));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
				                item.EmpBusNo = data.EmpBusNo;
				                item.EmpCode = data.EmpCode;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.ContractNo = data.ContractNo;
				                item.ContractText = data.ContractText;
				                item.EmpTypeCode = data.EmpTypeCode;
				                item.StaffTypeCode = data.StaffTypeCode;
				                item.Memo = data.Memo;
				                item.DepCode = data.DepCode;
				                item.ContractTypeCode = data.ContractTypeCode;
				                item.EndReason = data.EndReason;
				                item.EndText = data.EndText;
				                item.ActionType = data.ActionType;
				                item.OldId = data.OldId;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpBusContract>();
                var i = (from p in ctx.DataContext.HR_EmpBusContract.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
										this.EmpBusNo = i.EmpBusNo;
										this.EmpCode = i.EmpCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.ContractNo = i.ContractNo;
										this.ContractText = i.ContractText;
										this.EmpTypeCode = i.EmpTypeCode;
										this.StaffTypeCode = i.StaffTypeCode;
										this.Memo = i.Memo;
										this.DepCode = i.DepCode;
										this.ContractTypeCode = i.ContractTypeCode;
										this.EndReason = i.EndReason;
										this.EndText = i.EndText;
										this.ActionType = i.ActionType;
										this.OldId = i.OldId;
					}
            }
        }
	}

	public class HR_EmpBusContractsFactory : Common.Business.HR_EmpBusContracts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpBusContract
                        select HR_EmpBusContractFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpBusContract
                        select HR_EmpBusContractFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpBusContract>();
                var i = (from p in ctx.DataContext.HR_EmpBusContract.Where(exp)
                         select HR_EmpBusContractFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpBusContract>();
                var i = from p in ctx.DataContext.HR_EmpBusContract.Where(exp)
                         select HR_EmpBusContractFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
