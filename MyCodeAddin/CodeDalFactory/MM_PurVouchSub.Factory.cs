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
	public class MM_PurVouchSubFactory:Common.Business.MM_PurVouchSub
    {
        public static Common.Business.MM_PurVouchSub Fetch(MM_PurVouchSub data)
        {
            Common.Business.MM_PurVouchSub item = (Common.Business.MM_PurVouchSub)Activator.CreateInstance(typeof(Common.Business.MM_PurVouchSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.Client = data.Client;
				                item.PurVouchNo = data.PurVouchNo;
				                item.PVItemNo = data.PVItemNo;
				                item.IsDel = data.IsDel;
				                item.Materialcode = data.Materialcode;
				                item.Warehouse = data.Warehouse;
				                item.BEDNR = data.BEDNR;
				                item.MatType = data.MatType;
				                item.INFNR = data.INFNR;
				                item.IDNLF = data.IDNLF;
				                item.KTMNG = data.KTMNG;
				                item.MENGE = data.MENGE;
				                item.UnitCode = data.UnitCode;
				                item.PUnitCode = data.PUnitCode;
				                item.BPUMZ = data.BPUMZ;
				                item.BPUMN = data.BPUMN;
				                item.Price = data.Price;
				                item.NETWR = data.NETWR;
				                item.BRTWR = data.BRTWR;
				                item.MWSKZ = data.MWSKZ;
				                item.BONUS = data.BONUS;
				                item.INSMK = data.INSMK;
				                item.BWTAR = data.BWTAR;
				                item.BWTTY = data.BWTTY;
				                item.ABSKZ = data.ABSKZ;
				                item.ELIKZ = data.ELIKZ;
				                item.EREKZ = data.EREKZ;
				                item.PSTYP = data.PSTYP;
				                item.KNTTP = data.KNTTP;
				                item.KZVBR = data.KZVBR;
				                item.REPOS = data.REPOS;
				                item.KZABS = data.KZABS;
				                item.LABNR = data.LABNR;
				                item.KONNR = data.KONNR;
				                item.KTPNR = data.KTPNR;
				                item.ABDAT = data.ABDAT;
				                item.ABFTZ = data.ABFTZ;
				                item.BSTYP = data.BSTYP;
				                item.SKTOF = data.SKTOF;
				                item.PLIFZ = data.PLIFZ;
				                item.FPLNR = data.FPLNR;
				                item.ADDR = data.ADDR;
				                item.BANFN = data.BANFN;
				                item.BNFPO = data.BNFPO;
				                item.RETPO = data.RETPO;
				                item.BSGRU = data.BSGRU;
				                item.LFRET = data.LFRET;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MM_PurVouchSub>();
                var i = (from p in ctx.DataContext.MM_PurVouchSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.Client = i.Client;
										this.PurVouchNo = i.PurVouchNo;
										this.PVItemNo = i.PVItemNo;
										this.IsDel = i.IsDel;
										this.Materialcode = i.Materialcode;
										this.Warehouse = i.Warehouse;
										this.BEDNR = i.BEDNR;
										this.MatType = i.MatType;
										this.INFNR = i.INFNR;
										this.IDNLF = i.IDNLF;
										this.KTMNG = i.KTMNG;
										this.MENGE = i.MENGE;
										this.UnitCode = i.UnitCode;
										this.PUnitCode = i.PUnitCode;
										this.BPUMZ = i.BPUMZ;
										this.BPUMN = i.BPUMN;
										this.Price = i.Price;
										this.NETWR = i.NETWR;
										this.BRTWR = i.BRTWR;
										this.MWSKZ = i.MWSKZ;
										this.BONUS = i.BONUS;
										this.INSMK = i.INSMK;
										this.BWTAR = i.BWTAR;
										this.BWTTY = i.BWTTY;
										this.ABSKZ = i.ABSKZ;
										this.ELIKZ = i.ELIKZ;
										this.EREKZ = i.EREKZ;
										this.PSTYP = i.PSTYP;
										this.KNTTP = i.KNTTP;
										this.KZVBR = i.KZVBR;
										this.REPOS = i.REPOS;
										this.KZABS = i.KZABS;
										this.LABNR = i.LABNR;
										this.KONNR = i.KONNR;
										this.KTPNR = i.KTPNR;
										this.ABDAT = i.ABDAT;
										this.ABFTZ = i.ABFTZ;
										this.BSTYP = i.BSTYP;
										this.SKTOF = i.SKTOF;
										this.PLIFZ = i.PLIFZ;
										this.FPLNR = i.FPLNR;
										this.ADDR = i.ADDR;
										this.BANFN = i.BANFN;
										this.BNFPO = i.BNFPO;
										this.RETPO = i.RETPO;
										this.BSGRU = i.BSGRU;
										this.LFRET = i.LFRET;
					}
            }
        }
	}

	public class MM_PurVouchSubsFactory : Common.Business.MM_PurVouchSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_PurVouchSub
                        select MM_PurVouchSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_PurVouchSub
                        select MM_PurVouchSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_PurVouchSub>();
                var i = (from p in ctx.DataContext.MM_PurVouchSub.Where(exp)
                         select MM_PurVouchSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_PurVouchSub>();
                var i = from p in ctx.DataContext.MM_PurVouchSub.Where(exp)
                         select MM_PurVouchSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
