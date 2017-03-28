using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_BusType))]
#if Dev
    [RunLocal]
#endif

	public class Sys_BusType:ReadOnlyBase<Sys_BusType>
    {
        #region Business Methods

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string BusObjectName
        {
            get ;
            set ;
        }

		
        public string ConfirmProcedure
        {
            get ;
            set ;
        }

		
        public string UndoProcedure
        {
            get ;
            set ;
        }

		
        public string PostProcedure
        {
            get ;
            set ;
        }

		
        public string OffsetProcedure
        {
            get ;
            set ;
        }

		
        public string WinAppName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_BusType Create()
        {
            return EF.DataPortal.Create<Sys_BusType>();
        }

		public static Sys_BusType Fetch(System.Linq.Expressions.Expression<Func<Sys_BusType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_BusType>(exp,values);
            return EF.DataPortal.Fetch<Sys_BusType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_BusTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_BusTypes:ReadOnlyListBase<Sys_BusTypes,Sys_BusType>
    {
        #region Factory Methods

        public static Sys_BusTypes Fetch()
        {
            return EF.DataPortal.Fetch<Sys_BusTypes>();
        }

		public static Sys_BusTypes Fetch(System.Linq.Expressions.Expression<Func<Sys_BusType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_BusType>(exp,values);
            return EF.DataPortal.Fetch<Sys_BusTypes>(lambda);
		}

		public static Sys_BusTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_BusTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_BusTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_BusType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_BusTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_BusType>(exp,values)});
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
