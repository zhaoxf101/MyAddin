using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_TransitionSwitch))]
#if Dev
    [RunLocal]
#endif

	public class WF_TransitionSwitch:ReadOnlyBase<WF_TransitionSwitch>
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

		
        public string RuleId
        {
            get ;
            set ;
        }

		
        public bool Value
        {
            get ;
            set ;
        }

		
        public string Args
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_TransitionSwitch Create()
        {
            return EF.DataPortal.Create<WF_TransitionSwitch>();
        }

		public static WF_TransitionSwitch Fetch(System.Linq.Expressions.Expression<Func<WF_TransitionSwitch, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_TransitionSwitch>(exp,values);
            return EF.DataPortal.Fetch<WF_TransitionSwitch>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_TransitionSwitchs))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_TransitionSwitchs:ReadOnlyListBase<WF_TransitionSwitchs,WF_TransitionSwitch>
    {
        #region Factory Methods

        public static WF_TransitionSwitchs Fetch()
        {
            return EF.DataPortal.Fetch<WF_TransitionSwitchs>();
        }

		public static WF_TransitionSwitchs Fetch(System.Linq.Expressions.Expression<Func<WF_TransitionSwitch, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_TransitionSwitch>(exp,values);
            return EF.DataPortal.Fetch<WF_TransitionSwitchs>(lambda);
		}

		public static WF_TransitionSwitchs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_TransitionSwitchs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_TransitionSwitchs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_TransitionSwitch, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_TransitionSwitchs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_TransitionSwitch>(exp,values)});
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
