using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_GrpLeaf))]
#if Dev
    [RunLocal]
#endif

	public class Sys_GrpLeaf:ReadOnlyBase<Sys_GrpLeaf>
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

		
        public string LeafValue
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

		public static Sys_GrpLeaf Create()
        {
            return EF.DataPortal.Create<Sys_GrpLeaf>();
        }

		public static Sys_GrpLeaf Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpLeaf, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpLeaf>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpLeaf>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_GrpLeafs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_GrpLeafs:ReadOnlyListBase<Sys_GrpLeafs,Sys_GrpLeaf>
    {
        #region Factory Methods

        public static Sys_GrpLeafs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_GrpLeafs>();
        }

		public static Sys_GrpLeafs Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpLeaf, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpLeaf>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpLeafs>(lambda);
		}

		public static Sys_GrpLeafs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_GrpLeafs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_GrpLeafs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_GrpLeaf, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_GrpLeafs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_GrpLeaf>(exp,values)});
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
