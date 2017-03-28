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
	public class HR_EmpBusBaseFactory:Common.Business.HR_EmpBusBase
    {
        public static Common.Business.HR_EmpBusBase Fetch(HR_EmpBusBase data)
        {
            Common.Business.HR_EmpBusBase item = (Common.Business.HR_EmpBusBase)Activator.CreateInstance(typeof(Common.Business.HR_EmpBusBase));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.BusBillNo = data.BusBillNo;
				                item.EmpCode = data.EmpCode;
				                item.EmpName = data.EmpName;
				                item.IdType = data.IdType;
				                item.IdNo = data.IdNo;
				                item.Hometown = data.Hometown;
				                item.Sex = data.Sex;
				                item.Politics = data.Politics;
				                item.Birthday = data.Birthday;
				                item.Country = data.Country;
				                item.HomeAddr = data.HomeAddr;
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
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<HR_EmpBusBase>();
                var i = (from p in ctx.DataContext.HR_EmpBusBase.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.BusBillNo = i.BusBillNo;
										this.EmpCode = i.EmpCode;
										this.EmpName = i.EmpName;
										this.IdType = i.IdType;
										this.IdNo = i.IdNo;
										this.Hometown = i.Hometown;
										this.Sex = i.Sex;
										this.Politics = i.Politics;
										this.Birthday = i.Birthday;
										this.Country = i.Country;
										this.HomeAddr = i.HomeAddr;
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
					}
            }
        }
	}

	public class HR_EmpBusBasesFactory : Common.Business.HR_EmpBusBases
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_EmpBusBase
                        select HR_EmpBusBaseFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_EmpBusBase
                        select HR_EmpBusBaseFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_EmpBusBase>();
                var i = (from p in ctx.DataContext.HR_EmpBusBase.Where(exp)
                         select HR_EmpBusBaseFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_EmpBusBase>();
                var i = from p in ctx.DataContext.HR_EmpBusBase.Where(exp)
                         select HR_EmpBusBaseFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
