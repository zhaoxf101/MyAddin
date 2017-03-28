using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PerFreeTaxItem))]
#if Dev
    [RunLocal]
#endif

	public class FI_PerFreeTaxItem:ReadOnlyBase<FI_PerFreeTaxItem>
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

		
        public string UType
        {
            get ;
            set ;
        }

		
        public string EmpStatusCode
        {
            get ;
            set ;
        }

		
        public bool IsInReg
        {
            get ;
            set ;
        }

		
        public bool IsFreeTax
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PerFreeTaxItem Create()
        {
            return EF.DataPortal.Create<FI_PerFreeTaxItem>();
        }

		public static FI_PerFreeTaxItem Fetch(System.Linq.Expressions.Expression<Func<FI_PerFreeTaxItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PerFreeTaxItem>(exp,values);
            return EF.DataPortal.Fetch<FI_PerFreeTaxItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PerFreeTaxItems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PerFreeTaxItems:ReadOnlyListBase<FI_PerFreeTaxItems,FI_PerFreeTaxItem>
    {
        #region Factory Methods

        public static FI_PerFreeTaxItems Fetch()
        {
            return EF.DataPortal.Fetch<FI_PerFreeTaxItems>();
        }

		public static FI_PerFreeTaxItems Fetch(System.Linq.Expressions.Expression<Func<FI_PerFreeTaxItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PerFreeTaxItem>(exp,values);
            return EF.DataPortal.Fetch<FI_PerFreeTaxItems>(lambda);
		}

		public static FI_PerFreeTaxItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PerFreeTaxItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PerFreeTaxItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PerFreeTaxItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PerFreeTaxItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PerFreeTaxItem>(exp,values)});
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
