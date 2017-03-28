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
	public class PM_ProjMemberFactory:Common.Business.PM_ProjMember
    {
        public static Common.Business.PM_ProjMember Fetch(PM_ProjMember data)
        {
            Common.Business.PM_ProjMember item = (Common.Business.PM_ProjMember)Activator.CreateInstance(typeof(Common.Business.PM_ProjMember));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.ProjCode = data.ProjCode;
				                item.ProjMemberNo = data.ProjMemberNo;
				                item.ProjMemberTypeCode = data.ProjMemberTypeCode;
				                item.PersonId = data.PersonId;
				                item.DepCode = data.DepCode;
				                item.CostCtr = data.CostCtr;
				                item.ProfitCtr = data.ProfitCtr;
				                item.IsPLeader = data.IsPLeader;
				                item.IsTLeader = data.IsTLeader;
				                item.CanBud = data.CanBud;
				                item.CanLoan = data.CanLoan;
				                item.CanExp = data.CanExp;
				                item.CanAppInv = data.CanAppInv;
				                item.Active = data.Active;
				                item.IsDel = data.IsDel;
				                item.Memo = data.Memo;
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
				var exp = lambda.Resolve<PM_ProjMember>();
                var i = (from p in ctx.DataContext.PM_ProjMember.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.ProjCode = i.ProjCode;
										this.ProjMemberNo = i.ProjMemberNo;
										this.ProjMemberTypeCode = i.ProjMemberTypeCode;
										this.PersonId = i.PersonId;
										this.DepCode = i.DepCode;
										this.CostCtr = i.CostCtr;
										this.ProfitCtr = i.ProfitCtr;
										this.IsPLeader = i.IsPLeader;
										this.IsTLeader = i.IsTLeader;
										this.CanBud = i.CanBud;
										this.CanLoan = i.CanLoan;
										this.CanExp = i.CanExp;
										this.CanAppInv = i.CanAppInv;
										this.Active = i.Active;
										this.IsDel = i.IsDel;
										this.Memo = i.Memo;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class PM_ProjMembersFactory : Common.Business.PM_ProjMembers
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.PM_ProjMember
                        select PM_ProjMemberFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.PM_ProjMember
                        select PM_ProjMemberFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<PM_ProjMember>();
                var i = (from p in ctx.DataContext.PM_ProjMember.Where(exp)
                         select PM_ProjMemberFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<PM_ProjMember>();
                var i = from p in ctx.DataContext.PM_ProjMember.Where(exp)
                         select PM_ProjMemberFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
