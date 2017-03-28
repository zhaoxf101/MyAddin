using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MatVouchSub))]
#if Dev
    [RunLocal]
#endif

	public class MM_MatVouchSub:ReadOnlyBase<MM_MatVouchSub>
    {
        #region Business Methods

		
        public string MatVouchNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string ZEILE
        {
            get ;
            set ;
        }

		
        public int? LineNum
        {
            get ;
            set ;
        }

		
        public string MoveType
        {
            get ;
            set ;
        }

		
        public bool? XAUTO
        {
            get ;
            set ;
        }

		
        public string MaterialCode
        {
            get ;
            set ;
        }

		
        public string Plant
        {
            get ;
            set ;
        }

		
        public string Warehouse
        {
            get ;
            set ;
        }

		
        public string BatchNo
        {
            get ;
            set ;
        }

		
        public string INSMK
        {
            get ;
            set ;
        }

		
        public string ZUSCH
        {
            get ;
            set ;
        }

		
        public string ZUSTD
        {
            get ;
            set ;
        }

		
        public string SOBKZ
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string CustCode
        {
            get ;
            set ;
        }

		
        public string KDAUF
        {
            get ;
            set ;
        }

		
        public string KDPOS
        {
            get ;
            set ;
        }

		
        public string KDEIN
        {
            get ;
            set ;
        }

		
        public string PLPLA
        {
            get ;
            set ;
        }

		
        public string IsBD
        {
            get ;
            set ;
        }

		
        public string Curr
        {
            get ;
            set ;
        }

		
        public decimal? DMBTR
        {
            get ;
            set ;
        }

		
        public decimal? BNBTR
        {
            get ;
            set ;
        }

		
        public decimal? BUALT
        {
            get ;
            set ;
        }

		
        public bool? SHKUM
        {
            get ;
            set ;
        }

		
        public decimal? DMBUM
        {
            get ;
            set ;
        }

		
        public string BWTAR
        {
            get ;
            set ;
        }

		
        public decimal? MENGE
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public decimal? ERFMG
        {
            get ;
            set ;
        }

		
        public string ERFME
        {
            get ;
            set ;
        }

		
        public decimal? BPMNG
        {
            get ;
            set ;
        }

		
        public string BPRME
        {
            get ;
            set ;
        }

		
        public string EBELN
        {
            get ;
            set ;
        }

		
        public string EBELP
        {
            get ;
            set ;
        }

		
        public string LFBJA
        {
            get ;
            set ;
        }

		
        public string LFBNR
        {
            get ;
            set ;
        }

		
        public string LFPOS
        {
            get ;
            set ;
        }

		
        public string SJAHR
        {
            get ;
            set ;
        }

		
        public string SMBLN
        {
            get ;
            set ;
        }

		
        public string SMBLP
        {
            get ;
            set ;
        }

		
        public bool? ELIKZ
        {
            get ;
            set ;
        }

		
        public string SGTXT
        {
            get ;
            set ;
        }

		
        public string EQUNR
        {
            get ;
            set ;
        }

		
        public string WEMPF
        {
            get ;
            set ;
        }

		
        public string ABLAD
        {
            get ;
            set ;
        }

		
        public string GSBER
        {
            get ;
            set ;
        }

		
        public string KOKRS
        {
            get ;
            set ;
        }

		
        public string PARBU
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string AUFNR
        {
            get ;
            set ;
        }

		
        public string ANLN1
        {
            get ;
            set ;
        }

		
        public string ANLN2
        {
            get ;
            set ;
        }

		
        public string XSKST
        {
            get ;
            set ;
        }

		
        public string XSAUF
        {
            get ;
            set ;
        }

		
        public string XSPRO
        {
            get ;
            set ;
        }

		
        public string XSERG
        {
            get ;
            set ;
        }

		
        public string XRUEM
        {
            get ;
            set ;
        }

		
        public string XRUEJ
        {
            get ;
            set ;
        }

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public int? BUZEI
        {
            get ;
            set ;
        }

		
        public string BELUM
        {
            get ;
            set ;
        }

		
        public int? BUZUM
        {
            get ;
            set ;
        }

		
        public string RSNUM
        {
            get ;
            set ;
        }

		
        public string RSPOS
        {
            get ;
            set ;
        }

		
        public string KZEAR
        {
            get ;
            set ;
        }

		
        public decimal? PBAMG
        {
            get ;
            set ;
        }

		
        public string KZSTR
        {
            get ;
            set ;
        }

		
        public string UMMAT
        {
            get ;
            set ;
        }

		
        public string UMWRK
        {
            get ;
            set ;
        }

		
        public string UMLGO
        {
            get ;
            set ;
        }

		
        public string UMCHA
        {
            get ;
            set ;
        }

		
        public string UMZST
        {
            get ;
            set ;
        }

		
        public string UMZUS
        {
            get ;
            set ;
        }

		
        public string UMBAR
        {
            get ;
            set ;
        }

		
        public string UMSOK
        {
            get ;
            set ;
        }

		
        public string KZBEW
        {
            get ;
            set ;
        }

		
        public string KZVBR
        {
            get ;
            set ;
        }

		
        public string KZZUG
        {
            get ;
            set ;
        }

		
        public string WEUNB
        {
            get ;
            set ;
        }

		
        public decimal? PALAN
        {
            get ;
            set ;
        }

		
        public string LGNUM
        {
            get ;
            set ;
        }

		
        public string LGTYP
        {
            get ;
            set ;
        }

		
        public string LGPLA
        {
            get ;
            set ;
        }

		
        public string BESTQ
        {
            get ;
            set ;
        }

		
        public string BWLVS
        {
            get ;
            set ;
        }

		
        public int? TBNUM
        {
            get ;
            set ;
        }

		
        public int? TBPOS
        {
            get ;
            set ;
        }

		
        public bool? XBLVS
        {
            get ;
            set ;
        }

		
        public bool VSCHN
        {
            get ;
            set ;
        }

		
        public bool? NSCHN
        {
            get ;
            set ;
        }

		
        public bool? DYPLA
        {
            get ;
            set ;
        }

		
        public string UBNUM
        {
            get ;
            set ;
        }

		
        public string TBPRI
        {
            get ;
            set ;
        }

		
        public string TANUM
        {
            get ;
            set ;
        }

		
        public int? WEANZ
        {
            get ;
            set ;
        }

		
        public string GRUND
        {
            get ;
            set ;
        }

		
        public string EVERS
        {
            get ;
            set ;
        }

		
        public string EVERE
        {
            get ;
            set ;
        }

		
        public string KSTRG
        {
            get ;
            set ;
        }

		
        public string PAOBJNR
        {
            get ;
            set ;
        }

		
        public string PrifitCtr
        {
            get ;
            set ;
        }

		
        public string PS_PSP_PNR
        {
            get ;
            set ;
        }

		
        public string NPLNR
        {
            get ;
            set ;
        }

		
        public string AUFPL
        {
            get ;
            set ;
        }

		
        public int? APLZL
        {
            get ;
            set ;
        }

		
        public int? AUFPS
        {
            get ;
            set ;
        }

		
        public string VPTNR
        {
            get ;
            set ;
        }

		
        public string FIPOS
        {
            get ;
            set ;
        }

		
        public string SAKTO
        {
            get ;
            set ;
        }

		
        public decimal? BSTMG
        {
            get ;
            set ;
        }

		
        public string BSTME
        {
            get ;
            set ;
        }

		
        public string XWSBR
        {
            get ;
            set ;
        }

		
        public string EMLIF
        {
            get ;
            set ;
        }

		
        public decimal? EXBWR
        {
            get ;
            set ;
        }

		
        public decimal? VKWRT
        {
            get ;
            set ;
        }

		
        public string AKTNR
        {
            get ;
            set ;
        }

		
        public int? ZEKKN
        {
            get ;
            set ;
        }

		
        public DateTime? VFDAT
        {
            get ;
            set ;
        }

		
        public string CUOBJ_CH
        {
            get ;
            set ;
        }

		
        public decimal? EXVKW
        {
            get ;
            set ;
        }

		
        public string PPrifitCtr
        {
            get ;
            set ;
        }

		
        public string RSART
        {
            get ;
            set ;
        }

		
        public string GEBER
        {
            get ;
            set ;
        }

		
        public string FISTL
        {
            get ;
            set ;
        }

		
        public string MATBF
        {
            get ;
            set ;
        }

		
        public string UMMAB
        {
            get ;
            set ;
        }

		
        public string BUSTM
        {
            get ;
            set ;
        }

		
        public string BUSTW
        {
            get ;
            set ;
        }

		
        public string MENGU
        {
            get ;
            set ;
        }

		
        public string WERTU
        {
            get ;
            set ;
        }

		
        public decimal? LBKUM
        {
            get ;
            set ;
        }

		
        public decimal? SALK3
        {
            get ;
            set ;
        }

		
        public string VPRSV
        {
            get ;
            set ;
        }

		
        public string FKBER
        {
            get ;
            set ;
        }

		
        public DateTime? DABRBZ
        {
            get ;
            set ;
        }

		
        public decimal? VKWRA
        {
            get ;
            set ;
        }

		
        public DateTime? DABRZ
        {
            get ;
            set ;
        }

		
        public string XBEAU
        {
            get ;
            set ;
        }

		
        public decimal? LSMNG
        {
            get ;
            set ;
        }

		
        public string LSMEH
        {
            get ;
            set ;
        }

		
        public string KZBWS
        {
            get ;
            set ;
        }

		
        public string QINSPST
        {
            get ;
            set ;
        }

		
        public int? URZEI
        {
            get ;
            set ;
        }

		
        public decimal? J_1BEXBASE
        {
            get ;
            set ;
        }

		
        public string MWSKZ
        {
            get ;
            set ;
        }

		
        public string TXJCD
        {
            get ;
            set ;
        }

		
        public string EMATN
        {
            get ;
            set ;
        }

		
        public string J_1AGIRUPD
        {
            get ;
            set ;
        }

		
        public string VKMWS
        {
            get ;
            set ;
        }

		
        public DateTime? HSDAT
        {
            get ;
            set ;
        }

		
        public string BERKZ
        {
            get ;
            set ;
        }

		
        public string MAT_KDAUF
        {
            get ;
            set ;
        }

		
        public string MAT_KDPOS
        {
            get ;
            set ;
        }

		
        public string MAT_PSPNR
        {
            get ;
            set ;
        }

		
        public string XWOFF
        {
            get ;
            set ;
        }

		
        public string BEMOT
        {
            get ;
            set ;
        }

		
        public string PRZNR
        {
            get ;
            set ;
        }

		
        public string LLIEF
        {
            get ;
            set ;
        }

		
        public string WorkType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_MatVouchSub Create()
        {
            return EF.DataPortal.Create<MM_MatVouchSub>();
        }

		public static MM_MatVouchSub Fetch(System.Linq.Expressions.Expression<Func<MM_MatVouchSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MatVouchSub>(exp,values);
            return EF.DataPortal.Fetch<MM_MatVouchSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MatVouchSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MatVouchSubs:ReadOnlyListBase<MM_MatVouchSubs,MM_MatVouchSub>
    {
        #region Factory Methods

        public static MM_MatVouchSubs Fetch()
        {
            return EF.DataPortal.Fetch<MM_MatVouchSubs>();
        }

		public static MM_MatVouchSubs Fetch(System.Linq.Expressions.Expression<Func<MM_MatVouchSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MatVouchSub>(exp,values);
            return EF.DataPortal.Fetch<MM_MatVouchSubs>(lambda);
		}

		public static MM_MatVouchSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MatVouchSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MatVouchSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MatVouchSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MatVouchSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MatVouchSub>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
