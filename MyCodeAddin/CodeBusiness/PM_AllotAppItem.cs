using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotAppItem))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotAppItem:ReadOnlyBase<PM_AllotAppItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotAppNo
        {
            get ;
            set ;
        }

		
        public string AllotItemCode
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public bool IsNod
        {
            get ;
            set ;
        }

		
        public bool IsFixFee
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public bool IsAcc
        {
            get ;
            set ;
        }

		
        public bool IsExp
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal AppAmt
        {
            get ;
            set ;
        }

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string CAccCode
        {
            get ;
            set ;
        }

		
        public string DAccCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_AllotAppItem Create()
        {
            return EF.DataPortal.Create<PM_AllotAppItem>();
        }

		public static PM_AllotAppItem Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppItem>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotAppItems))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotAppItems:ReadOnlyListBase<PM_AllotAppItems,PM_AllotAppItem>
    {
        #region Factory Methods

        public static PM_AllotAppItems Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotAppItems>();
        }

		public static PM_AllotAppItems Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppItem>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppItems>(lambda);
		}

		public static PM_AllotAppItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotAppItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotAppItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotAppItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotAppItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotAppItem>(exp,values)});
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
