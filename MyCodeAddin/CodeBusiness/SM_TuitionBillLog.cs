using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillLog))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionBillLog:ReadOnlyBase<SM_TuitionBillLog>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TuitionBillNo
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

		public static SM_TuitionBillLog Create()
        {
            return EF.DataPortal.Create<SM_TuitionBillLog>();
        }

		public static SM_TuitionBillLog Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillLog, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillLog>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillLog>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillLogs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionBillLogs:ReadOnlyListBase<SM_TuitionBillLogs,SM_TuitionBillLog>
    {
        #region Factory Methods

        public static SM_TuitionBillLogs Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionBillLogs>();
        }

		public static SM_TuitionBillLogs Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillLog, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillLog>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillLogs>(lambda);
		}

		public static SM_TuitionBillLogs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillLogs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionBillLogs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionBillLog, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillLogs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionBillLog>(exp,values)});
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
