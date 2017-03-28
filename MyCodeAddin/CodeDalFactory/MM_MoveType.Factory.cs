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
	public class MM_MoveTypeFactory:Common.Business.MM_MoveType
    {
        public static Common.Business.MM_MoveType Fetch(MM_MoveType data)
        {
            Common.Business.MM_MoveType item = (Common.Business.MM_MoveType)Activator.CreateInstance(typeof(Common.Business.MM_MoveType));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MoveType = data.MoveType;
				                item.IsBD = data.IsBD;
				                item.KZWES = data.KZWES;
				                item.KZVBU = data.KZVBU;
				                item.KZDRU = data.KZDRU;
				                item.KZKON = data.KZKON;
				                item.CHNEU = data.CHNEU;
				                item.KZZDE = data.KZZDE;
				                item.RSTYP = data.RSTYP;
				                item.SELPA = data.SELPA;
				                item.XLAUT = data.XLAUT;
				                item.KZSTR = data.KZSTR;
				                item.KZGRU = data.KZGRU;
				                item.XINVB = data.XINVB;
				                item.QSSBW = data.QSSBW;
				                item.KZBWA = data.KZBWA;
				                item.XSTBW = data.XSTBW;
				                item.XPBED = data.XPBED;
				                item.XWSBR = data.XWSBR;
				                item.KZMHD = data.KZMHD;
				                item.KZCLA = data.KZCLA;
				                item.XKOKO = data.XKOKO;
				                item.XKCFC = data.XKCFC;
				                item.XNEBE = data.XNEBE;
				                item.J_1BNFREL = data.J_1BNFREL;
				                item.J_1BNFTYPE = data.J_1BNFTYPE;
				                item.J_1BITMTYP = data.J_1BITMTYP;
				                item.J_1BSPCSTO = data.J_1BSPCSTO;
				                item.J_1BPARTYP = data.J_1BPARTYP;
				                item.J_1BPARVW = data.J_1BPARVW;
				                item.RULES = data.RULES;
				                item.J_1AREVIDX = data.J_1AREVIDX;
				                item.J_1ADOCCL = data.J_1ADOCCL;
				                item.J_1AEXPKZ = data.J_1AEXPKZ;
				                item.XOARC = data.XOARC;
				                item.BUSTR = data.BUSTR;
				                item.KZDIR = data.KZDIR;
				                item.OIJ1BNFFI = data.OIJ1BNFFI;
				                item.MILL_CPCONF = data.MILL_CPCONF;
				                item.LText = data.LText;
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
				var exp = lambda.Resolve<MM_MoveType>();
                var i = (from p in ctx.DataContext.MM_MoveType.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MoveType = i.MoveType;
										this.IsBD = i.IsBD;
										this.KZWES = i.KZWES;
										this.KZVBU = i.KZVBU;
										this.KZDRU = i.KZDRU;
										this.KZKON = i.KZKON;
										this.CHNEU = i.CHNEU;
										this.KZZDE = i.KZZDE;
										this.RSTYP = i.RSTYP;
										this.SELPA = i.SELPA;
										this.XLAUT = i.XLAUT;
										this.KZSTR = i.KZSTR;
										this.KZGRU = i.KZGRU;
										this.XINVB = i.XINVB;
										this.QSSBW = i.QSSBW;
										this.KZBWA = i.KZBWA;
										this.XSTBW = i.XSTBW;
										this.XPBED = i.XPBED;
										this.XWSBR = i.XWSBR;
										this.KZMHD = i.KZMHD;
										this.KZCLA = i.KZCLA;
										this.XKOKO = i.XKOKO;
										this.XKCFC = i.XKCFC;
										this.XNEBE = i.XNEBE;
										this.J_1BNFREL = i.J_1BNFREL;
										this.J_1BNFTYPE = i.J_1BNFTYPE;
										this.J_1BITMTYP = i.J_1BITMTYP;
										this.J_1BSPCSTO = i.J_1BSPCSTO;
										this.J_1BPARTYP = i.J_1BPARTYP;
										this.J_1BPARVW = i.J_1BPARVW;
										this.RULES = i.RULES;
										this.J_1AREVIDX = i.J_1AREVIDX;
										this.J_1ADOCCL = i.J_1ADOCCL;
										this.J_1AEXPKZ = i.J_1AEXPKZ;
										this.XOARC = i.XOARC;
										this.BUSTR = i.BUSTR;
										this.KZDIR = i.KZDIR;
										this.OIJ1BNFFI = i.OIJ1BNFFI;
										this.MILL_CPCONF = i.MILL_CPCONF;
										this.LText = i.LText;
										this.CreatedUser = i.CreatedUser;
										this.CreatedDate = i.CreatedDate;
										this.ChangedUser = i.ChangedUser;
										this.ChangedDate = i.ChangedDate;
					}
            }
        }
	}

	public class MM_MoveTypesFactory : Common.Business.MM_MoveTypes
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_MoveType
                        select MM_MoveTypeFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_MoveType
                        select MM_MoveTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_MoveType>();
                var i = (from p in ctx.DataContext.MM_MoveType.Where(exp)
                         select MM_MoveTypeFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_MoveType>();
                var i = from p in ctx.DataContext.MM_MoveType.Where(exp)
                         select MM_MoveTypeFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
