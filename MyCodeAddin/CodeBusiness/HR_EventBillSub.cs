using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EventBillSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_EventBillSub:ReadOnlyBase<HR_EventBillSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string EventCode
        {
            get ;
            set ;
        }

		
        public string RelationGroup
        {
            get ;
            set ;
        }

		
        public bool IsAppovel
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EventBillSub Create()
        {
            return EF.DataPortal.Create<HR_EventBillSub>();
        }

		public static HR_EventBillSub Fetch(System.Linq.Expressions.Expression<Func<HR_EventBillSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EventBillSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EventBillSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EventBillSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EventBillSubs:ReadOnlyListBase<HR_EventBillSubs,HR_EventBillSub>
    {
        #region Factory Methods

        public static HR_EventBillSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_EventBillSubs>();
        }

		public static HR_EventBillSubs Fetch(System.Linq.Expressions.Expression<Func<HR_EventBillSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EventBillSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EventBillSubs>(lambda);
		}

		public static HR_EventBillSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EventBillSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EventBillSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EventBillSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EventBillSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EventBillSub>(exp,values)});
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
