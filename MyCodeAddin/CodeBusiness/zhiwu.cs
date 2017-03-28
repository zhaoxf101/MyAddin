using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zhiwu))]
#if Dev
    [RunLocal]
#endif

	public class zhiwu:ReadOnlyBase<zhiwu>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
        public string PositionName
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zhiwu Create()
        {
            return EF.DataPortal.Create<zhiwu>();
        }

		public static zhiwu Fetch(System.Linq.Expressions.Expression<Func<zhiwu, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zhiwu>(exp,values);
            return EF.DataPortal.Fetch<zhiwu>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zhiwus))]
#if Dev
    [RunLocal]
#endif
	
	public class zhiwus:ReadOnlyListBase<zhiwus,zhiwu>
    {
        #region Factory Methods

        public static zhiwus Fetch()
        {
            return EF.DataPortal.Fetch<zhiwus>();
        }

		public static zhiwus Fetch(System.Linq.Expressions.Expression<Func<zhiwu, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zhiwu>(exp,values);
            return EF.DataPortal.Fetch<zhiwus>(lambda);
		}

		public static zhiwus Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zhiwus>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zhiwus Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zhiwu, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zhiwus>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zhiwu>(exp,values)});
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
