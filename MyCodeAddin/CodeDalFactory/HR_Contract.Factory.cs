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
	public class HR_ContractFactory:Common.Business.HR_Contract
    {
        public static Common.Business.HR_Contract Fetch(HR_Contract data)
        {
            Common.Business.HR_Contract item = (Common.Business.HR_Contract)Activator.CreateInstance(typeof(Common.Business.HR_Contract));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ContractNo = data.ContractNo;
				                item.ContractType = data.ContractType;
				                item.ContractText = data.ContractText;
				                item.EmpCode = data.EmpCode;
				                item.EmpName = data.EmpName;
				                item.IdType = data.IdType;
				                item.IdNo = data.IdNo;
				                item.DepCode = data.DepCode;
				                item.PositionCode = data.PositionCode;
				                item.EmpTypeCode = data.EmpTypeCode;
				                item.StaffTypeCode = data.StaffTypeCode;
				                item.StartDate = data.StartDate;
				                item.EndDate = data.EndDate;
				                item.PostTypeCode = data.PostTypeCode;
				                item.SalaryRangeCode = data.SalaryRangeCode;
				                item.PostCode = data.PostCode;
				                item.TitleCode = data.TitleCode;
				                item.SalaryLevel = data.SalaryLevel;
				                item.FileNo = data.FileNo;
				                item.ContractUrl = data.ContractUrl;
				                item.IsNewContract = data.IsNewContract;
				                item.IsSubmit = data.IsSubmit;
				                item.IsEmp = data.IsEmp;
				                item.IsAppovel = data.IsAppovel;
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
				var exp = lambda.Resolve<HR_Contract>();
                var i = (from p in ctx.DataContext.HR_Contract.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ContractNo = i.ContractNo;
										this.ContractType = i.ContractType;
										this.ContractText = i.ContractText;
										this.EmpCode = i.EmpCode;
										this.EmpName = i.EmpName;
										this.IdType = i.IdType;
										this.IdNo = i.IdNo;
										this.DepCode = i.DepCode;
										this.PositionCode = i.PositionCode;
										this.EmpTypeCode = i.EmpTypeCode;
										this.StaffTypeCode = i.StaffTypeCode;
										this.StartDate = i.StartDate;
										this.EndDate = i.EndDate;
										this.PostTypeCode = i.PostTypeCode;
										this.SalaryRangeCode = i.SalaryRangeCode;
										this.PostCode = i.PostCode;
										this.TitleCode = i.TitleCode;
										this.SalaryLevel = i.SalaryLevel;
										this.FileNo = i.FileNo;
										this.ContractUrl = i.ContractUrl;
										this.IsNewContract = i.IsNewContract;
										this.IsSubmit = i.IsSubmit;
										this.IsEmp = i.IsEmp;
										this.IsAppovel = i.IsAppovel;
										this.RowStatus = i.RowStatus;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_ContractsFactory : Common.Business.HR_Contracts
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Contract
                        select HR_ContractFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Contract
                        select HR_ContractFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Contract>();
                var i = (from p in ctx.DataContext.HR_Contract.Where(exp)
                         select HR_ContractFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Contract>();
                var i = from p in ctx.DataContext.HR_Contract.Where(exp)
                         select HR_ContractFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
