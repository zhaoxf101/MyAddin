using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_ImportModeSub))]
#if Dev
    [RunLocal]
#endif

	public class Sys_ImportModeSub:ReadOnlyBase<Sys_ImportModeSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ModeCode
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public string ItemCode
        {
            get ;
            set ;
        }

		
        public string ItemName
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string ExpItemId
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_ImportModeSub Create()
        {
            return EF.DataPortal.Create<Sys_ImportModeSub>();
        }

		public static Sys_ImportModeSub Fetch(System.Linq.Expressions.Expression<Func<Sys_ImportModeSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_ImportModeSub>(exp,values);
            return EF.DataPortal.Fetch<Sys_ImportModeSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_ImportModeSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_ImportModeSubs:ReadOnlyListBase<Sys_ImportModeSubs,Sys_ImportModeSub>
    {
        #region Factory Methods

        public static Sys_ImportModeSubs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_ImportModeSubs>();
        }

		public static Sys_ImportModeSubs Fetch(System.Linq.Expressions.Expression<Func<Sys_ImportModeSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_ImportModeSub>(exp,values);
            return EF.DataPortal.Fetch<Sys_ImportModeSubs>(lambda);
		}

		public static Sys_ImportModeSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_ImportModeSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_ImportModeSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_ImportModeSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_ImportModeSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_ImportModeSub>(exp,values)});
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
