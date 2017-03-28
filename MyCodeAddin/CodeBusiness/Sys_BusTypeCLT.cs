using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_BusTypeCLT))]
#if Dev
    [RunLocal]
#endif

	public class Sys_BusTypeCLT:ReadOnlyBase<Sys_BusTypeCLT>
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

		
        public string VouType
        {
            get ;
            set ;
        }

		
        public string CVType
        {
            get ;
            set ;
        }

		
        public string PVType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_BusTypeCLT Create()
        {
            return EF.DataPortal.Create<Sys_BusTypeCLT>();
        }

		public static Sys_BusTypeCLT Fetch(System.Linq.Expressions.Expression<Func<Sys_BusTypeCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_BusTypeCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_BusTypeCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_BusTypeCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_BusTypeCLTs:ReadOnlyListBase<Sys_BusTypeCLTs,Sys_BusTypeCLT>
    {
        #region Factory Methods

        public static Sys_BusTypeCLTs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_BusTypeCLTs>();
        }

		public static Sys_BusTypeCLTs Fetch(System.Linq.Expressions.Expression<Func<Sys_BusTypeCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_BusTypeCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_BusTypeCLTs>(lambda);
		}

		public static Sys_BusTypeCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_BusTypeCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_BusTypeCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_BusTypeCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_BusTypeCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_BusTypeCLT>(exp,values)});
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
