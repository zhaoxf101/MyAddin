using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjWFNode))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjWFNode:ReadOnlyBase<PM_ProjWFNode>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string WFNodeCode
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ProjWFNode Create()
        {
            return EF.DataPortal.Create<PM_ProjWFNode>();
        }

		public static PM_ProjWFNode Fetch(System.Linq.Expressions.Expression<Func<PM_ProjWFNode, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjWFNode>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjWFNode>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjWFNodes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjWFNodes:ReadOnlyListBase<PM_ProjWFNodes,PM_ProjWFNode>
    {
        #region Factory Methods

        public static PM_ProjWFNodes Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjWFNodes>();
        }

		public static PM_ProjWFNodes Fetch(System.Linq.Expressions.Expression<Func<PM_ProjWFNode, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjWFNode>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjWFNodes>(lambda);
		}

		public static PM_ProjWFNodes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjWFNodes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjWFNodes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjWFNode, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjWFNodes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjWFNode>(exp,values)});
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
