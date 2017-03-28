using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_GrpNode))]
#if Dev
    [RunLocal]
#endif

	public class Sys_GrpNode:ReadOnlyBase<Sys_GrpNode>
    {
        #region Business Methods

		
        public string GrpClass
        {
            get ;
            set ;
        }

		
        public string GrpName
        {
            get ;
            set ;
        }

		
        public int LineId
        {
            get ;
            set ;
        }

		
        public string SubGrp
        {
            get ;
            set ;
        }

		
        public int? Sort
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_GrpNode Create()
        {
            return EF.DataPortal.Create<Sys_GrpNode>();
        }

		public static Sys_GrpNode Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpNode, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpNode>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpNode>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_GrpNodes))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_GrpNodes:ReadOnlyListBase<Sys_GrpNodes,Sys_GrpNode>
    {
        #region Factory Methods

        public static Sys_GrpNodes Fetch()
        {
            return EF.DataPortal.Fetch<Sys_GrpNodes>();
        }

		public static Sys_GrpNodes Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpNode, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpNode>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpNodes>(lambda);
		}

		public static Sys_GrpNodes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_GrpNodes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_GrpNodes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_GrpNode, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_GrpNodes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_GrpNode>(exp,values)});
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
