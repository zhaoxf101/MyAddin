using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Nation))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Nation:ReadOnlyBase<Sys_Nation>
    {
        #region Business Methods

		
        public string NationCode
        {
            get ;
            set ;
        }

		
        public string NationName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_Nation Create()
        {
            return EF.DataPortal.Create<Sys_Nation>();
        }

		public static Sys_Nation Fetch(System.Linq.Expressions.Expression<Func<Sys_Nation, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Nation>(exp,values);
            return EF.DataPortal.Fetch<Sys_Nation>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Nations))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Nations:ReadOnlyListBase<Sys_Nations,Sys_Nation>
    {
        #region Factory Methods

        public static Sys_Nations Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Nations>();
        }

		public static Sys_Nations Fetch(System.Linq.Expressions.Expression<Func<Sys_Nation, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Nation>(exp,values);
            return EF.DataPortal.Fetch<Sys_Nations>(lambda);
		}

		public static Sys_Nations Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Nations>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Nations Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Nation, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Nations>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Nation>(exp,values)});
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
