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
	public class HR_EmployeeBillFactory:Common.Business.HR_EmployeeBill
    {
        public static Common.Business.HR_EmployeeBill Fetch(HR_EmployeeBill data)
        {
            Common.Business.HR_EmployeeBill item = (Common.Business.HR_EmployeeBill)Activator.CreateInstance(typeof(Common.Business.HR_EmployeeBill));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ID = data.ID;
				                item.BillNo = data.BillNo;
				                item.EmpCode = data.EmpCode;
				                item.EmpName = data.EmpName;
				                item.IDType = data.IDType;
				                item.IDNo = data.IDNo;
				                item.Hometown = data.Hometown;
				                item.Sex = data.Sex;
				                item.Politics = data.Politics;
				                item.Birthday = data.Birthday;
				                item.Country = data.Country;
				                item.Addr = data.Addr;
				                item.Nation = data.Nation;
				                item.Tel = data.Tel;
				                item.Email = data.Email;
				                item.CreateUser = data.CreateUser;
				                item.CreateDate = data.CreateDate;
				                item.ChangeUser = data.ChangeUser;
				                item.ChangeDate = data.ChangeDate;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmployeeBill>();
                var i = (from p in ctx.DataContext.HR_EmployeeBill.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ID = i.ID;
										this.BillNo = i.BillNo;
										this.EmpCode = i.EmpCode;
										this.EmpName = i.EmpName;
										this.IDType = i.IDType;
										this.IDNo = i.IDNo;
										this.Hometown = i.Hometown;
										this.Sex = i.Sex;
										this.Politics = i.Politics;
										this.Birthday = i.Birthday;
										this.Country = i.Country;
										this.Addr = i.Addr;
										this.Nation = i.Nation;
										this.Tel = i.Tel;
										this.Email = i.Email;
										this.CreateUser = i.CreateUser;
										this.CreateDate = i.CreateDate;
										this.ChangeUser = i.ChangeUser;
										this.ChangeDate = i.ChangeDate;
					}
            }
        }
	}

	public class HR_EmployeeBillsFactory : Common.Business.HR_EmployeeBills
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmployeeBill
                        select HR_EmployeeBillFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmployeeBill
                        select HR_EmployeeBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmployeeBill>();
                var i = (from p in ctx.DataContext.HR_EmployeeBill.Where(exp)
                         select HR_EmployeeBillFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmployeeBill>();
                var i = from p in ctx.DataContext.HR_EmployeeBill.Where(exp)
                         select HR_EmployeeBillFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
