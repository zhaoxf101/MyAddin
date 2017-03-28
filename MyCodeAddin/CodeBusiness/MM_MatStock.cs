using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MatStock))]
#if Dev
    [RunLocal]
#endif

	public class MM_MatStock:ReadOnlyBase<MM_MatStock>
    {
        #region Business Methods

		
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

		
        public bool? IsDel
        {
            get ;
            set ;
        }

		
        public string CurAccYear
        {
            get ;
            set ;
        }

		
        public string CurAccMon
        {
            get ;
            set ;
        }

		
        public decimal? LABST
        {
            get ;
            set ;
        }

		
        public decimal? UMLME
        {
            get ;
            set ;
        }

		
        public decimal? INSME
        {
            get ;
            set ;
        }

		
        public decimal? EINME
        {
            get ;
            set ;
        }

		
        public decimal? SPEME
        {
            get ;
            set ;
        }

		
        public decimal? RETME
        {
            get ;
            set ;
        }

		
        public decimal? VMLAB
        {
            get ;
            set ;
        }

		
        public decimal? VMUML
        {
            get ;
            set ;
        }

		
        public decimal? VMINS
        {
            get ;
            set ;
        }

		
        public decimal? VMEIN
        {
            get ;
            set ;
        }

		
        public decimal? VMSPE
        {
            get ;
            set ;
        }

		
        public decimal? VMRET
        {
            get ;
            set ;
        }

		
        public string KZICL
        {
            get ;
            set ;
        }

		
        public string KZICQ
        {
            get ;
            set ;
        }

		
        public string KZICE
        {
            get ;
            set ;
        }

		
        public string KZICS
        {
            get ;
            set ;
        }

		
        public string KZVCL
        {
            get ;
            set ;
        }

		
        public string KZVCQ
        {
            get ;
            set ;
        }

		
        public string KZVCE
        {
            get ;
            set ;
        }

		
        public string KZVCS
        {
            get ;
            set ;
        }

		
        public bool? CanMRP
        {
            get ;
            set ;
        }

		
        public string LSOBS
        {
            get ;
            set ;
        }

		
        public string LMINB
        {
            get ;
            set ;
        }

		
        public string LBSTF
        {
            get ;
            set ;
        }

		
        public string EXPPG
        {
            get ;
            set ;
        }

		
        public string EXVER
        {
            get ;
            set ;
        }

		
        public string Stock
        {
            get ;
            set ;
        }

		
        public decimal? KLABS
        {
            get ;
            set ;
        }

		
        public decimal? KINSM
        {
            get ;
            set ;
        }

		
        public decimal? KEINM
        {
            get ;
            set ;
        }

		
        public decimal? KSPEM
        {
            get ;
            set ;
        }

		
        public DateTime? DLINL
        {
            get ;
            set ;
        }

		
        public string PriftCtr
        {
            get ;
            set ;
        }

		
        public DateTime? ERSDA
        {
            get ;
            set ;
        }

		
        public decimal? VKLAB
        {
            get ;
            set ;
        }

		
        public decimal? VKUML
        {
            get ;
            set ;
        }

		
        public decimal? BSKRF
        {
            get ;
            set ;
        }

		
        public string MDRUE
        {
            get ;
            set ;
        }

		
        public string CurFinYear
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_MatStock Create()
        {
            return EF.DataPortal.Create<MM_MatStock>();
        }

		public static MM_MatStock Fetch(System.Linq.Expressions.Expression<Func<MM_MatStock, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MatStock>(exp,values);
            return EF.DataPortal.Fetch<MM_MatStock>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MatStocks))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MatStocks:ReadOnlyListBase<MM_MatStocks,MM_MatStock>
    {
        #region Factory Methods

        public static MM_MatStocks Fetch()
        {
            return EF.DataPortal.Fetch<MM_MatStocks>();
        }

		public static MM_MatStocks Fetch(System.Linq.Expressions.Expression<Func<MM_MatStock, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MatStock>(exp,values);
            return EF.DataPortal.Fetch<MM_MatStocks>(lambda);
		}

		public static MM_MatStocks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MatStocks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MatStocks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MatStock, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MatStocks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MatStock>(exp,values)});
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
