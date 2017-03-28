using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_ConfBill))]
#if Dev
    [RunLocal]
#endif

	public class SM_ConfBill:ReadOnlyBase<SM_ConfBill>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ConfCode
        {
            get ;
            set ;
        }

		
        public string ConfText
        {
            get ;
            set ;
        }

		
        public string StartTime
        {
            get ;
            set ;
        }

		
        public string EndTime
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool Appoved
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

		
		#endregion

		#region Factory Methods

		public static SM_ConfBill Create()
        {
            return EF.DataPortal.Create<SM_ConfBill>();
        }

		public static SM_ConfBill Fetch(System.Linq.Expressions.Expression<Func<SM_ConfBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfBill>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_ConfBills))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_ConfBills:ReadOnlyListBase<SM_ConfBills,SM_ConfBill>
    {
        #region Factory Methods

        public static SM_ConfBills Fetch()
        {
            return EF.DataPortal.Fetch<SM_ConfBills>();
        }

		public static SM_ConfBills Fetch(System.Linq.Expressions.Expression<Func<SM_ConfBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfBill>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfBills>(lambda);
		}

		public static SM_ConfBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_ConfBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_ConfBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_ConfBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_ConfBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_ConfBill>(exp,values)});
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
