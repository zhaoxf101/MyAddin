using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_PoliStates))]
#if Dev
    [RunLocal]
#endif

	public class Sys_PoliStates:ReadOnlyBase<Sys_PoliStates>
    {
        #region Business Methods

		
        public string PoliStatesCode
        {
            get ;
            set ;
        }

		
        public string PoliStatesName
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_PoliStates Create()
        {
            return EF.DataPortal.Create<Sys_PoliStates>();
        }

		public static Sys_PoliStates Fetch(System.Linq.Expressions.Expression<Func<Sys_PoliStates, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_PoliStates>(exp,values);
            return EF.DataPortal.Fetch<Sys_PoliStates>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_PoliStatess))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_PoliStatess:ReadOnlyListBase<Sys_PoliStatess,Sys_PoliStates>
    {
        #region Factory Methods

        public static Sys_PoliStatess Fetch()
        {
            return EF.DataPortal.Fetch<Sys_PoliStatess>();
        }

		public static Sys_PoliStatess Fetch(System.Linq.Expressions.Expression<Func<Sys_PoliStates, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_PoliStates>(exp,values);
            return EF.DataPortal.Fetch<Sys_PoliStatess>(lambda);
		}

		public static Sys_PoliStatess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_PoliStatess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_PoliStatess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_PoliStates, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_PoliStatess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_PoliStates>(exp,values)});
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
