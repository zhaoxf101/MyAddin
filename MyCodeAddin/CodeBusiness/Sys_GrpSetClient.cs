using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_GrpSetClient))]
#if Dev
    [RunLocal]
#endif

	public class Sys_GrpSetClient:ReadOnlyBase<Sys_GrpSetClient>
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

		
        public bool Uniqe
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static Sys_GrpSetClient Create()
        {
            return EF.DataPortal.Create<Sys_GrpSetClient>();
        }

		public static Sys_GrpSetClient Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpSetClient, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpSetClient>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpSetClient>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_GrpSetClients))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_GrpSetClients:ReadOnlyListBase<Sys_GrpSetClients,Sys_GrpSetClient>
    {
        #region Factory Methods

        public static Sys_GrpSetClients Fetch()
        {
            return EF.DataPortal.Fetch<Sys_GrpSetClients>();
        }

		public static Sys_GrpSetClients Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpSetClient, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpSetClient>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpSetClients>(lambda);
		}

		public static Sys_GrpSetClients Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_GrpSetClients>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_GrpSetClients Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_GrpSetClient, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_GrpSetClients>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_GrpSetClient>(exp,values)});
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
