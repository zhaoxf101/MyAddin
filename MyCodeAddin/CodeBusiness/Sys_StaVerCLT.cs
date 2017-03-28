using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_StaVerCLT))]
#if Dev
    [RunLocal]
#endif

	public class Sys_StaVerCLT:ReadOnlyBase<Sys_StaVerCLT>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TableName
        {
            get ;
            set ;
        }

		
        public string VerId
        {
            get ;
            set ;
        }

		
        public string ParentId
        {
            get ;
            set ;
        }

		
        public string ChildId
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

		public static Sys_StaVerCLT Create()
        {
            return EF.DataPortal.Create<Sys_StaVerCLT>();
        }

		public static Sys_StaVerCLT Fetch(System.Linq.Expressions.Expression<Func<Sys_StaVerCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_StaVerCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_StaVerCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_StaVerCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_StaVerCLTs:ReadOnlyListBase<Sys_StaVerCLTs,Sys_StaVerCLT>
    {
        #region Factory Methods

        public static Sys_StaVerCLTs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_StaVerCLTs>();
        }

		public static Sys_StaVerCLTs Fetch(System.Linq.Expressions.Expression<Func<Sys_StaVerCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_StaVerCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_StaVerCLTs>(lambda);
		}

		public static Sys_StaVerCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_StaVerCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_StaVerCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_StaVerCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_StaVerCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_StaVerCLT>(exp,values)});
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
