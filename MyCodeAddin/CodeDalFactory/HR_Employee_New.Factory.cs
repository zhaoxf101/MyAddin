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
	public class HR_Employee_NewFactory:Common.Business.HR_Employee_New
    {
        public static Common.Business.HR_Employee_New Fetch(HR_Employee_New data)
        {
            Common.Business.HR_Employee_New item = (Common.Business.HR_Employee_New)Activator.CreateInstance(typeof(Common.Business.HR_Employee_New));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.EmpCode = data.EmpCode;
				                item.EmpName = data.EmpName;
				                item.IdType = data.IdType;
				                item.IdNo = data.IdNo;
				                item.Hometown = data.Hometown;
				                item.Sex = data.Sex;
				                item.Politics = data.Politics;
				                item.Birthday = data.Birthday;
				                item.Country = data.Country;
				                item.HomeAddress = data.HomeAddress;
				                item.Nation = data.Nation;
				                item.Tel = data.Tel;
				                item.Email = data.Email;
				                item.WeChatNo = data.WeChatNo;
				                item.QQNo = data.QQNo;
				                item.ImageUrl = data.ImageUrl;
				                item.IsInsReturn = data.IsInsReturn;
				                item.IsSalReturn = data.IsSalReturn;
				                item.PostTypeCode1 = data.PostTypeCode1;
				                item.PostTypeCode2 = data.PostTypeCode2;
				                item.SalaryRangeCode = data.SalaryRangeCode;
				                item.UsedName = data.UsedName;
				                item.ContactAddress = data.ContactAddress;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<HR_Employee_New>();
                var i = (from p in ctx.DataContext.HR_Employee_New.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.EmpCode = i.EmpCode;
										this.EmpName = i.EmpName;
										this.IdType = i.IdType;
										this.IdNo = i.IdNo;
										this.Hometown = i.Hometown;
										this.Sex = i.Sex;
										this.Politics = i.Politics;
										this.Birthday = i.Birthday;
										this.Country = i.Country;
										this.HomeAddress = i.HomeAddress;
										this.Nation = i.Nation;
										this.Tel = i.Tel;
										this.Email = i.Email;
										this.WeChatNo = i.WeChatNo;
										this.QQNo = i.QQNo;
										this.ImageUrl = i.ImageUrl;
										this.IsInsReturn = i.IsInsReturn;
										this.IsSalReturn = i.IsSalReturn;
										this.PostTypeCode1 = i.PostTypeCode1;
										this.PostTypeCode2 = i.PostTypeCode2;
										this.SalaryRangeCode = i.SalaryRangeCode;
										this.UsedName = i.UsedName;
										this.ContactAddress = i.ContactAddress;
										this.Memo = i.Memo;
										this.RowStatus = i.RowStatus;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_Employee_NewsFactory : Common.Business.HR_Employee_News
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Employee_New
                        select HR_Employee_NewFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Employee_New
                        select HR_Employee_NewFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Employee_New>();
                var i = (from p in ctx.DataContext.HR_Employee_New.Where(exp)
                         select HR_Employee_NewFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Employee_New>();
                var i = from p in ctx.DataContext.HR_Employee_New.Where(exp)
                         select HR_Employee_NewFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
