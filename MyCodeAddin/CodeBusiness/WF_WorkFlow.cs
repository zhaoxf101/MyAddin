using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_WorkFlow))]
#if Dev
    [RunLocal]
#endif

	public class WF_WorkFlow:ReadOnlyBase<WF_WorkFlow>
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

		
        public string WorkflowName
        {
            get ;
            set ;
        }

		
        public string WorkflowGroup
        {
            get ;
            set ;
        }

		
        public string InitialState
        {
            get ;
            set ;
        }

		
        public bool Stoped
        {
            get ;
            set ;
        }

		
        public string Description
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

		public static WF_WorkFlow Create()
        {
            return EF.DataPortal.Create<WF_WorkFlow>();
        }

		public static WF_WorkFlow Fetch(System.Linq.Expressions.Expression<Func<WF_WorkFlow, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_WorkFlow>(exp,values);
            return EF.DataPortal.Fetch<WF_WorkFlow>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_WorkFlows))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_WorkFlows:ReadOnlyListBase<WF_WorkFlows,WF_WorkFlow>
    {
        #region Factory Methods

        public static WF_WorkFlows Fetch()
        {
            return EF.DataPortal.Fetch<WF_WorkFlows>();
        }

		public static WF_WorkFlows Fetch(System.Linq.Expressions.Expression<Func<WF_WorkFlow, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_WorkFlow>(exp,values);
            return EF.DataPortal.Fetch<WF_WorkFlows>(lambda);
		}

		public static WF_WorkFlows Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_WorkFlows>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_WorkFlows Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_WorkFlow, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_WorkFlows>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_WorkFlow>(exp,values)});
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
