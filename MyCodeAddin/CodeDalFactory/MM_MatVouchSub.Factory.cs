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
	public class MM_MatVouchSubFactory:Common.Business.MM_MatVouchSub
    {
        public static Common.Business.MM_MatVouchSub Fetch(MM_MatVouchSub data)
        {
            Common.Business.MM_MatVouchSub item = (Common.Business.MM_MatVouchSub)Activator.CreateInstance(typeof(Common.Business.MM_MatVouchSub));
            //using (ObjectFactory.BypassPropertyChecks(item))
            {
				                item.MatVouchNo = data.MatVouchNo;
				                item.AccYear = data.AccYear;
				                item.ZEILE = data.ZEILE;
				                item.LineNum = data.LineNum;
				                item.MoveType = data.MoveType;
				                item.XAUTO = data.XAUTO;
				                item.MaterialCode = data.MaterialCode;
				                item.Plant = data.Plant;
				                item.Warehouse = data.Warehouse;
				                item.BatchNo = data.BatchNo;
				                item.INSMK = data.INSMK;
				                item.ZUSCH = data.ZUSCH;
				                item.ZUSTD = data.ZUSTD;
				                item.SOBKZ = data.SOBKZ;
				                item.VendorCode = data.VendorCode;
				                item.CustCode = data.CustCode;
				                item.KDAUF = data.KDAUF;
				                item.KDPOS = data.KDPOS;
				                item.KDEIN = data.KDEIN;
				                item.PLPLA = data.PLPLA;
				                item.IsBD = data.IsBD;
				                item.Curr = data.Curr;
				                item.DMBTR = data.DMBTR;
				                item.BNBTR = data.BNBTR;
				                item.BUALT = data.BUALT;
				                item.SHKUM = data.SHKUM;
				                item.DMBUM = data.DMBUM;
				                item.BWTAR = data.BWTAR;
				                item.MENGE = data.MENGE;
				                item.UnitCode = data.UnitCode;
				                item.ERFMG = data.ERFMG;
				                item.ERFME = data.ERFME;
				                item.BPMNG = data.BPMNG;
				                item.BPRME = data.BPRME;
				                item.EBELN = data.EBELN;
				                item.EBELP = data.EBELP;
				                item.LFBJA = data.LFBJA;
				                item.LFBNR = data.LFBNR;
				                item.LFPOS = data.LFPOS;
				                item.SJAHR = data.SJAHR;
				                item.SMBLN = data.SMBLN;
				                item.SMBLP = data.SMBLP;
				                item.ELIKZ = data.ELIKZ;
				                item.SGTXT = data.SGTXT;
				                item.EQUNR = data.EQUNR;
				                item.WEMPF = data.WEMPF;
				                item.ABLAD = data.ABLAD;
				                item.GSBER = data.GSBER;
				                item.KOKRS = data.KOKRS;
				                item.PARBU = data.PARBU;
				                item.CostCtr = data.CostCtr;
				                item.AUFNR = data.AUFNR;
				                item.ANLN1 = data.ANLN1;
				                item.ANLN2 = data.ANLN2;
				                item.XSKST = data.XSKST;
				                item.XSAUF = data.XSAUF;
				                item.XSPRO = data.XSPRO;
				                item.XSERG = data.XSERG;
				                item.XRUEM = data.XRUEM;
				                item.XRUEJ = data.XRUEJ;
				                item.Client = data.Client;
				                item.VouchNo = data.VouchNo;
				                item.BUZEI = data.BUZEI;
				                item.BELUM = data.BELUM;
				                item.BUZUM = data.BUZUM;
				                item.RSNUM = data.RSNUM;
				                item.RSPOS = data.RSPOS;
				                item.KZEAR = data.KZEAR;
				                item.PBAMG = data.PBAMG;
				                item.KZSTR = data.KZSTR;
				                item.UMMAT = data.UMMAT;
				                item.UMWRK = data.UMWRK;
				                item.UMLGO = data.UMLGO;
				                item.UMCHA = data.UMCHA;
				                item.UMZST = data.UMZST;
				                item.UMZUS = data.UMZUS;
				                item.UMBAR = data.UMBAR;
				                item.UMSOK = data.UMSOK;
				                item.KZBEW = data.KZBEW;
				                item.KZVBR = data.KZVBR;
				                item.KZZUG = data.KZZUG;
				                item.WEUNB = data.WEUNB;
				                item.PALAN = data.PALAN;
				                item.LGNUM = data.LGNUM;
				                item.LGTYP = data.LGTYP;
				                item.LGPLA = data.LGPLA;
				                item.BESTQ = data.BESTQ;
				                item.BWLVS = data.BWLVS;
				                item.TBNUM = data.TBNUM;
				                item.TBPOS = data.TBPOS;
				                item.XBLVS = data.XBLVS;
				                item.VSCHN = data.VSCHN;
				                item.NSCHN = data.NSCHN;
				                item.DYPLA = data.DYPLA;
				                item.UBNUM = data.UBNUM;
				                item.TBPRI = data.TBPRI;
				                item.TANUM = data.TANUM;
				                item.WEANZ = data.WEANZ;
				                item.GRUND = data.GRUND;
				                item.EVERS = data.EVERS;
				                item.EVERE = data.EVERE;
				                item.KSTRG = data.KSTRG;
				                item.PAOBJNR = data.PAOBJNR;
				                item.PrifitCtr = data.PrifitCtr;
				                item.PS_PSP_PNR = data.PS_PSP_PNR;
				                item.NPLNR = data.NPLNR;
				                item.AUFPL = data.AUFPL;
				                item.APLZL = data.APLZL;
				                item.AUFPS = data.AUFPS;
				                item.VPTNR = data.VPTNR;
				                item.FIPOS = data.FIPOS;
				                item.SAKTO = data.SAKTO;
				                item.BSTMG = data.BSTMG;
				                item.BSTME = data.BSTME;
				                item.XWSBR = data.XWSBR;
				                item.EMLIF = data.EMLIF;
				                item.EXBWR = data.EXBWR;
				                item.VKWRT = data.VKWRT;
				                item.AKTNR = data.AKTNR;
				                item.ZEKKN = data.ZEKKN;
				                item.VFDAT = data.VFDAT;
				                item.CUOBJ_CH = data.CUOBJ_CH;
				                item.EXVKW = data.EXVKW;
				                item.PPrifitCtr = data.PPrifitCtr;
				                item.RSART = data.RSART;
				                item.GEBER = data.GEBER;
				                item.FISTL = data.FISTL;
				                item.MATBF = data.MATBF;
				                item.UMMAB = data.UMMAB;
				                item.BUSTM = data.BUSTM;
				                item.BUSTW = data.BUSTW;
				                item.MENGU = data.MENGU;
				                item.WERTU = data.WERTU;
				                item.LBKUM = data.LBKUM;
				                item.SALK3 = data.SALK3;
				                item.VPRSV = data.VPRSV;
				                item.FKBER = data.FKBER;
				                item.DABRBZ = data.DABRBZ;
				                item.VKWRA = data.VKWRA;
				                item.DABRZ = data.DABRZ;
				                item.XBEAU = data.XBEAU;
				                item.LSMNG = data.LSMNG;
				                item.LSMEH = data.LSMEH;
				                item.KZBWS = data.KZBWS;
				                item.QINSPST = data.QINSPST;
				                item.URZEI = data.URZEI;
				                item.J_1BEXBASE = data.J_1BEXBASE;
				                item.MWSKZ = data.MWSKZ;
				                item.TXJCD = data.TXJCD;
				                item.EMATN = data.EMATN;
				                item.J_1AGIRUPD = data.J_1AGIRUPD;
				                item.VKMWS = data.VKMWS;
				                item.HSDAT = data.HSDAT;
				                item.BERKZ = data.BERKZ;
				                item.MAT_KDAUF = data.MAT_KDAUF;
				                item.MAT_KDPOS = data.MAT_KDPOS;
				                item.MAT_PSPNR = data.MAT_PSPNR;
				                item.XWOFF = data.XWOFF;
				                item.BEMOT = data.BEMOT;
				                item.PRZNR = data.PRZNR;
				                item.LLIEF = data.LLIEF;
				                item.WorkType = data.WorkType;
							}
			ObjectFactory.MarkAsChild(item);
            ObjectFactory.MarkOld(item);
            return item;
        }

		private void DataPortal_Fetch(Common.Business.LambdaExpression lambda)
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
				var exp = lambda.Resolve<MM_MatVouchSub>();
                var i = (from p in ctx.DataContext.MM_MatVouchSub.Where(exp)
                         select p).FirstOrDefault();
                if (i != null)
                {
										this.MatVouchNo = i.MatVouchNo;
										this.AccYear = i.AccYear;
										this.ZEILE = i.ZEILE;
										this.LineNum = i.LineNum;
										this.MoveType = i.MoveType;
										this.XAUTO = i.XAUTO;
										this.MaterialCode = i.MaterialCode;
										this.Plant = i.Plant;
										this.Warehouse = i.Warehouse;
										this.BatchNo = i.BatchNo;
										this.INSMK = i.INSMK;
										this.ZUSCH = i.ZUSCH;
										this.ZUSTD = i.ZUSTD;
										this.SOBKZ = i.SOBKZ;
										this.VendorCode = i.VendorCode;
										this.CustCode = i.CustCode;
										this.KDAUF = i.KDAUF;
										this.KDPOS = i.KDPOS;
										this.KDEIN = i.KDEIN;
										this.PLPLA = i.PLPLA;
										this.IsBD = i.IsBD;
										this.Curr = i.Curr;
										this.DMBTR = i.DMBTR;
										this.BNBTR = i.BNBTR;
										this.BUALT = i.BUALT;
										this.SHKUM = i.SHKUM;
										this.DMBUM = i.DMBUM;
										this.BWTAR = i.BWTAR;
										this.MENGE = i.MENGE;
										this.UnitCode = i.UnitCode;
										this.ERFMG = i.ERFMG;
										this.ERFME = i.ERFME;
										this.BPMNG = i.BPMNG;
										this.BPRME = i.BPRME;
										this.EBELN = i.EBELN;
										this.EBELP = i.EBELP;
										this.LFBJA = i.LFBJA;
										this.LFBNR = i.LFBNR;
										this.LFPOS = i.LFPOS;
										this.SJAHR = i.SJAHR;
										this.SMBLN = i.SMBLN;
										this.SMBLP = i.SMBLP;
										this.ELIKZ = i.ELIKZ;
										this.SGTXT = i.SGTXT;
										this.EQUNR = i.EQUNR;
										this.WEMPF = i.WEMPF;
										this.ABLAD = i.ABLAD;
										this.GSBER = i.GSBER;
										this.KOKRS = i.KOKRS;
										this.PARBU = i.PARBU;
										this.CostCtr = i.CostCtr;
										this.AUFNR = i.AUFNR;
										this.ANLN1 = i.ANLN1;
										this.ANLN2 = i.ANLN2;
										this.XSKST = i.XSKST;
										this.XSAUF = i.XSAUF;
										this.XSPRO = i.XSPRO;
										this.XSERG = i.XSERG;
										this.XRUEM = i.XRUEM;
										this.XRUEJ = i.XRUEJ;
										this.Client = i.Client;
										this.VouchNo = i.VouchNo;
										this.BUZEI = i.BUZEI;
										this.BELUM = i.BELUM;
										this.BUZUM = i.BUZUM;
										this.RSNUM = i.RSNUM;
										this.RSPOS = i.RSPOS;
										this.KZEAR = i.KZEAR;
										this.PBAMG = i.PBAMG;
										this.KZSTR = i.KZSTR;
										this.UMMAT = i.UMMAT;
										this.UMWRK = i.UMWRK;
										this.UMLGO = i.UMLGO;
										this.UMCHA = i.UMCHA;
										this.UMZST = i.UMZST;
										this.UMZUS = i.UMZUS;
										this.UMBAR = i.UMBAR;
										this.UMSOK = i.UMSOK;
										this.KZBEW = i.KZBEW;
										this.KZVBR = i.KZVBR;
										this.KZZUG = i.KZZUG;
										this.WEUNB = i.WEUNB;
										this.PALAN = i.PALAN;
										this.LGNUM = i.LGNUM;
										this.LGTYP = i.LGTYP;
										this.LGPLA = i.LGPLA;
										this.BESTQ = i.BESTQ;
										this.BWLVS = i.BWLVS;
										this.TBNUM = i.TBNUM;
										this.TBPOS = i.TBPOS;
										this.XBLVS = i.XBLVS;
										this.VSCHN = i.VSCHN;
										this.NSCHN = i.NSCHN;
										this.DYPLA = i.DYPLA;
										this.UBNUM = i.UBNUM;
										this.TBPRI = i.TBPRI;
										this.TANUM = i.TANUM;
										this.WEANZ = i.WEANZ;
										this.GRUND = i.GRUND;
										this.EVERS = i.EVERS;
										this.EVERE = i.EVERE;
										this.KSTRG = i.KSTRG;
										this.PAOBJNR = i.PAOBJNR;
										this.PrifitCtr = i.PrifitCtr;
										this.PS_PSP_PNR = i.PS_PSP_PNR;
										this.NPLNR = i.NPLNR;
										this.AUFPL = i.AUFPL;
										this.APLZL = i.APLZL;
										this.AUFPS = i.AUFPS;
										this.VPTNR = i.VPTNR;
										this.FIPOS = i.FIPOS;
										this.SAKTO = i.SAKTO;
										this.BSTMG = i.BSTMG;
										this.BSTME = i.BSTME;
										this.XWSBR = i.XWSBR;
										this.EMLIF = i.EMLIF;
										this.EXBWR = i.EXBWR;
										this.VKWRT = i.VKWRT;
										this.AKTNR = i.AKTNR;
										this.ZEKKN = i.ZEKKN;
										this.VFDAT = i.VFDAT;
										this.CUOBJ_CH = i.CUOBJ_CH;
										this.EXVKW = i.EXVKW;
										this.PPrifitCtr = i.PPrifitCtr;
										this.RSART = i.RSART;
										this.GEBER = i.GEBER;
										this.FISTL = i.FISTL;
										this.MATBF = i.MATBF;
										this.UMMAB = i.UMMAB;
										this.BUSTM = i.BUSTM;
										this.BUSTW = i.BUSTW;
										this.MENGU = i.MENGU;
										this.WERTU = i.WERTU;
										this.LBKUM = i.LBKUM;
										this.SALK3 = i.SALK3;
										this.VPRSV = i.VPRSV;
										this.FKBER = i.FKBER;
										this.DABRBZ = i.DABRBZ;
										this.VKWRA = i.VKWRA;
										this.DABRZ = i.DABRZ;
										this.XBEAU = i.XBEAU;
										this.LSMNG = i.LSMNG;
										this.LSMEH = i.LSMEH;
										this.KZBWS = i.KZBWS;
										this.QINSPST = i.QINSPST;
										this.URZEI = i.URZEI;
										this.J_1BEXBASE = i.J_1BEXBASE;
										this.MWSKZ = i.MWSKZ;
										this.TXJCD = i.TXJCD;
										this.EMATN = i.EMATN;
										this.J_1AGIRUPD = i.J_1AGIRUPD;
										this.VKMWS = i.VKMWS;
										this.HSDAT = i.HSDAT;
										this.BERKZ = i.BERKZ;
										this.MAT_KDAUF = i.MAT_KDAUF;
										this.MAT_KDPOS = i.MAT_KDPOS;
										this.MAT_PSPNR = i.MAT_PSPNR;
										this.XWOFF = i.XWOFF;
										this.BEMOT = i.BEMOT;
										this.PRZNR = i.PRZNR;
										this.LLIEF = i.LLIEF;
										this.WorkType = i.WorkType;
					}
            }
        }
	}

	public class MM_MatVouchSubsFactory : Common.Business.MM_MatVouchSubs
    {
        private void DataPortal_Fetch()
        {
            using (var ctx = ContextManager<EFDataContext>.GetManager(Database.EFramework))
            {
                var i = from p in ctx.DataContext.MM_MatVouchSub
                        select MM_MatVouchSubFactory.Fetch(p);
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
                var i = (from p in ctx.DataContext.MM_MatVouchSub
                        select MM_MatVouchSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = page.Lambda.Resolve<MM_MatVouchSub>();
                var i = (from p in ctx.DataContext.MM_MatVouchSub.Where(exp)
                         select MM_MatVouchSubFactory.Fetch(p)).Skip(page.StartIndex).Take(page.RowCount);
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
                var exp = lambda.Resolve<MM_MatVouchSub>();
                var i = from p in ctx.DataContext.MM_MatVouchSub.Where(exp)
                         select MM_MatVouchSubFactory.Fetch(p);
                this.RaiseListChangedEvents = false;
                this.IsReadOnly = false;
                this.AddRange(i);
                this.IsReadOnly = true;
                this.RaiseListChangedEvents = true;
            }
        }


    }
}
