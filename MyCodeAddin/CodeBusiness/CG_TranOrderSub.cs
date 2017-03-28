using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_TranOrderSub))]
#if Dev
    [RunLocal]
#endif

	public class CG_TranOrderSub:ReadOnlyBase<CG_TranOrderSub>
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

		
        public Guid TranOrderId
        {
            get ;
            set ;
        }

		
        public string TranOrderNo
        {
            get ;
            set ;
        }

		
        public Guid? OrderId
        {
            get ;
            set ;
        }

		
        public string OrderNo
        {
            get ;
            set ;
        }

		
        public string FeeItemCode
        {
            get ;
            set ;
        }

		
        public string IntervalCode
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

		public static CG_TranOrderSub Create()
        {
            return EF.DataPortal.Create<CG_TranOrderSub>();
        }

		public static CG_TranOrderSub Fetch(System.Linq.Expressions.Expression<Func<CG_TranOrderSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_TranOrderSub>(exp,values);
            return EF.DataPortal.Fetch<CG_TranOrderSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_TranOrderSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_TranOrderSubs:ReadOnlyListBase<CG_TranOrderSubs,CG_TranOrderSub>
    {
        #region Factory Methods

        public static CG_TranOrderSubs Fetch()
        {
            return EF.DataPortal.Fetch<CG_TranOrderSubs>();
        }

		public static CG_TranOrderSubs Fetch(System.Linq.Expressions.Expression<Func<CG_TranOrderSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_TranOrderSub>(exp,values);
            return EF.DataPortal.Fetch<CG_TranOrderSubs>(lambda);
		}

		public static CG_TranOrderSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_TranOrderSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_TranOrderSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_TranOrderSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_TranOrderSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_TranOrderSub>(exp,values)});
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
