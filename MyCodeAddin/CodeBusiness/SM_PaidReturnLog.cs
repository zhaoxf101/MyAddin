using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_PaidReturnLog))]
#if Dev
    [RunLocal]
#endif

	public class SM_PaidReturnLog:ReadOnlyBase<SM_PaidReturnLog>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public long id
        {
            get ;
            set ;
        }

		
        public string vStudentNo
        {
            get ;
            set ;
        }

		
        public string vLot
        {
            get ;
            set ;
        }

		
        public string vPayWayCode
        {
            get ;
            set ;
        }

		
        public decimal? nReturn
        {
            get ;
            set ;
        }

		
        public DateTime? dDateInput
        {
            get ;
            set ;
        }

		
        public bool? bReturn
        {
            get ;
            set ;
        }

		
        public string iDealNo
        {
            get ;
            set ;
        }

		
        public string vReturnLot
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_PaidReturnLog Create()
        {
            return EF.DataPortal.Create<SM_PaidReturnLog>();
        }

		public static SM_PaidReturnLog Fetch(System.Linq.Expressions.Expression<Func<SM_PaidReturnLog, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_PaidReturnLog>(exp,values);
            return EF.DataPortal.Fetch<SM_PaidReturnLog>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_PaidReturnLogs))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_PaidReturnLogs:ReadOnlyListBase<SM_PaidReturnLogs,SM_PaidReturnLog>
    {
        #region Factory Methods

        public static SM_PaidReturnLogs Fetch()
        {
            return EF.DataPortal.Fetch<SM_PaidReturnLogs>();
        }

		public static SM_PaidReturnLogs Fetch(System.Linq.Expressions.Expression<Func<SM_PaidReturnLog, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_PaidReturnLog>(exp,values);
            return EF.DataPortal.Fetch<SM_PaidReturnLogs>(lambda);
		}

		public static SM_PaidReturnLogs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_PaidReturnLogs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_PaidReturnLogs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_PaidReturnLog, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_PaidReturnLogs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_PaidReturnLog>(exp,values)});
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
