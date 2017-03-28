using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusHang))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusHang:ReadOnlyBase<FI_ExpBusHang>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string ItemId
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusHang Create()
        {
            return EF.DataPortal.Create<FI_ExpBusHang>();
        }

		public static FI_ExpBusHang Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusHang, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusHang>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusHang>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusHangs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusHangs:ReadOnlyListBase<FI_ExpBusHangs,FI_ExpBusHang>
    {
        #region Factory Methods

        public static FI_ExpBusHangs Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusHangs>();
        }

		public static FI_ExpBusHangs Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusHang, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusHang>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusHangs>(lambda);
		}

		public static FI_ExpBusHangs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusHangs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusHangs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusHang, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusHangs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusHang>(exp,values)});
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
