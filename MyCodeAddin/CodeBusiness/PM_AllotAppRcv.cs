using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotAppRcv))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotAppRcv:ReadOnlyBase<PM_AllotAppRcv>
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

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string ProjInNo
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

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string GovPlayCode
        {
            get ;
            set ;
        }

		
        public string OneTimeParty
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public decimal LAmt
        {
            get ;
            set ;
        }

		
        public decimal CAmt
        {
            get ;
            set ;
        }

		
        public decimal OAmt
        {
            get ;
            set ;
        }

		
        public decimal UAmt
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

		
		#endregion

		#region Factory Methods

		public static PM_AllotAppRcv Create()
        {
            return EF.DataPortal.Create<PM_AllotAppRcv>();
        }

		public static PM_AllotAppRcv Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppRcv, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppRcv>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppRcv>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotAppRcvs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotAppRcvs:ReadOnlyListBase<PM_AllotAppRcvs,PM_AllotAppRcv>
    {
        #region Factory Methods

        public static PM_AllotAppRcvs Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotAppRcvs>();
        }

		public static PM_AllotAppRcvs Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppRcv, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppRcv>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppRcvs>(lambda);
		}

		public static PM_AllotAppRcvs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotAppRcvs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotAppRcvs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotAppRcv, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotAppRcvs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotAppRcv>(exp,values)});
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
