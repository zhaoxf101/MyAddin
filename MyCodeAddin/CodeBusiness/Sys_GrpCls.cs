using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_GrpCls))]
#if Dev
    [RunLocal]
#endif

	public class Sys_GrpCls:ReadOnlyBase<Sys_GrpCls>
    {
        #region Business Methods

		
        public string GrpCls
        {
            get ;
            set ;
        }

		
        public string DTEXT
        {
            get ;
            set ;
        }

		
        public long? CrossClient
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_GrpCls Create()
        {
            return EF.DataPortal.Create<Sys_GrpCls>();
        }

		public static Sys_GrpCls Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpCls, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpCls>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpCls>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_GrpClss))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_GrpClss:ReadOnlyListBase<Sys_GrpClss,Sys_GrpCls>
    {
        #region Factory Methods

        public static Sys_GrpClss Fetch()
        {
            return EF.DataPortal.Fetch<Sys_GrpClss>();
        }

		public static Sys_GrpClss Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpCls, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpCls>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpClss>(lambda);
		}

		public static Sys_GrpClss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_GrpClss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_GrpClss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_GrpCls, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_GrpClss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_GrpCls>(exp,values)});
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
