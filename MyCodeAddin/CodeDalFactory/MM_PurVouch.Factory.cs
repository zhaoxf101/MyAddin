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
	public class MM_PurVouchFactory:Common.Business.MM_PurVouch
    {
        public static Common.Business.MM_PurVouch Fetch(MM_PurVouch data)
        {
            Common.Business.MM_PurVouch item = (Common.Business.MM_PurVouch)Activator.CreateInstance(typeof(Common.Business.MM_PurVouch));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PurVouchNo = data.PurVouchNo;
				                item.BSTYP = data.BSTYP;
				                item.BSART = data.BSART;
				                item.BSAKZ = data.BSAKZ;
				                item.LOEKZ = data.LOEKZ;
				                item.STATU = data.STATU;
				                item.LPONR = data.LPONR;
				                item.VendorCode = data.VendorCode;
				                item.ZTERM = data.ZTERM;
				                item.ZBD1T = data.ZBD1T;
				                item.ZBD2T = data.ZBD2T;
				                item.ZBD3T = data.ZBD3T;
				                item.ZBD1P = data.ZBD1P;
				                item.ZBD2P = data.ZBD2P;
				                item.PurchaseGrp = data.PurchaseGrp;
				                item.Curr = data.Curr;
				                item.Rate = data.Rate;
				                item.KUFIX = data.KUFIX;
				                item.BEDAT = data.BEDAT;
				                item.KDATB = data.KDATB;
				                item.KDATE = data.KDATE;
				                item.BWBDT = data.BWBDT;
				                item.ANGDT = data.ANGDT;
				                item.BNDDT = data.BNDDT;
				                item.GWLDT = data.GWLDT;
				                item.AUSNR = data.AUSNR;
				                item.ANGNR = data.ANGNR;
				                item.IHRAN = data.IHRAN;
				                item.VERKF = data.VERKF;
				                item.TELF1 = data.TELF1;
				                item.KONNR = data.KONNR;
				                item.WEAKT = data.WEAKT;
				                item.STCEG = data.STCEG;
				                item.ABSGR = data.ABSGR;
				                item.ADDNR = data.ADDNR;
				                item.PROCSTAT = data.PROCSTAT;
				                item.RLWRT = data.RLWRT;
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
				var exp = lambda.Resolve<MM_PurVouch>();
                var i = (from p in ctx.DataContext.MM_PurVouch.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PurVouchNo = i.PurVouchNo;
										this.BSTYP = i.BSTYP;
										this.BSART = i.BSART;
										this.BSAKZ = i.BSAKZ;
										this.LOEKZ = i.LOEKZ;
										this.STATU = i.STATU;
										this.LPONR = i.LPONR;
										this.VendorCode = i.VendorCode;
										this.ZTERM = i.ZTERM;
										this.ZBD1T = i.ZBD1T;
										this.ZBD2T = i.ZBD2T;
										this.ZBD3T = i.ZBD3T;
										this.ZBD1P = i.ZBD1P;
										this.ZBD2P = i.ZBD2P;
										this.PurchaseGrp = i.PurchaseGrp;
										this.Curr = i.Curr;
										this.Rate = i.Rate;
										this.KUFIX = i.KUFIX;
										this.BEDAT = i.BEDAT;
										this.KDATB = i.KDATB;
										this.KDATE = i.KDATE;
										this.BWBDT = i.BWBDT;
										this.ANGDT = i.ANGDT;
										this.BNDDT = i.BNDDT;
										this.GWLDT = i.GWLDT;
										this.AUSNR = i.AUSNR;
										this.ANGNR = i.ANGNR;
										this.IHRAN = i.IHRAN;
										this.VERKF = i.VERKF;
										this.TELF1 = i.TELF1;
										this.KONNR = i.KONNR;
										this.WEAKT = i.WEAKT;
										this.STCEG = i.STCEG;
										this.ABSGR = i.ABSGR;
										this.ADDNR = i.ADDNR;
										this.PROCSTAT = i.PROCSTAT;
										this.RLWRT = i.RLWRT;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class MM_PurVouchsFactory : Common.Business.MM_PurVouchs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_PurVouch
                        select MM_PurVouchFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_PurVouch
                        select MM_PurVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_PurVouch>();
                var i = (from p in ctx.DataContext.MM_PurVouch.Where(exp)
                         select MM_PurVouchFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_PurVouch>();
                var i = from p in ctx.DataContext.MM_PurVouch.Where(exp)
                         select MM_PurVouchFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
