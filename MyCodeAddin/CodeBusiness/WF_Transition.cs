using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_Transition))]
#if Dev
    [RunLocal]
#endif

	public class WF_Transition:ReadOnlyBase<WF_Transition>
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

		
        public string ActivityName
        {
            get ;
            set ;
        }

		
        public string ToState
        {
            get ;
            set ;
        }

		
        public bool IsRule
        {
            get ;
            set ;
        }

		
        public bool CanUndo
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TimeStamp
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_Transition Create()
        {
            return EF.DataPortal.Create<WF_Transition>();
        }

		public static WF_Transition Fetch(System.Linq.Expressions.Expression<Func<WF_Transition, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_Transition>(exp,values);
            return EF.DataPortal.Fetch<WF_Transition>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_Transitions))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_Transitions:ReadOnlyListBase<WF_Transitions,WF_Transition>
    {
        #region Factory Methods

        public static WF_Transitions Fetch()
        {
            return EF.DataPortal.Fetch<WF_Transitions>();
        }

		public static WF_Transitions Fetch(System.Linq.Expressions.Expression<Func<WF_Transition, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_Transition>(exp,values);
            return EF.DataPortal.Fetch<WF_Transitions>(lambda);
		}

		public static WF_Transitions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_Transitions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_Transitions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_Transition, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_Transitions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_Transition>(exp,values)});
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
