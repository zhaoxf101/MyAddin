using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurContAppBus))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurContAppBus:ReadOnlyBase<PM_PurContAppBus>
    {
        #region Business Methods

		
        public string PurContAppBusCode
        {
            get ;
            set ;
        }

		
        public string PurContAppBusName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_PurContAppBus Create()
        {
            return EF.DataPortal.Create<PM_PurContAppBus>();
        }

		public static PM_PurContAppBus Fetch(System.Linq.Expressions.Expression<Func<PM_PurContAppBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContAppBus>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContAppBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurContAppBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurContAppBuss:ReadOnlyListBase<PM_PurContAppBuss,PM_PurContAppBus>
    {
        #region Factory Methods

        public static PM_PurContAppBuss Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurContAppBuss>();
        }

		public static PM_PurContAppBuss Fetch(System.Linq.Expressions.Expression<Func<PM_PurContAppBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContAppBus>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContAppBuss>(lambda);
		}

		public static PM_PurContAppBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurContAppBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurContAppBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurContAppBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurContAppBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurContAppBus>(exp,values)});
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
