using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjInBill))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjInBill:ReadOnlyBase<PM_ProjInBill>
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

		
        public string ProjInNo
        {
            get ;
            set ;
        }

		
        public string ProjInTypeCode
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool IsAppr
        {
            get ;
            set ;
        }

		
        public bool IsCheck
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

		
        public decimal TuiAmt
        {
            get ;
            set ;
        }

		
        public string ObjectId
        {
            get ;
            set ;
        }

		
        public string WorkflowId
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

		
        public string CheckedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ProjInBill Create()
        {
            return EF.DataPortal.Create<PM_ProjInBill>();
        }

		public static PM_ProjInBill Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInBill>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjInBills))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjInBills:ReadOnlyListBase<PM_ProjInBills,PM_ProjInBill>
    {
        #region Factory Methods

        public static PM_ProjInBills Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjInBills>();
        }

		public static PM_ProjInBills Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInBill>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInBills>(lambda);
		}

		public static PM_ProjInBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjInBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjInBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjInBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjInBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjInBill>(exp,values)});
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
