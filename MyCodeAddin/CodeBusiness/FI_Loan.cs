using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_Loan))]
#if Dev
    [RunLocal]
#endif

	public class FI_Loan:ReadOnlyBase<FI_Loan>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string LoanCode
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string LoanPurpose
        {
            get ;
            set ;
        }

		
        public decimal LoanAmt
        {
            get ;
            set ;
        }

		
        public decimal LoanActAmt
        {
            get ;
            set ;
        }

		
        public decimal ExpBusAmt
        {
            get ;
            set ;
        }

		
        public decimal WoffAmt
        {
            get ;
            set ;
        }

		
        public string Location
        {
            get ;
            set ;
        }

		
        public int? PeopleCount
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string BarCode
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

		
        public bool Dismiss
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool IsDetails
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public string LoanUser
        {
            get ;
            set ;
        }

		
        public string CostCtr
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

		
        public string AccDate
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

		
        public bool IsConfBill
        {
            get ;
            set ;
        }

		
        public string UseText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_Loan Create()
        {
            return EF.DataPortal.Create<FI_Loan>();
        }

		public static FI_Loan Fetch(System.Linq.Expressions.Expression<Func<FI_Loan, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_Loan>(exp,values);
            return EF.DataPortal.Fetch<FI_Loan>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_Loans))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_Loans:ReadOnlyListBase<FI_Loans,FI_Loan>
    {
        #region Factory Methods

        public static FI_Loans Fetch()
        {
            return EF.DataPortal.Fetch<FI_Loans>();
        }

		public static FI_Loans Fetch(System.Linq.Expressions.Expression<Func<FI_Loan, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_Loan>(exp,values);
            return EF.DataPortal.Fetch<FI_Loans>(lambda);
		}

		public static FI_Loans Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_Loans>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_Loans Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_Loan, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_Loans>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_Loan>(exp,values)});
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
