using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjLimit))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjLimit:ReadOnlyBase<PM_ProjLimit>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public DateTime LimDate
        {
            get ;
            set ;
        }

		
        public decimal LimAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ProjLimit Create()
        {
            return EF.DataPortal.Create<PM_ProjLimit>();
        }

		public static PM_ProjLimit Fetch(System.Linq.Expressions.Expression<Func<PM_ProjLimit, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjLimit>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjLimit>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjLimits))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjLimits:ReadOnlyListBase<PM_ProjLimits,PM_ProjLimit>
    {
        #region Factory Methods

        public static PM_ProjLimits Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjLimits>();
        }

		public static PM_ProjLimits Fetch(System.Linq.Expressions.Expression<Func<PM_ProjLimit, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjLimit>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjLimits>(lambda);
		}

		public static PM_ProjLimits Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjLimits>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjLimits Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjLimit, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjLimits>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjLimit>(exp,values)});
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
