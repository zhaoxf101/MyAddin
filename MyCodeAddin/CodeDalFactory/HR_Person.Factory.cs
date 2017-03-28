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
	public class HR_PersonFactory:Common.Business.HR_Person
    {
        public static Common.Business.HR_Person Fetch(HR_Person data)
        {
            Common.Business.HR_Person item = (Common.Business.HR_Person)Activator.CreateInstance(typeof(Common.Business.HR_Person));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PersonId = data.PersonId;
				                item.PersonName = data.PersonName;
				                item.UType = data.UType;
				                item.IDCardTypeCode = data.IDCardTypeCode;
				                item.IDCardNo = data.IDCardNo;
				                item.Tel = data.Tel;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<HR_Person>();
                var i = (from p in ctx.DataContext.HR_Person.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PersonId = i.PersonId;
										this.PersonName = i.PersonName;
										this.UType = i.UType;
										this.IDCardTypeCode = i.IDCardTypeCode;
										this.IDCardNo = i.IDCardNo;
										this.Tel = i.Tel;
										this.Memo = i.Memo;
										this.Active = i.Active;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class HR_PersonsFactory : Common.Business.HR_Persons
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.HR_Person
                        select HR_PersonFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.HR_Person
                        select HR_PersonFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<HR_Person>();
                var i = (from p in ctx.DataContext.HR_Person.Where(exp)
                         select HR_PersonFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<HR_Person>();
                var i = from p in ctx.DataContext.HR_Person.Where(exp)
                         select HR_PersonFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
