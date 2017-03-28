using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_BOI))]
#if Dev
    [RunLocal]
#endif

	public class Sys_BOI:ReadOnlyBase<Sys_BOI>
    {
        #region Business Methods

		
        public string TableName
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

		public static Sys_BOI Create()
        {
            return EF.DataPortal.Create<Sys_BOI>();
        }

		public static Sys_BOI Fetch(System.Linq.Expressions.Expression<Func<Sys_BOI, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_BOI>(exp,values);
            return EF.DataPortal.Fetch<Sys_BOI>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_BOIs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_BOIs:ReadOnlyListBase<Sys_BOIs,Sys_BOI>
    {
        #region Factory Methods

        public static Sys_BOIs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_BOIs>();
        }

		public static Sys_BOIs Fetch(System.Linq.Expressions.Expression<Func<Sys_BOI, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_BOI>(exp,values);
            return EF.DataPortal.Fetch<Sys_BOIs>(lambda);
		}

		public static Sys_BOIs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_BOIs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_BOIs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_BOI, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_BOIs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_BOI>(exp,values)});
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
