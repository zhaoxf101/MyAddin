using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_TransitionSub))]
#if Dev
    [RunLocal]
#endif

	public class WF_TransitionSub:ReadOnlyBase<WF_TransitionSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkflowId
        {
            get ;
            set ;
        }

		
        public string FromState
        {
            get ;
            set ;
        }

		
        public string ActivityId
        {
            get ;
            set ;
        }

		
        public string ToState
        {
            get ;
            set ;
        }

		
        public string GrpMark
        {
            get ;
            set ;
        }

		
        public string RuleText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_TransitionSub Create()
        {
            return EF.DataPortal.Create<WF_TransitionSub>();
        }

		public static WF_TransitionSub Fetch(System.Linq.Expressions.Expression<Func<WF_TransitionSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_TransitionSub>(exp,values);
            return EF.DataPortal.Fetch<WF_TransitionSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_TransitionSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_TransitionSubs:ReadOnlyListBase<WF_TransitionSubs,WF_TransitionSub>
    {
        #region Factory Methods

        public static WF_TransitionSubs Fetch()
        {
            return EF.DataPortal.Fetch<WF_TransitionSubs>();
        }

		public static WF_TransitionSubs Fetch(System.Linq.Expressions.Expression<Func<WF_TransitionSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_TransitionSub>(exp,values);
            return EF.DataPortal.Fetch<WF_TransitionSubs>(lambda);
		}

		public static WF_TransitionSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_TransitionSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_TransitionSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_TransitionSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_TransitionSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_TransitionSub>(exp,values)});
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
