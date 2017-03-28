using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_FundInAppSub))]
#if Dev
    [RunLocal]
#endif

	public class PM_FundInAppSub:ReadOnlyBase<PM_FundInAppSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string InNo
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
        public string PostDate
        {
            get ;
            set ;
        }

		
        public decimal AppAmt
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

		public static PM_FundInAppSub Create()
        {
            return EF.DataPortal.Create<PM_FundInAppSub>();
        }

		public static PM_FundInAppSub Fetch(System.Linq.Expressions.Expression<Func<PM_FundInAppSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_FundInAppSub>(exp,values);
            return EF.DataPortal.Fetch<PM_FundInAppSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_FundInAppSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_FundInAppSubs:ReadOnlyListBase<PM_FundInAppSubs,PM_FundInAppSub>
    {
        #region Factory Methods

        public static PM_FundInAppSubs Fetch()
        {
            return EF.DataPortal.Fetch<PM_FundInAppSubs>();
        }

		public static PM_FundInAppSubs Fetch(System.Linq.Expressions.Expression<Func<PM_FundInAppSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_FundInAppSub>(exp,values);
            return EF.DataPortal.Fetch<PM_FundInAppSubs>(lambda);
		}

		public static PM_FundInAppSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_FundInAppSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_FundInAppSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_FundInAppSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_FundInAppSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_FundInAppSub>(exp,values)});
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
