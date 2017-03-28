using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ResouItemCLT))]
#if Dev
    [RunLocal]
#endif

	public class PM_ResouItemCLT:ReadOnlyBase<PM_ResouItemCLT>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string TaxTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsTimelyTax
        {
            get ;
            set ;
        }

		
        public bool IsCalTax
        {
            get ;
            set ;
        }

		
        public decimal TaxMinIncome
        {
            get ;
            set ;
        }

		
        public int TaxPeriod
        {
            get ;
            set ;
        }

		
        public bool IsSubsidy
        {
            get ;
            set ;
        }

		
        public decimal SubsidyStand
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ResouItemCLT Create()
        {
            return EF.DataPortal.Create<PM_ResouItemCLT>();
        }

		public static PM_ResouItemCLT Fetch(System.Linq.Expressions.Expression<Func<PM_ResouItemCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ResouItemCLT>(exp,values);
            return EF.DataPortal.Fetch<PM_ResouItemCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ResouItemCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ResouItemCLTs:ReadOnlyListBase<PM_ResouItemCLTs,PM_ResouItemCLT>
    {
        #region Factory Methods

        public static PM_ResouItemCLTs Fetch()
        {
            return EF.DataPortal.Fetch<PM_ResouItemCLTs>();
        }

		public static PM_ResouItemCLTs Fetch(System.Linq.Expressions.Expression<Func<PM_ResouItemCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ResouItemCLT>(exp,values);
            return EF.DataPortal.Fetch<PM_ResouItemCLTs>(lambda);
		}

		public static PM_ResouItemCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ResouItemCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ResouItemCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ResouItemCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ResouItemCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ResouItemCLT>(exp,values)});
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
