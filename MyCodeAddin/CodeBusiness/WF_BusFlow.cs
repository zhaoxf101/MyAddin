using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_BusFlow))]
#if Dev
    [RunLocal]
#endif

	public class WF_BusFlow:ReadOnlyBase<WF_BusFlow>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BusModule
        {
            get ;
            set ;
        }

		
        public string WorkflowId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_BusFlow Create()
        {
            return EF.DataPortal.Create<WF_BusFlow>();
        }

		public static WF_BusFlow Fetch(System.Linq.Expressions.Expression<Func<WF_BusFlow, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_BusFlow>(exp,values);
            return EF.DataPortal.Fetch<WF_BusFlow>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_BusFlows))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_BusFlows:ReadOnlyListBase<WF_BusFlows,WF_BusFlow>
    {
        #region Factory Methods

        public static WF_BusFlows Fetch()
        {
            return EF.DataPortal.Fetch<WF_BusFlows>();
        }

		public static WF_BusFlows Fetch(System.Linq.Expressions.Expression<Func<WF_BusFlow, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_BusFlow>(exp,values);
            return EF.DataPortal.Fetch<WF_BusFlows>(lambda);
		}

		public static WF_BusFlows Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_BusFlows>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_BusFlows Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_BusFlow, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_BusFlows>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_BusFlow>(exp,values)});
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
