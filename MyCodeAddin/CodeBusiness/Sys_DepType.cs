using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_DepType))]
#if Dev
    [RunLocal]
#endif

	public class Sys_DepType:ReadOnlyBase<Sys_DepType>
    {
        #region Business Methods

		
        public string DepTypeCode
        {
            get ;
            set ;
        }

		
        public string DepTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_DepType Create()
        {
            return EF.DataPortal.Create<Sys_DepType>();
        }

		public static Sys_DepType Fetch(System.Linq.Expressions.Expression<Func<Sys_DepType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_DepType>(exp,values);
            return EF.DataPortal.Fetch<Sys_DepType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_DepTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_DepTypes:ReadOnlyListBase<Sys_DepTypes,Sys_DepType>
    {
        #region Factory Methods

        public static Sys_DepTypes Fetch()
        {
            return EF.DataPortal.Fetch<Sys_DepTypes>();
        }

		public static Sys_DepTypes Fetch(System.Linq.Expressions.Expression<Func<Sys_DepType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_DepType>(exp,values);
            return EF.DataPortal.Fetch<Sys_DepTypes>(lambda);
		}

		public static Sys_DepTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_DepTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_DepTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_DepType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_DepTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_DepType>(exp,values)});
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
