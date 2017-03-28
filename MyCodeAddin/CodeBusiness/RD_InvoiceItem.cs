using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(RD_InvoiceItem))]
#if Dev
    [RunLocal]
#endif

	public class RD_InvoiceItem:ReadOnlyBase<RD_InvoiceItem>
    {
        #region Business Methods

		
        public string InvoiceItem
        {
            get ;
            set ;
        }

		
        public bool Flag
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static RD_InvoiceItem Create()
        {
            return EF.DataPortal.Create<RD_InvoiceItem>();
        }

		public static RD_InvoiceItem Fetch(System.Linq.Expressions.Expression<Func<RD_InvoiceItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<RD_InvoiceItem>(exp,values);
            return EF.DataPortal.Fetch<RD_InvoiceItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(RD_InvoiceItems))]
#if Dev
    [RunLocal]
#endif
	
	public class RD_InvoiceItems:ReadOnlyListBase<RD_InvoiceItems,RD_InvoiceItem>
    {
        #region Factory Methods

        public static RD_InvoiceItems Fetch()
        {
            return EF.DataPortal.Fetch<RD_InvoiceItems>();
        }

		public static RD_InvoiceItems Fetch(System.Linq.Expressions.Expression<Func<RD_InvoiceItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<RD_InvoiceItem>(exp,values);
            return EF.DataPortal.Fetch<RD_InvoiceItems>(lambda);
		}

		public static RD_InvoiceItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<RD_InvoiceItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static RD_InvoiceItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<RD_InvoiceItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<RD_InvoiceItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<RD_InvoiceItem>(exp,values)});
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
