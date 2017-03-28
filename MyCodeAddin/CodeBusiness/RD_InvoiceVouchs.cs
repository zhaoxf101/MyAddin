using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(RD_InvoiceVouchs))]
#if Dev
    [RunLocal]
#endif

	public class RD_InvoiceVouchs:ReadOnlyBase<RD_InvoiceVouchs>
    {
        #region Business Methods

		
        public string InvoiceNo
        {
            get ;
            set ;
        }

		
        public string RowNo
        {
            get ;
            set ;
        }

		
        public string InvoiceItem
        {
            get ;
            set ;
        }

		
        public decimal? ItemQty
        {
            get ;
            set ;
        }

		
        public decimal? ItemPrice
        {
            get ;
            set ;
        }

		
        public decimal? ItemAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static RD_InvoiceVouchs Create()
        {
            return EF.DataPortal.Create<RD_InvoiceVouchs>();
        }

		public static RD_InvoiceVouchs Fetch(System.Linq.Expressions.Expression<Func<RD_InvoiceVouchs, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<RD_InvoiceVouchs>(exp,values);
            return EF.DataPortal.Fetch<RD_InvoiceVouchs>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(RD_InvoiceVouchss))]
#if Dev
    [RunLocal]
#endif
	
	public class RD_InvoiceVouchss:ReadOnlyListBase<RD_InvoiceVouchss,RD_InvoiceVouchs>
    {
        #region Factory Methods

        public static RD_InvoiceVouchss Fetch()
        {
            return EF.DataPortal.Fetch<RD_InvoiceVouchss>();
        }

		public static RD_InvoiceVouchss Fetch(System.Linq.Expressions.Expression<Func<RD_InvoiceVouchs, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<RD_InvoiceVouchs>(exp,values);
            return EF.DataPortal.Fetch<RD_InvoiceVouchss>(lambda);
		}

		public static RD_InvoiceVouchss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<RD_InvoiceVouchss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static RD_InvoiceVouchss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<RD_InvoiceVouchs, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<RD_InvoiceVouchss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<RD_InvoiceVouchs>(exp,values)});
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
