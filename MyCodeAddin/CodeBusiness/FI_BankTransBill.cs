using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankTransBill))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankTransBill:ReadOnlyBase<FI_BankTransBill>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TransBillNo
        {
            get ;
            set ;
        }

		
        public string BankCode
        {
            get ;
            set ;
        }

		
        public string IncConfTypeCode
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public string AccDateTime
        {
            get ;
            set ;
        }

		
        public bool GenVouX
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string VouchText
        {
            get ;
            set ;
        }

		
        public bool Approve
        {
            get ;
            set ;
        }

		
        public string CheckUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckDate
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

		public static FI_BankTransBill Create()
        {
            return EF.DataPortal.Create<FI_BankTransBill>();
        }

		public static FI_BankTransBill Fetch(System.Linq.Expressions.Expression<Func<FI_BankTransBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankTransBill>(exp,values);
            return EF.DataPortal.Fetch<FI_BankTransBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankTransBills))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankTransBills:ReadOnlyListBase<FI_BankTransBills,FI_BankTransBill>
    {
        #region Factory Methods

        public static FI_BankTransBills Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankTransBills>();
        }

		public static FI_BankTransBills Fetch(System.Linq.Expressions.Expression<Func<FI_BankTransBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankTransBill>(exp,values);
            return EF.DataPortal.Fetch<FI_BankTransBills>(lambda);
		}

		public static FI_BankTransBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankTransBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankTransBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankTransBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankTransBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankTransBill>(exp,values)});
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
