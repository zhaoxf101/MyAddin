using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_BankCardBill))]
#if Dev
    [RunLocal]
#endif

	public class HR_BankCardBill:ReadOnlyBase<HR_BankCardBill>
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

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string BankCardNo
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public string BankCardTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsOffCard
        {
            get ;
            set ;
        }

		
        public bool IsExpBus
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_BankCardBill Create()
        {
            return EF.DataPortal.Create<HR_BankCardBill>();
        }

		public static HR_BankCardBill Fetch(System.Linq.Expressions.Expression<Func<HR_BankCardBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_BankCardBill>(exp,values);
            return EF.DataPortal.Fetch<HR_BankCardBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_BankCardBills))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_BankCardBills:ReadOnlyListBase<HR_BankCardBills,HR_BankCardBill>
    {
        #region Factory Methods

        public static HR_BankCardBills Fetch()
        {
            return EF.DataPortal.Fetch<HR_BankCardBills>();
        }

		public static HR_BankCardBills Fetch(System.Linq.Expressions.Expression<Func<HR_BankCardBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_BankCardBill>(exp,values);
            return EF.DataPortal.Fetch<HR_BankCardBills>(lambda);
		}

		public static HR_BankCardBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_BankCardBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_BankCardBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_BankCardBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_BankCardBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_BankCardBill>(exp,values)});
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
