using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_TaskFund))]
#if Dev
    [RunLocal]
#endif

	public class PM_TaskFund:ReadOnlyBase<PM_TaskFund>
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

		
        public string FundExpTypeCode
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public string FundFinAreaCode
        {
            get ;
            set ;
        }

		
        public string PBudExpFunCode
        {
            get ;
            set ;
        }

		
        public bool IsPirFund
        {
            get ;
            set ;
        }

		
        public bool IsInPirFund
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string FAccCode
        {
            get ;
            set ;
        }

		
        public string BAccCode
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

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public bool IsInCtrl
        {
            get ;
            set ;
        }

		
        public bool IsChkIn
        {
            get ;
            set ;
        }

		
        public bool IsFreeze
        {
            get ;
            set ;
        }

		
        public decimal MaxDeficit
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

		
        public bool IsCarryOver
        {
            get ;
            set ;
        }

		
        public bool IsCarryOverIn
        {
            get ;
            set ;
        }

		
        public bool IsCarryRedu
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_TaskFund Create()
        {
            return EF.DataPortal.Create<PM_TaskFund>();
        }

		public static PM_TaskFund Fetch(System.Linq.Expressions.Expression<Func<PM_TaskFund, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_TaskFund>(exp,values);
            return EF.DataPortal.Fetch<PM_TaskFund>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_TaskFunds))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_TaskFunds:ReadOnlyListBase<PM_TaskFunds,PM_TaskFund>
    {
        #region Factory Methods

        public static PM_TaskFunds Fetch()
        {
            return EF.DataPortal.Fetch<PM_TaskFunds>();
        }

		public static PM_TaskFunds Fetch(System.Linq.Expressions.Expression<Func<PM_TaskFund, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_TaskFund>(exp,values);
            return EF.DataPortal.Fetch<PM_TaskFunds>(lambda);
		}

		public static PM_TaskFunds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_TaskFunds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_TaskFunds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_TaskFund, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_TaskFunds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_TaskFund>(exp,values)});
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
