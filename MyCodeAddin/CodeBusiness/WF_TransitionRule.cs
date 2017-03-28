using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_TransitionRule))]
#if Dev
    [RunLocal]
#endif

	public class WF_TransitionRule:ReadOnlyBase<WF_TransitionRule>
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

		
        public int Position
        {
            get ;
            set ;
        }

		
        public string PropertyId
        {
            get ;
            set ;
        }

		
        public string Operator
        {
            get ;
            set ;
        }

		
        public string Constants
        {
            get ;
            set ;
        }

		
        public string AndOr
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_TransitionRule Create()
        {
            return EF.DataPortal.Create<WF_TransitionRule>();
        }

		public static WF_TransitionRule Fetch(System.Linq.Expressions.Expression<Func<WF_TransitionRule, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_TransitionRule>(exp,values);
            return EF.DataPortal.Fetch<WF_TransitionRule>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_TransitionRules))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_TransitionRules:ReadOnlyListBase<WF_TransitionRules,WF_TransitionRule>
    {
        #region Factory Methods

        public static WF_TransitionRules Fetch()
        {
            return EF.DataPortal.Fetch<WF_TransitionRules>();
        }

		public static WF_TransitionRules Fetch(System.Linq.Expressions.Expression<Func<WF_TransitionRule, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_TransitionRule>(exp,values);
            return EF.DataPortal.Fetch<WF_TransitionRules>(lambda);
		}

		public static WF_TransitionRules Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_TransitionRules>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_TransitionRules Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_TransitionRule, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_TransitionRules>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_TransitionRule>(exp,values)});
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
