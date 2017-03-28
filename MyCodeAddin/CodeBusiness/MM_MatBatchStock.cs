using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MatBatchStock))]
#if Dev
    [RunLocal]
#endif

	public class MM_MatBatchStock:ReadOnlyBase<MM_MatBatchStock>
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

		
        public string BatchNo
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

		
        public decimal? CLABS
        {
            get ;
            set ;
        }

		
        public decimal? CUMLM
        {
            get ;
            set ;
        }

		
        public decimal? CINSM
        {
            get ;
            set ;
        }

		
        public decimal? CEINM
        {
            get ;
            set ;
        }

		
        public decimal? CSPEM
        {
            get ;
            set ;
        }

		
        public decimal? CRETM
        {
            get ;
            set ;
        }

		
        public decimal? CVMLA
        {
            get ;
            set ;
        }

		
        public decimal? CVMUM
        {
            get ;
            set ;
        }

		
        public decimal? CVMIN
        {
            get ;
            set ;
        }

		
        public decimal? CVMEI
        {
            get ;
            set ;
        }

		
        public decimal? CVMSP
        {
            get ;
            set ;
        }

		
        public decimal? CVMRE
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

		
        public string HERKL
        {
            get ;
            set ;
        }

		
        public DateTime? CHDLL
        {
            get ;
            set ;
        }

		
        public string CHJIN
        {
            get ;
            set ;
        }

		
        public string CHRUE
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_MatBatchStock Create()
        {
            return EF.DataPortal.Create<MM_MatBatchStock>();
        }

		public static MM_MatBatchStock Fetch(System.Linq.Expressions.Expression<Func<MM_MatBatchStock, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MatBatchStock>(exp,values);
            return EF.DataPortal.Fetch<MM_MatBatchStock>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MatBatchStocks))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MatBatchStocks:ReadOnlyListBase<MM_MatBatchStocks,MM_MatBatchStock>
    {
        #region Factory Methods

        public static MM_MatBatchStocks Fetch()
        {
            return EF.DataPortal.Fetch<MM_MatBatchStocks>();
        }

		public static MM_MatBatchStocks Fetch(System.Linq.Expressions.Expression<Func<MM_MatBatchStock, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MatBatchStock>(exp,values);
            return EF.DataPortal.Fetch<MM_MatBatchStocks>(lambda);
		}

		public static MM_MatBatchStocks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MatBatchStocks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MatBatchStocks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MatBatchStock, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MatBatchStocks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MatBatchStock>(exp,values)});
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
