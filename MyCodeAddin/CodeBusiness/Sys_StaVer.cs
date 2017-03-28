using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_StaVer))]
#if Dev
    [RunLocal]
#endif

	public class Sys_StaVer:ReadOnlyBase<Sys_StaVer>
    {
        #region Business Methods

		
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

		public static Sys_StaVer Create()
        {
            return EF.DataPortal.Create<Sys_StaVer>();
        }

		public static Sys_StaVer Fetch(System.Linq.Expressions.Expression<Func<Sys_StaVer, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_StaVer>(exp,values);
            return EF.DataPortal.Fetch<Sys_StaVer>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_StaVers))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_StaVers:ReadOnlyListBase<Sys_StaVers,Sys_StaVer>
    {
        #region Factory Methods

        public static Sys_StaVers Fetch()
        {
            return EF.DataPortal.Fetch<Sys_StaVers>();
        }

		public static Sys_StaVers Fetch(System.Linq.Expressions.Expression<Func<Sys_StaVer, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_StaVer>(exp,values);
            return EF.DataPortal.Fetch<Sys_StaVers>(lambda);
		}

		public static Sys_StaVers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_StaVers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_StaVers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_StaVer, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_StaVers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_StaVer>(exp,values)});
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
