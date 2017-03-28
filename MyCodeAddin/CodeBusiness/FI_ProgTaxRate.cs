using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ProgTaxRate))]
#if Dev
    [RunLocal]
#endif

	public class FI_ProgTaxRate:ReadOnlyBase<FI_ProgTaxRate>
    {
        #region Business Methods

		
        public string ProgTaxItemCode
        {
            get ;
            set ;
        }

		
        public string ProgTaxItemName
        {
            get ;
            set ;
        }

		
        public int TaxLevel
        {
            get ;
            set ;
        }

		
        public decimal FreeTax
        {
            get ;
            set ;
        }

		
        public decimal TaxIncomeL
        {
            get ;
            set ;
        }

		
        public decimal TaxIncomeH
        {
            get ;
            set ;
        }

		
        public decimal TaxRate
        {
            get ;
            set ;
        }

		
        public decimal QDeduction
        {
            get ;
            set ;
        }

		
        public decimal ReportLevel
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ProgTaxRate Create()
        {
            return EF.DataPortal.Create<FI_ProgTaxRate>();
        }

		public static FI_ProgTaxRate Fetch(System.Linq.Expressions.Expression<Func<FI_ProgTaxRate, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ProgTaxRate>(exp,values);
            return EF.DataPortal.Fetch<FI_ProgTaxRate>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ProgTaxRates))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ProgTaxRates:ReadOnlyListBase<FI_ProgTaxRates,FI_ProgTaxRate>
    {
        #region Factory Methods

        public static FI_ProgTaxRates Fetch()
        {
            return EF.DataPortal.Fetch<FI_ProgTaxRates>();
        }

		public static FI_ProgTaxRates Fetch(System.Linq.Expressions.Expression<Func<FI_ProgTaxRate, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ProgTaxRate>(exp,values);
            return EF.DataPortal.Fetch<FI_ProgTaxRates>(lambda);
		}

		public static FI_ProgTaxRates Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ProgTaxRates>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ProgTaxRates Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ProgTaxRate, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ProgTaxRates>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ProgTaxRate>(exp,values)});
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
