using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_FundInApp))]
#if Dev
    [RunLocal]
#endif

	public class PM_FundInApp:ReadOnlyBase<PM_FundInApp>
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

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public bool IsCheck
        {
            get ;
            set ;
        }

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public string ObjectId
        {
            get ;
            set ;
        }

		
        public string WorkflowId
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

		
        public string CheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_FundInApp Create()
        {
            return EF.DataPortal.Create<PM_FundInApp>();
        }

		public static PM_FundInApp Fetch(System.Linq.Expressions.Expression<Func<PM_FundInApp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_FundInApp>(exp,values);
            return EF.DataPortal.Fetch<PM_FundInApp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_FundInApps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_FundInApps:ReadOnlyListBase<PM_FundInApps,PM_FundInApp>
    {
        #region Factory Methods

        public static PM_FundInApps Fetch()
        {
            return EF.DataPortal.Fetch<PM_FundInApps>();
        }

		public static PM_FundInApps Fetch(System.Linq.Expressions.Expression<Func<PM_FundInApp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_FundInApp>(exp,values);
            return EF.DataPortal.Fetch<PM_FundInApps>(lambda);
		}

		public static PM_FundInApps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_FundInApps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_FundInApps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_FundInApp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_FundInApps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_FundInApp>(exp,values)});
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
