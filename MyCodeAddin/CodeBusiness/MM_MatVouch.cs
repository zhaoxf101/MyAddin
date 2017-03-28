using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MatVouch))]
#if Dev
    [RunLocal]
#endif

	public class MM_MatVouch:ReadOnlyBase<MM_MatVouch>
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

		
        public string VGART
        {
            get ;
            set ;
        }

		
        public string VoucherType
        {
            get ;
            set ;
        }

		
        public string BLAUM
        {
            get ;
            set ;
        }

		
        public DateTime? BLDAT
        {
            get ;
            set ;
        }

		
        public DateTime? BUDAT
        {
            get ;
            set ;
        }

		
        public DateTime? CPUDT
        {
            get ;
            set ;
        }

		
        public string XBLNR
        {
            get ;
            set ;
        }

		
        public string BKTXT
        {
            get ;
            set ;
        }

		
        public string XABLN
        {
            get ;
            set ;
        }

		
        public string KNUMV
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_MatVouch Create()
        {
            return EF.DataPortal.Create<MM_MatVouch>();
        }

		public static MM_MatVouch Fetch(System.Linq.Expressions.Expression<Func<MM_MatVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MatVouch>(exp,values);
            return EF.DataPortal.Fetch<MM_MatVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MatVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MatVouchs:ReadOnlyListBase<MM_MatVouchs,MM_MatVouch>
    {
        #region Factory Methods

        public static MM_MatVouchs Fetch()
        {
            return EF.DataPortal.Fetch<MM_MatVouchs>();
        }

		public static MM_MatVouchs Fetch(System.Linq.Expressions.Expression<Func<MM_MatVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MatVouch>(exp,values);
            return EF.DataPortal.Fetch<MM_MatVouchs>(lambda);
		}

		public static MM_MatVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MatVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MatVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MatVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MatVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MatVouch>(exp,values)});
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
