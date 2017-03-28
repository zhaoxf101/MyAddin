using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjInBillSub))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjInBillSub:ReadOnlyBase<PM_ProjInBillSub>
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

		
        public string PostDate
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

		
        public decimal AlloAmt
        {
            get ;
            set ;
        }

		
        public decimal CurInAmt
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

		public static PM_ProjInBillSub Create()
        {
            return EF.DataPortal.Create<PM_ProjInBillSub>();
        }

		public static PM_ProjInBillSub Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInBillSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInBillSub>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInBillSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjInBillSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjInBillSubs:ReadOnlyListBase<PM_ProjInBillSubs,PM_ProjInBillSub>
    {
        #region Factory Methods

        public static PM_ProjInBillSubs Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjInBillSubs>();
        }

		public static PM_ProjInBillSubs Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInBillSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInBillSub>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInBillSubs>(lambda);
		}

		public static PM_ProjInBillSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjInBillSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjInBillSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjInBillSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjInBillSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjInBillSub>(exp,values)});
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
