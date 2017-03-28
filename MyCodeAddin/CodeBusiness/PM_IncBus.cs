using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_IncBus))]
#if Dev
    [RunLocal]
#endif

	public class PM_IncBus:ReadOnlyBase<PM_IncBus>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string IncBusCode
        {
            get ;
            set ;
        }

		
        public string IncItemCode
        {
            get ;
            set ;
        }

		
        public string BillTypeCode
        {
            get ;
            set ;
        }

		
        public decimal IncAmt
        {
            get ;
            set ;
        }

		
        public decimal ActAmt
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public bool IsAuto
        {
            get ;
            set ;
        }

		
        public string WorkFlowID
        {
            get ;
            set ;
        }

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TimeStamp
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

		public static PM_IncBus Create()
        {
            return EF.DataPortal.Create<PM_IncBus>();
        }

		public static PM_IncBus Fetch(System.Linq.Expressions.Expression<Func<PM_IncBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_IncBus>(exp,values);
            return EF.DataPortal.Fetch<PM_IncBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_IncBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_IncBuss:ReadOnlyListBase<PM_IncBuss,PM_IncBus>
    {
        #region Factory Methods

        public static PM_IncBuss Fetch()
        {
            return EF.DataPortal.Fetch<PM_IncBuss>();
        }

		public static PM_IncBuss Fetch(System.Linq.Expressions.Expression<Func<PM_IncBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_IncBus>(exp,values);
            return EF.DataPortal.Fetch<PM_IncBuss>(lambda);
		}

		public static PM_IncBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_IncBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_IncBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_IncBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_IncBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_IncBus>(exp,values)});
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
