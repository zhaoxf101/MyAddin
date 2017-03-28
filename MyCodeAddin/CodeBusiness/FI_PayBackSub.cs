using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PayBackSub))]
#if Dev
    [RunLocal]
#endif

	public class FI_PayBackSub:ReadOnlyBase<FI_PayBackSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PayBackNo
        {
            get ;
            set ;
        }

		
        public string ItemId
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string PayBackType
        {
            get ;
            set ;
        }

		
        public string GLMarK
        {
            get ;
            set ;
        }

		
        public string PartyCode
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

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public string PersonId
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

		public static FI_PayBackSub Create()
        {
            return EF.DataPortal.Create<FI_PayBackSub>();
        }

		public static FI_PayBackSub Fetch(System.Linq.Expressions.Expression<Func<FI_PayBackSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PayBackSub>(exp,values);
            return EF.DataPortal.Fetch<FI_PayBackSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PayBackSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PayBackSubs:ReadOnlyListBase<FI_PayBackSubs,FI_PayBackSub>
    {
        #region Factory Methods

        public static FI_PayBackSubs Fetch()
        {
            return EF.DataPortal.Fetch<FI_PayBackSubs>();
        }

		public static FI_PayBackSubs Fetch(System.Linq.Expressions.Expression<Func<FI_PayBackSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PayBackSub>(exp,values);
            return EF.DataPortal.Fetch<FI_PayBackSubs>(lambda);
		}

		public static FI_PayBackSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PayBackSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PayBackSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PayBackSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PayBackSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PayBackSub>(exp,values)});
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
