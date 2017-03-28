using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_ParaCLT))]
#if Dev
    [RunLocal]
#endif

	public class Sys_ParaCLT:ReadOnlyBase<Sys_ParaCLT>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ParaName
        {
            get ;
            set ;
        }

		
        public string ParaValue
        {
            get ;
            set ;
        }

		
        public string ParaExplain
        {
            get ;
            set ;
        }

		
        public string SubSystem
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_ParaCLT Create()
        {
            return EF.DataPortal.Create<Sys_ParaCLT>();
        }

		public static Sys_ParaCLT Fetch(System.Linq.Expressions.Expression<Func<Sys_ParaCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_ParaCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_ParaCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_ParaCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_ParaCLTs:ReadOnlyListBase<Sys_ParaCLTs,Sys_ParaCLT>
    {
        #region Factory Methods

        public static Sys_ParaCLTs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_ParaCLTs>();
        }

		public static Sys_ParaCLTs Fetch(System.Linq.Expressions.Expression<Func<Sys_ParaCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_ParaCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_ParaCLTs>(lambda);
		}

		public static Sys_ParaCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_ParaCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_ParaCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_ParaCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_ParaCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_ParaCLT>(exp,values)});
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
