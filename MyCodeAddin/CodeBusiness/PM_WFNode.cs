using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_WFNode))]
#if Dev
    [RunLocal]
#endif

	public class PM_WFNode:ReadOnlyBase<PM_WFNode>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WFNodeCode
        {
            get ;
            set ;
        }

		
        public string WFNodeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_WFNode Create()
        {
            return EF.DataPortal.Create<PM_WFNode>();
        }

		public static PM_WFNode Fetch(System.Linq.Expressions.Expression<Func<PM_WFNode, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_WFNode>(exp,values);
            return EF.DataPortal.Fetch<PM_WFNode>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_WFNodes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_WFNodes:ReadOnlyListBase<PM_WFNodes,PM_WFNode>
    {
        #region Factory Methods

        public static PM_WFNodes Fetch()
        {
            return EF.DataPortal.Fetch<PM_WFNodes>();
        }

		public static PM_WFNodes Fetch(System.Linq.Expressions.Expression<Func<PM_WFNode, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_WFNode>(exp,values);
            return EF.DataPortal.Fetch<PM_WFNodes>(lambda);
		}

		public static PM_WFNodes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_WFNodes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_WFNodes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_WFNode, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_WFNodes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_WFNode>(exp,values)});
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
