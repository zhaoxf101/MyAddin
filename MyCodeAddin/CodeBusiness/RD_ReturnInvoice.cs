using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(RD_ReturnInvoice))]
#if Dev
    [RunLocal]
#endif

	public class RD_ReturnInvoice:ReadOnlyBase<RD_ReturnInvoice>
    {
        #region Business Methods

		
        public string RetInvCode
        {
            get ;
            set ;
        }

		
        public DateTime? RetInvTime
        {
            get ;
            set ;
        }

		
        public string RetInvReason
        {
            get ;
            set ;
        }

		
        public string InvoiceCode
        {
            get ;
            set ;
        }

		
        public DateTime? InvoiceDate
        {
            get ;
            set ;
        }

		
        public decimal? InvoiceAmt
        {
            get ;
            set ;
        }

		
        public string RecipName
        {
            get ;
            set ;
        }

		
        public string RetInvApplyer
        {
            get ;
            set ;
        }

		
        public string DepAudit
        {
            get ;
            set ;
        }

		
        public string RDAudit
        {
            get ;
            set ;
        }

		
        public string FIAudit
        {
            get ;
            set ;
        }

		
        public string RetInvDealer
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static RD_ReturnInvoice Create()
        {
            return EF.DataPortal.Create<RD_ReturnInvoice>();
        }

		public static RD_ReturnInvoice Fetch(System.Linq.Expressions.Expression<Func<RD_ReturnInvoice, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<RD_ReturnInvoice>(exp,values);
            return EF.DataPortal.Fetch<RD_ReturnInvoice>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(RD_ReturnInvoices))]
#if Dev
    [RunLocal]
#endif
	
	public class RD_ReturnInvoices:ReadOnlyListBase<RD_ReturnInvoices,RD_ReturnInvoice>
    {
        #region Factory Methods

        public static RD_ReturnInvoices Fetch()
        {
            return EF.DataPortal.Fetch<RD_ReturnInvoices>();
        }

		public static RD_ReturnInvoices Fetch(System.Linq.Expressions.Expression<Func<RD_ReturnInvoice, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<RD_ReturnInvoice>(exp,values);
            return EF.DataPortal.Fetch<RD_ReturnInvoices>(lambda);
		}

		public static RD_ReturnInvoices Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<RD_ReturnInvoices>(new Paging { Page=page,RowCount=rowCount});
        }

        public static RD_ReturnInvoices Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<RD_ReturnInvoice, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<RD_ReturnInvoices>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<RD_ReturnInvoice>(exp,values)});
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
