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
	public class HR_ExternalerFactory:Common.Business.HR_Externaler
    {
        public static Common.Business.HR_Externaler Fetch(HR_Externaler data)
        {
            Common.Business.HR_Externaler item = (Common.Business.HR_Externaler)Activator.CreateInstance(typeof(Common.Business.HR_Externaler));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ExternalNo = data.ExternalNo;
				                item.PersonId = data.PersonId;
				                item.ExternalName = data.ExternalName;
				                item.IDCardTypeCode = data.IDCardTypeCode;
				                item.IDCardNo = data.IDCardNo;
				                item.Sex = data.Sex;
				                item.Country = data.Country;
				                item.Nation = data.Nation;
				                item.Hometown = data.Hometown;
				                item.Birth = data.Birth;
				                item.Addr = data.Addr;
				                item.Photo = data.Photo;
				                item.Tel = data.Tel;
				                item.MobTel = data.MobTel;
				                item.Email = data.Email;
				                item.Memo = data.Memo;
				                item.OneTime = data.OneTime;
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
				var exp = lambda.Resolve<HR_Externaler>();
                var i = (from p in ctx.DataContext.HR_Externaler.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ExternalNo = i.ExternalNo;
										this.PersonId = i.PersonId;
										this.ExternalName = i.ExternalName;
										this.IDCardTypeCode = i.IDCardTypeCode;
										this.IDCardNo = i.IDCardNo;
										this.Sex = i.Sex;
										this.Country = i.Country;
										this.Nation = i.Nation;
										this.Hometown = i.Hometown;
										this.Birth = i.Birth;
										this.Addr = i.Addr;
										this.Photo = i.Photo;
										this.Tel = i.Tel;
										this.MobTel = i.MobTel;
										this.Email = i.Email;
										this.Memo = i.Memo;
										this.OneTime = i.OneTime;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_ExternalersFactory : Common.Business.HR_Externalers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Externaler
                        select HR_ExternalerFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Externaler
                        select HR_ExternalerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Externaler>();
                var i = (from p in ctx.DataContext.HR_Externaler.Where(exp)
                         select HR_ExternalerFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Externaler>();
                var i = from p in ctx.DataContext.HR_Externaler.Where(exp)
                         select HR_ExternalerFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
