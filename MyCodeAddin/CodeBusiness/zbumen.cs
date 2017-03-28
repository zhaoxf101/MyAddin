using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zbumen))]
#if Dev
    [RunLocal]
#endif

	public class zbumen:ReadOnlyBase<zbumen>
    {
        #region Business Methods

		
        public float? Client
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string DepName
        {
            get ;
            set ;
        }

		
        public string DepLeader
        {
            get ;
            set ;
        }

		
        public string DepTypeCode
        {
            get ;
            set ;
        }

		
        public string DepLevel
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zbumen Create()
        {
            return EF.DataPortal.Create<zbumen>();
        }

		public static zbumen Fetch(System.Linq.Expressions.Expression<Func<zbumen, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zbumen>(exp,values);
            return EF.DataPortal.Fetch<zbumen>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zbumens))]
#if Dev
    [RunLocal]
#endif
	
	public class zbumens:ReadOnlyListBase<zbumens,zbumen>
    {
        #region Factory Methods

        public static zbumens Fetch()
        {
            return EF.DataPortal.Fetch<zbumens>();
        }

		public static zbumens Fetch(System.Linq.Expressions.Expression<Func<zbumen, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zbumen>(exp,values);
            return EF.DataPortal.Fetch<zbumens>(lambda);
		}

		public static zbumens Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zbumens>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zbumens Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zbumen, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zbumens>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zbumen>(exp,values)});
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
