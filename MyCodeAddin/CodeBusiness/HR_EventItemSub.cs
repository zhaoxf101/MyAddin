using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EventItemSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_EventItemSub:ReadOnlyBase<HR_EventItemSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EventItemCode
        {
            get ;
            set ;
        }

		
        public string RelationCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EventItemSub Create()
        {
            return EF.DataPortal.Create<HR_EventItemSub>();
        }

		public static HR_EventItemSub Fetch(System.Linq.Expressions.Expression<Func<HR_EventItemSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EventItemSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EventItemSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EventItemSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EventItemSubs:ReadOnlyListBase<HR_EventItemSubs,HR_EventItemSub>
    {
        #region Factory Methods

        public static HR_EventItemSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_EventItemSubs>();
        }

		public static HR_EventItemSubs Fetch(System.Linq.Expressions.Expression<Func<HR_EventItemSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EventItemSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EventItemSubs>(lambda);
		}

		public static HR_EventItemSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EventItemSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EventItemSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EventItemSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EventItemSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EventItemSub>(exp,values)});
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
