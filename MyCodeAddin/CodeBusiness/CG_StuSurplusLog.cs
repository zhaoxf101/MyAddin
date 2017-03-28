using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_StuSurplusLog))]
#if Dev
    [RunLocal]
#endif

	public class CG_StuSurplusLog:ReadOnlyBase<CG_StuSurplusLog>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string PayWayCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public Guid TranOrderId
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public bool IsHandle
        {
            get ;
            set ;
        }

		
        public string HandleUser
        {
            get ;
            set ;
        }

		
        public DateTime? HandleDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_StuSurplusLog Create()
        {
            return EF.DataPortal.Create<CG_StuSurplusLog>();
        }

		public static CG_StuSurplusLog Fetch(System.Linq.Expressions.Expression<Func<CG_StuSurplusLog, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_StuSurplusLog>(exp,values);
            return EF.DataPortal.Fetch<CG_StuSurplusLog>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_StuSurplusLogs))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_StuSurplusLogs:ReadOnlyListBase<CG_StuSurplusLogs,CG_StuSurplusLog>
    {
        #region Factory Methods

        public static CG_StuSurplusLogs Fetch()
        {
            return EF.DataPortal.Fetch<CG_StuSurplusLogs>();
        }

		public static CG_StuSurplusLogs Fetch(System.Linq.Expressions.Expression<Func<CG_StuSurplusLog, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_StuSurplusLog>(exp,values);
            return EF.DataPortal.Fetch<CG_StuSurplusLogs>(lambda);
		}

		public static CG_StuSurplusLogs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_StuSurplusLogs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_StuSurplusLogs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_StuSurplusLog, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_StuSurplusLogs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_StuSurplusLog>(exp,values)});
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
