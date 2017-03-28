using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_BusTypeAcc))]
#if Dev
    [RunLocal]
#endif

	public class Sys_BusTypeAcc:ReadOnlyBase<Sys_BusTypeAcc>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string AccCls
        {
            get ;
            set ;
        }

		
        public string EntryKey
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string PostKey
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string BAccCode
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_BusTypeAcc Create()
        {
            return EF.DataPortal.Create<Sys_BusTypeAcc>();
        }

		public static Sys_BusTypeAcc Fetch(System.Linq.Expressions.Expression<Func<Sys_BusTypeAcc, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_BusTypeAcc>(exp,values);
            return EF.DataPortal.Fetch<Sys_BusTypeAcc>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_BusTypeAccs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_BusTypeAccs:ReadOnlyListBase<Sys_BusTypeAccs,Sys_BusTypeAcc>
    {
        #region Factory Methods

        public static Sys_BusTypeAccs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_BusTypeAccs>();
        }

		public static Sys_BusTypeAccs Fetch(System.Linq.Expressions.Expression<Func<Sys_BusTypeAcc, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_BusTypeAcc>(exp,values);
            return EF.DataPortal.Fetch<Sys_BusTypeAccs>(lambda);
		}

		public static Sys_BusTypeAccs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_BusTypeAccs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_BusTypeAccs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_BusTypeAcc, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_BusTypeAccs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_BusTypeAcc>(exp,values)});
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
