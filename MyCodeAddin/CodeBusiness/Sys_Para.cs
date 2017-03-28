using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Para))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Para:ReadOnlyBase<Sys_Para>
    {
        #region Business Methods

		
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

		public static Sys_Para Create()
        {
            return EF.DataPortal.Create<Sys_Para>();
        }

		public static Sys_Para Fetch(System.Linq.Expressions.Expression<Func<Sys_Para, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Para>(exp,values);
            return EF.DataPortal.Fetch<Sys_Para>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Paras))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Paras:ReadOnlyListBase<Sys_Paras,Sys_Para>
    {
        #region Factory Methods

        public static Sys_Paras Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Paras>();
        }

		public static Sys_Paras Fetch(System.Linq.Expressions.Expression<Func<Sys_Para, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Para>(exp,values);
            return EF.DataPortal.Fetch<Sys_Paras>(lambda);
		}

		public static Sys_Paras Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Paras>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Paras Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Para, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Paras>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Para>(exp,values)});
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
