using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayAllotSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayAllotSub:ReadOnlyBase<FI_GovPayAllotSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string GovAllotNo
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

		
        public string GovPlayCode
        {
            get ;
            set ;
        }

		
        public string VouchNo
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

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_GovPayAllotSub Create()
        {
            return EF.DataPortal.Create<FI_GovPayAllotSub>();
        }

		public static FI_GovPayAllotSub Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayAllotSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayAllotSub>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayAllotSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayAllotSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayAllotSubs:ReadOnlyListBase<FI_GovPayAllotSubs,FI_GovPayAllotSub>
    {
        #region Factory Methods

        public static FI_GovPayAllotSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotSubs>();
        }

		public static FI_GovPayAllotSubs Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayAllotSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayAllotSub>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayAllotSubs>(lambda);
		}

		public static FI_GovPayAllotSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayAllotSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayAllotSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayAllotSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayAllotSub>(exp,values)});
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
