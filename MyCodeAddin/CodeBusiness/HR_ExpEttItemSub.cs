using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_ExpEttItemSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_ExpEttItemSub:ReadOnlyBase<HR_ExpEttItemSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EttItemCode
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
        {
            get ;
            set ;
        }

		
        public decimal? Per
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_ExpEttItemSub Create()
        {
            return EF.DataPortal.Create<HR_ExpEttItemSub>();
        }

		public static HR_ExpEttItemSub Fetch(System.Linq.Expressions.Expression<Func<HR_ExpEttItemSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_ExpEttItemSub>(exp,values);
            return EF.DataPortal.Fetch<HR_ExpEttItemSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_ExpEttItemSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_ExpEttItemSubs:ReadOnlyListBase<HR_ExpEttItemSubs,HR_ExpEttItemSub>
    {
        #region Factory Methods

        public static HR_ExpEttItemSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_ExpEttItemSubs>();
        }

		public static HR_ExpEttItemSubs Fetch(System.Linq.Expressions.Expression<Func<HR_ExpEttItemSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_ExpEttItemSub>(exp,values);
            return EF.DataPortal.Fetch<HR_ExpEttItemSubs>(lambda);
		}

		public static HR_ExpEttItemSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_ExpEttItemSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_ExpEttItemSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_ExpEttItemSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_ExpEttItemSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_ExpEttItemSub>(exp,values)});
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
