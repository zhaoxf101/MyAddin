using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionLog))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionLog:ReadOnlyBase<SM_TuitionLog>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string DealNo
        {
            get ;
            set ;
        }

		
        public string PayWayCode
        {
            get ;
            set ;
        }

		
        public DateTime PayDateTime
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_TuitionLog Create()
        {
            return EF.DataPortal.Create<SM_TuitionLog>();
        }

		public static SM_TuitionLog Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionLog, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionLog>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionLog>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionLogs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionLogs:ReadOnlyListBase<SM_TuitionLogs,SM_TuitionLog>
    {
        #region Factory Methods

        public static SM_TuitionLogs Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionLogs>();
        }

		public static SM_TuitionLogs Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionLog, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionLog>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionLogs>(lambda);
		}

		public static SM_TuitionLogs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionLogs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionLogs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionLog, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionLogs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionLog>(exp,values)});
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
