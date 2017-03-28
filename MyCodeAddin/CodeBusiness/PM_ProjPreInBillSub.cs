using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjPreInBillSub))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjPreInBillSub:ReadOnlyBase<PM_ProjPreInBillSub>
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

		
        public string PreInNo
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

		public static PM_ProjPreInBillSub Create()
        {
            return EF.DataPortal.Create<PM_ProjPreInBillSub>();
        }

		public static PM_ProjPreInBillSub Fetch(System.Linq.Expressions.Expression<Func<PM_ProjPreInBillSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjPreInBillSub>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjPreInBillSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjPreInBillSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjPreInBillSubs:ReadOnlyListBase<PM_ProjPreInBillSubs,PM_ProjPreInBillSub>
    {
        #region Factory Methods

        public static PM_ProjPreInBillSubs Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjPreInBillSubs>();
        }

		public static PM_ProjPreInBillSubs Fetch(System.Linq.Expressions.Expression<Func<PM_ProjPreInBillSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjPreInBillSub>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjPreInBillSubs>(lambda);
		}

		public static PM_ProjPreInBillSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjPreInBillSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjPreInBillSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjPreInBillSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjPreInBillSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjPreInBillSub>(exp,values)});
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
