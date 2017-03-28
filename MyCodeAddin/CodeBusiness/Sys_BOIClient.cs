using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_BOIClient))]
#if Dev
    [RunLocal]
#endif

	public class Sys_BOIClient:ReadOnlyBase<Sys_BOIClient>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
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

		public static Sys_BOIClient Create()
        {
            return EF.DataPortal.Create<Sys_BOIClient>();
        }

		public static Sys_BOIClient Fetch(System.Linq.Expressions.Expression<Func<Sys_BOIClient, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_BOIClient>(exp,values);
            return EF.DataPortal.Fetch<Sys_BOIClient>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_BOIClients))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_BOIClients:ReadOnlyListBase<Sys_BOIClients,Sys_BOIClient>
    {
        #region Factory Methods

        public static Sys_BOIClients Fetch()
        {
            return EF.DataPortal.Fetch<Sys_BOIClients>();
        }

		public static Sys_BOIClients Fetch(System.Linq.Expressions.Expression<Func<Sys_BOIClient, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_BOIClient>(exp,values);
            return EF.DataPortal.Fetch<Sys_BOIClients>(lambda);
		}

		public static Sys_BOIClients Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_BOIClients>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_BOIClients Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_BOIClient, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_BOIClients>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_BOIClient>(exp,values)});
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
