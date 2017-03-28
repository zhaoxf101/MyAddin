using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_AppBus))]
#if Dev
    [RunLocal]
#endif

	public class SM_AppBus:ReadOnlyBase<SM_AppBus>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppBusCode
        {
            get ;
            set ;
        }

		
        public string AppBusName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_AppBus Create()
        {
            return EF.DataPortal.Create<SM_AppBus>();
        }

		public static SM_AppBus Fetch(System.Linq.Expressions.Expression<Func<SM_AppBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_AppBus>(exp,values);
            return EF.DataPortal.Fetch<SM_AppBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_AppBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_AppBuss:ReadOnlyListBase<SM_AppBuss,SM_AppBus>
    {
        #region Factory Methods

        public static SM_AppBuss Fetch()
        {
            return EF.DataPortal.Fetch<SM_AppBuss>();
        }

		public static SM_AppBuss Fetch(System.Linq.Expressions.Expression<Func<SM_AppBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_AppBus>(exp,values);
            return EF.DataPortal.Fetch<SM_AppBuss>(lambda);
		}

		public static SM_AppBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_AppBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_AppBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_AppBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_AppBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_AppBus>(exp,values)});
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
