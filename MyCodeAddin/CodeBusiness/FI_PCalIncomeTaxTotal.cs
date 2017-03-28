using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PCalIncomeTaxTotal))]
#if Dev
    [RunLocal]
#endif

	public class FI_PCalIncomeTaxTotal:ReadOnlyBase<FI_PCalIncomeTaxTotal>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public decimal Income
        {
            get ;
            set ;
        }

		
        public decimal Payment
        {
            get ;
            set ;
        }

		
        public decimal FreeTax
        {
            get ;
            set ;
        }

		
        public decimal TaxIncome
        {
            get ;
            set ;
        }

		
        public decimal SalaryAccruedTax
        {
            get ;
            set ;
        }

		
        public decimal AccruedTax
        {
            get ;
            set ;
        }

		
        public decimal PaidtTax
        {
            get ;
            set ;
        }

		
        public decimal ToDeductTax
        {
            get ;
            set ;
        }

		
        public decimal ActTaxAmt
        {
            get ;
            set ;
        }

		
        public decimal ReportIncome
        {
            get ;
            set ;
        }

		
        public decimal WaitPaidTax
        {
            get ;
            set ;
        }

		
        public decimal Salary
        {
            get ;
            set ;
        }

		
        public string UserType
        {
            get ;
            set ;
        }

		
        public string UserID
        {
            get ;
            set ;
        }

		
        public bool IsAppovel
        {
            get ;
            set ;
        }

		
        public bool IsFreeTax
        {
            get ;
            set ;
        }

		
        public string TaxAdjUser
        {
            get ;
            set ;
        }

		
        public DateTime? TaxAdjDateTime
        {
            get ;
            set ;
        }

		
        public string TaxAdjText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PCalIncomeTaxTotal Create()
        {
            return EF.DataPortal.Create<FI_PCalIncomeTaxTotal>();
        }

		public static FI_PCalIncomeTaxTotal Fetch(System.Linq.Expressions.Expression<Func<FI_PCalIncomeTaxTotal, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PCalIncomeTaxTotal>(exp,values);
            return EF.DataPortal.Fetch<FI_PCalIncomeTaxTotal>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PCalIncomeTaxTotals))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PCalIncomeTaxTotals:ReadOnlyListBase<FI_PCalIncomeTaxTotals,FI_PCalIncomeTaxTotal>
    {
        #region Factory Methods

        public static FI_PCalIncomeTaxTotals Fetch()
        {
            return EF.DataPortal.Fetch<FI_PCalIncomeTaxTotals>();
        }

		public static FI_PCalIncomeTaxTotals Fetch(System.Linq.Expressions.Expression<Func<FI_PCalIncomeTaxTotal, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PCalIncomeTaxTotal>(exp,values);
            return EF.DataPortal.Fetch<FI_PCalIncomeTaxTotals>(lambda);
		}

		public static FI_PCalIncomeTaxTotals Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PCalIncomeTaxTotals>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PCalIncomeTaxTotals Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PCalIncomeTaxTotal, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PCalIncomeTaxTotals>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PCalIncomeTaxTotal>(exp,values)});
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
