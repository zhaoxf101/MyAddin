using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MatBatch))]
#if Dev
    [RunLocal]
#endif

	public class MM_MatBatch:ReadOnlyBase<MM_MatBatch>
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

		
        public bool? IsDel
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

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string LICHA
        {
            get ;
            set ;
        }

		
        public DateTime? LastInDate
        {
            get ;
            set ;
        }

		
        public DateTime? FVDT1
        {
            get ;
            set ;
        }

		
        public DateTime? HSDAT
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static MM_MatBatch Create()
        {
            return EF.DataPortal.Create<MM_MatBatch>();
        }

		public static MM_MatBatch Fetch(System.Linq.Expressions.Expression<Func<MM_MatBatch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MatBatch>(exp,values);
            return EF.DataPortal.Fetch<MM_MatBatch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MatBatchs))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MatBatchs:ReadOnlyListBase<MM_MatBatchs,MM_MatBatch>
    {
        #region Factory Methods

        public static MM_MatBatchs Fetch()
        {
            return EF.DataPortal.Fetch<MM_MatBatchs>();
        }

		public static MM_MatBatchs Fetch(System.Linq.Expressions.Expression<Func<MM_MatBatch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MatBatch>(exp,values);
            return EF.DataPortal.Fetch<MM_MatBatchs>(lambda);
		}

		public static MM_MatBatchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MatBatchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MatBatchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MatBatch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MatBatchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MatBatch>(exp,values)});
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
