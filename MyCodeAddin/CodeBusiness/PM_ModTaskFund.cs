using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ModTaskFund))]
#if Dev
    [RunLocal]
#endif

	public class PM_ModTaskFund:ReadOnlyBase<PM_ModTaskFund>
    {
        #region Business Methods

		
        public string Client
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

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
        public string FundExpTypeCode
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public bool IsPirFund
        {
            get ;
            set ;
        }

		
        public bool IsBudItem
        {
            get ;
            set ;
        }

		
        public bool IsFinItem
        {
            get ;
            set ;
        }

		
        public bool IsDeficit
        {
            get ;
            set ;
        }

		
        public bool IsCarryOver
        {
            get ;
            set ;
        }

		
        public bool IsFreeze
        {
            get ;
            set ;
        }

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public int ExpSort
        {
            get ;
            set ;
        }

		
        public bool IsExpSort
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ModTaskFund Create()
        {
            return EF.DataPortal.Create<PM_ModTaskFund>();
        }

		public static PM_ModTaskFund Fetch(System.Linq.Expressions.Expression<Func<PM_ModTaskFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ModTaskFund>(exp,values);
            return EF.DataPortal.Fetch<PM_ModTaskFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ModTaskFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ModTaskFunds:ReadOnlyListBase<PM_ModTaskFunds,PM_ModTaskFund>
    {
        #region Factory Methods

        public static PM_ModTaskFunds Fetch()
        {
            return EF.DataPortal.Fetch<PM_ModTaskFunds>();
        }

		public static PM_ModTaskFunds Fetch(System.Linq.Expressions.Expression<Func<PM_ModTaskFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ModTaskFund>(exp,values);
            return EF.DataPortal.Fetch<PM_ModTaskFunds>(lambda);
		}

		public static PM_ModTaskFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ModTaskFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ModTaskFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ModTaskFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ModTaskFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ModTaskFund>(exp,values)});
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
