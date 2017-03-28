using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_SurTax))]
#if Dev
    [RunLocal]
#endif

	public class FI_SurTax:ReadOnlyBase<FI_SurTax>
    {
        #region Business Methods

		
        public string TaxCode
        {
            get ;
            set ;
        }

		
        public string SurCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_SurTax Create()
        {
            return EF.DataPortal.Create<FI_SurTax>();
        }

		public static FI_SurTax Fetch(System.Linq.Expressions.Expression<Func<FI_SurTax, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_SurTax>(exp,values);
            return EF.DataPortal.Fetch<FI_SurTax>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_SurTaxs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_SurTaxs:ReadOnlyListBase<FI_SurTaxs,FI_SurTax>
    {
        #region Factory Methods

        public static FI_SurTaxs Fetch()
        {
            return EF.DataPortal.Fetch<FI_SurTaxs>();
        }

		public static FI_SurTaxs Fetch(System.Linq.Expressions.Expression<Func<FI_SurTax, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_SurTax>(exp,values);
            return EF.DataPortal.Fetch<FI_SurTaxs>(lambda);
		}

		public static FI_SurTaxs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_SurTaxs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_SurTaxs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_SurTax, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_SurTaxs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_SurTax>(exp,values)});
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
