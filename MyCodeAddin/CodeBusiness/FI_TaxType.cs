using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_TaxType))]
#if Dev
    [RunLocal]
#endif

	public class FI_TaxType:ReadOnlyBase<FI_TaxType>
    {
        #region Business Methods

		
        public string TaxCode
        {
            get ;
            set ;
        }

		
        public string TaxName
        {
            get ;
            set ;
        }

		
        public decimal TaxRate
        {
            get ;
            set ;
        }

		
        public string TaxType
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public bool IsInPrice
        {
            get ;
            set ;
        }

		
        public bool IsInvTax
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_TaxType Create()
        {
            return EF.DataPortal.Create<FI_TaxType>();
        }

		public static FI_TaxType Fetch(System.Linq.Expressions.Expression<Func<FI_TaxType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_TaxType>(exp,values);
            return EF.DataPortal.Fetch<FI_TaxType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_TaxTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_TaxTypes:ReadOnlyListBase<FI_TaxTypes,FI_TaxType>
    {
        #region Factory Methods

        public static FI_TaxTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_TaxTypes>();
        }

		public static FI_TaxTypes Fetch(System.Linq.Expressions.Expression<Func<FI_TaxType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_TaxType>(exp,values);
            return EF.DataPortal.Fetch<FI_TaxTypes>(lambda);
		}

		public static FI_TaxTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_TaxTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_TaxTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_TaxType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_TaxTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_TaxType>(exp,values)});
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
