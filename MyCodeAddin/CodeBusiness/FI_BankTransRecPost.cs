using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankTransRecPost))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankTransRecPost:ReadOnlyBase<FI_BankTransRecPost>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TransactionNo
        {
            get ;
            set ;
        }

		
        public string BankId
        {
            get ;
            set ;
        }

		
        public string TransactionDate
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string BankHolder
        {
            get ;
            set ;
        }

		
        public string BankAccount
        {
            get ;
            set ;
        }

		
        public string BankInstitutions
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public bool DeCrX
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public decimal Balance
        {
            get ;
            set ;
        }

		
        public string RBankHolder
        {
            get ;
            set ;
        }

		
        public string RBankAccount
        {
            get ;
            set ;
        }

		
        public string RBankInstitutions
        {
            get ;
            set ;
        }

		
        public string Remark
        {
            get ;
            set ;
        }

		
        public bool IsConfrim
        {
            get ;
            set ;
        }

		
        public string TransactionTime
        {
            get ;
            set ;
        }

		
        public string ImportBankCode
        {
            get ;
            set ;
        }

		
        public string TransBillNo
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string RelaNo
        {
            get ;
            set ;
        }

		
        public int RowId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BankTransRecPost Create()
        {
            return EF.DataPortal.Create<FI_BankTransRecPost>();
        }

		public static FI_BankTransRecPost Fetch(System.Linq.Expressions.Expression<Func<FI_BankTransRecPost, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankTransRecPost>(exp,values);
            return EF.DataPortal.Fetch<FI_BankTransRecPost>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankTransRecPosts))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankTransRecPosts:ReadOnlyListBase<FI_BankTransRecPosts,FI_BankTransRecPost>
    {
        #region Factory Methods

        public static FI_BankTransRecPosts Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankTransRecPosts>();
        }

		public static FI_BankTransRecPosts Fetch(System.Linq.Expressions.Expression<Func<FI_BankTransRecPost, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankTransRecPost>(exp,values);
            return EF.DataPortal.Fetch<FI_BankTransRecPosts>(lambda);
		}

		public static FI_BankTransRecPosts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankTransRecPosts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankTransRecPosts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankTransRecPost, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankTransRecPosts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankTransRecPost>(exp,values)});
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
