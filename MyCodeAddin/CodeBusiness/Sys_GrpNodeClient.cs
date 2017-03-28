using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_GrpNodeClient))]
#if Dev
    [RunLocal]
#endif

	public class Sys_GrpNodeClient:ReadOnlyBase<Sys_GrpNodeClient>
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

		
        public string SubGrp
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

		public static Sys_GrpNodeClient Create()
        {
            return EF.DataPortal.Create<Sys_GrpNodeClient>();
        }

		public static Sys_GrpNodeClient Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpNodeClient, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpNodeClient>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpNodeClient>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_GrpNodeClients))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_GrpNodeClients:ReadOnlyListBase<Sys_GrpNodeClients,Sys_GrpNodeClient>
    {
        #region Factory Methods

        public static Sys_GrpNodeClients Fetch()
        {
            return EF.DataPortal.Fetch<Sys_GrpNodeClients>();
        }

		public static Sys_GrpNodeClients Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpNodeClient, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpNodeClient>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpNodeClients>(lambda);
		}

		public static Sys_GrpNodeClients Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_GrpNodeClients>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_GrpNodeClients Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_GrpNodeClient, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_GrpNodeClients>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_GrpNodeClient>(exp,values)});
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
