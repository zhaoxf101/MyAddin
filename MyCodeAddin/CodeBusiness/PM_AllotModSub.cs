using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotModSub))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotModSub:ReadOnlyBase<PM_AllotModSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotModCode
        {
            get ;
            set ;
        }

		
        public string AllotItemCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public bool IsNod
        {
            get ;
            set ;
        }

		
        public decimal MaxAllotRate
        {
            get ;
            set ;
        }

		
        public string FundCode
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

		
        public string ResouItemCode
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

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_AllotModSub Create()
        {
            return EF.DataPortal.Create<PM_AllotModSub>();
        }

		public static PM_AllotModSub Fetch(System.Linq.Expressions.Expression<Func<PM_AllotModSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotModSub>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotModSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotModSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotModSubs:ReadOnlyListBase<PM_AllotModSubs,PM_AllotModSub>
    {
        #region Factory Methods

        public static PM_AllotModSubs Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotModSubs>();
        }

		public static PM_AllotModSubs Fetch(System.Linq.Expressions.Expression<Func<PM_AllotModSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotModSub>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotModSubs>(lambda);
		}

		public static PM_AllotModSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotModSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotModSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotModSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotModSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotModSub>(exp,values)});
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
