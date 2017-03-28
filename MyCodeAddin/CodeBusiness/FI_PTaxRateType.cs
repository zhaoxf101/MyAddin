using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PTaxRateType))]
#if Dev
    [RunLocal]
#endif

	public class FI_PTaxRateType:ReadOnlyBase<FI_PTaxRateType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TaxTypeCode
        {
            get ;
            set ;
        }

		
        public string TaxTypeName
        {
            get ;
            set ;
        }

		
        public string ProgTaxItemCode
        {
            get ;
            set ;
        }

		
        public decimal TaxRat
        {
            get ;
            set ;
        }

		
        public bool IsFixedTaxRate
        {
            get ;
            set ;
        }

		
        public bool IsFreeTax
        {
            get ;
            set ;
        }

		
        public decimal FreeTax
        {
            get ;
            set ;
        }

		
        public bool IsMonthEndTax
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PTaxRateType Create()
        {
            return EF.DataPortal.Create<FI_PTaxRateType>();
        }

		public static FI_PTaxRateType Fetch(System.Linq.Expressions.Expression<Func<FI_PTaxRateType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PTaxRateType>(exp,values);
            return EF.DataPortal.Fetch<FI_PTaxRateType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PTaxRateTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PTaxRateTypes:ReadOnlyListBase<FI_PTaxRateTypes,FI_PTaxRateType>
    {
        #region Factory Methods

        public static FI_PTaxRateTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_PTaxRateTypes>();
        }

		public static FI_PTaxRateTypes Fetch(System.Linq.Expressions.Expression<Func<FI_PTaxRateType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PTaxRateType>(exp,values);
            return EF.DataPortal.Fetch<FI_PTaxRateTypes>(lambda);
		}

		public static FI_PTaxRateTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PTaxRateTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PTaxRateTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PTaxRateType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PTaxRateTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PTaxRateType>(exp,values)});
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
