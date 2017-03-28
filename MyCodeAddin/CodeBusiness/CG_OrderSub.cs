using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_OrderSub))]
#if Dev
    [RunLocal]
#endif

	public class CG_OrderSub:ReadOnlyBase<CG_OrderSub>
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

		
        public string OrderNo
        {
            get ;
            set ;
        }

		
        public decimal OrderAmt
        {
            get ;
            set ;
        }

		
        public decimal AdjAmt
        {
            get ;
            set ;
        }

		
        public decimal CAmt
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

		public static CG_OrderSub Create()
        {
            return EF.DataPortal.Create<CG_OrderSub>();
        }

		public static CG_OrderSub Fetch(System.Linq.Expressions.Expression<Func<CG_OrderSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_OrderSub>(exp,values);
            return EF.DataPortal.Fetch<CG_OrderSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_OrderSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_OrderSubs:ReadOnlyListBase<CG_OrderSubs,CG_OrderSub>
    {
        #region Factory Methods

        public static CG_OrderSubs Fetch()
        {
            return EF.DataPortal.Fetch<CG_OrderSubs>();
        }

		public static CG_OrderSubs Fetch(System.Linq.Expressions.Expression<Func<CG_OrderSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_OrderSub>(exp,values);
            return EF.DataPortal.Fetch<CG_OrderSubs>(lambda);
		}

		public static CG_OrderSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_OrderSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_OrderSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_OrderSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_OrderSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_OrderSub>(exp,values)});
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
