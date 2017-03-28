using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(RD_InvoiceVouch))]
#if Dev
    [RunLocal]
#endif

	public class RD_InvoiceVouch:ReadOnlyBase<RD_InvoiceVouch>
    {
        #region Business Methods

		
        public string InvoiceCode
        {
            get ;
            set ;
        }

		
        public string InvoiceNo
        {
            get ;
            set ;
        }

		
        public DateTime? InvoiceDate
        {
            get ;
            set ;
        }

		
        public string IndustryClass
        {
            get ;
            set ;
        }

		
        public decimal? TotalAmt
        {
            get ;
            set ;
        }

		
        public string RecipName
        {
            get ;
            set ;
        }

		
        public string RecipNameTaxRegID
        {
            get ;
            set ;
        }

		
        public string PayeeUnit
        {
            get ;
            set ;
        }

		
        public string PayeeUnitTaxRegID
        {
            get ;
            set ;
        }

		
        public string InvoiceMemo
        {
            get ;
            set ;
        }

		
        public string TaxCode
        {
            get ;
            set ;
        }

		
        public string InvoiceDrawer
        {
            get ;
            set ;
        }

		
        public string InvoicePayeer
        {
            get ;
            set ;
        }

		
        public string InvoiceType
        {
            get ;
            set ;
        }

		
        public decimal? TotalMoneyCanceled
        {
            get ;
            set ;
        }

		
        public decimal? ExecuteAmt
        {
            get ;
            set ;
        }

		
        public string ProjectManager
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static RD_InvoiceVouch Create()
        {
            return EF.DataPortal.Create<RD_InvoiceVouch>();
        }

		public static RD_InvoiceVouch Fetch(System.Linq.Expressions.Expression<Func<RD_InvoiceVouch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<RD_InvoiceVouch>(exp,values);
            return EF.DataPortal.Fetch<RD_InvoiceVouch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(RD_InvoiceVouchs))]
#if Dev
    [RunLocal]
#endif
	
	public class RD_InvoiceVouchs:ReadOnlyListBase<RD_InvoiceVouchs,RD_InvoiceVouch>
    {
        #region Factory Methods

        public static RD_InvoiceVouchs Fetch()
        {
            return EF.DataPortal.Fetch<RD_InvoiceVouchs>();
        }

		public static RD_InvoiceVouchs Fetch(System.Linq.Expressions.Expression<Func<RD_InvoiceVouch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<RD_InvoiceVouch>(exp,values);
            return EF.DataPortal.Fetch<RD_InvoiceVouchs>(lambda);
		}

		public static RD_InvoiceVouchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<RD_InvoiceVouchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static RD_InvoiceVouchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<RD_InvoiceVouch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<RD_InvoiceVouchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<RD_InvoiceVouch>(exp,values)});
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
