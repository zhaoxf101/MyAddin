using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_GrpLeafClient))]
#if Dev
    [RunLocal]
#endif

	public class Sys_GrpLeafClient:ReadOnlyBase<Sys_GrpLeafClient>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string GrpClass
        {
            get ;
            set ;
        }

		
        public string GrpName
        {
            get ;
            set ;
        }

		
        public int LineId
        {
            get ;
            set ;
        }

		
        public string LeafValue
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

		public static Sys_GrpLeafClient Create()
        {
            return EF.DataPortal.Create<Sys_GrpLeafClient>();
        }

		public static Sys_GrpLeafClient Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpLeafClient, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpLeafClient>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpLeafClient>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_GrpLeafClients))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_GrpLeafClients:ReadOnlyListBase<Sys_GrpLeafClients,Sys_GrpLeafClient>
    {
        #region Factory Methods

        public static Sys_GrpLeafClients Fetch()
        {
            return EF.DataPortal.Fetch<Sys_GrpLeafClients>();
        }

		public static Sys_GrpLeafClients Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpLeafClient, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpLeafClient>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpLeafClients>(lambda);
		}

		public static Sys_GrpLeafClients Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_GrpLeafClients>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_GrpLeafClients Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_GrpLeafClient, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_GrpLeafClients>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_GrpLeafClient>(exp,values)});
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
