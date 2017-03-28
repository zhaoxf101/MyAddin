using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(WF_RightsNode))]
#if Dev
    [RunLocal]
#endif

	public class WF_RightsNode:ReadOnlyBase<WF_RightsNode>
    {
        #region Business Methods

		
        public string RNodeCode
        {
            get ;
            set ;
        }

		
        public string RNodeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static WF_RightsNode Create()
        {
            return EF.DataPortal.Create<WF_RightsNode>();
        }

		public static WF_RightsNode Fetch(System.Linq.Expressions.Expression<Func<WF_RightsNode, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<WF_RightsNode>(exp,values);
            return EF.DataPortal.Fetch<WF_RightsNode>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(WF_RightsNodes))]
#if Dev
    [RunLocal]
#endif
	
	public class WF_RightsNodes:ReadOnlyListBase<WF_RightsNodes,WF_RightsNode>
    {
        #region Factory Methods

        public static WF_RightsNodes Fetch()
        {
            return EF.DataPortal.Fetch<WF_RightsNodes>();
        }

		public static WF_RightsNodes Fetch(System.Linq.Expressions.Expression<Func<WF_RightsNode, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<WF_RightsNode>(exp,values);
            return EF.DataPortal.Fetch<WF_RightsNodes>(lambda);
		}

		public static WF_RightsNodes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<WF_RightsNodes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static WF_RightsNodes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<WF_RightsNode, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<WF_RightsNodes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<WF_RightsNode>(exp,values)});
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
