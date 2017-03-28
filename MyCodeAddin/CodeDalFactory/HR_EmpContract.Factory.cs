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
	public class HR_EmpContractFactory:Common.Business.HR_EmpContract
    {
        public static Common.Business.HR_EmpContract Fetch(HR_EmpContract data)
        {
            Common.Business.HR_EmpContract item = (Common.Business.HR_EmpContract)Activator.CreateInstance(typeof(Common.Business.HR_EmpContract));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.Id = data.Id;
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
				                item.RowStatus = data.RowStatus;
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
				var exp = lambda.Resolve<HR_EmpContract>();
                var i = (from p in ctx.DataContext.HR_EmpContract.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.Id = i.Id;
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
										this.RowStatus = i.RowStatus;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_EmpContractsFactory : Common.Business.HR_EmpContracts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpContract
                        select HR_EmpContractFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpContract
                        select HR_EmpContractFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpContract>();
                var i = (from p in ctx.DataContext.HR_EmpContract.Where(exp)
                         select HR_EmpContractFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpContract>();
                var i = from p in ctx.DataContext.HR_EmpContract.Where(exp)
                         select HR_EmpContractFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
