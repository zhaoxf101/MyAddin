using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_BillSub))]
#if Dev
    [RunLocal]
#endif

	public class CG_BillSub:ReadOnlyBase<CG_BillSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_BillSub Create()
        {
            return EF.DataPortal.Create<CG_BillSub>();
        }

		public static CG_BillSub Fetch(System.Linq.Expressions.Expression<Func<CG_BillSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_BillSub>(exp,values);
            return EF.DataPortal.Fetch<CG_BillSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_BillSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_BillSubs:ReadOnlyListBase<CG_BillSubs,CG_BillSub>
    {
        #region Factory Methods

        public static CG_BillSubs Fetch()
        {
            return EF.DataPortal.Fetch<CG_BillSubs>();
        }

		public static CG_BillSubs Fetch(System.Linq.Expressions.Expression<Func<CG_BillSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_BillSub>(exp,values);
            return EF.DataPortal.Fetch<CG_BillSubs>(lambda);
		}

		public static CG_BillSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_BillSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_BillSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_BillSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_BillSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_BillSub>(exp,values)});
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
