using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PayAccount))]
#if Dev
    [RunLocal]
#endif

	public class FI_PayAccount:ReadOnlyBase<FI_PayAccount>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string RAccount
        {
            get ;
            set ;
        }

		
        public string RAccName
        {
            get ;
            set ;
        }

		
        public string RBankName
        {
            get ;
            set ;
        }

		
        public string RBankId
        {
            get ;
            set ;
        }

		
        public string RUnitedBankId
        {
            get ;
            set ;
        }

		
        public bool IsPublic
        {
            get ;
            set ;
        }

		
        public bool IsOffCard
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public string UseText
        {
            get ;
            set ;
        }

		
        public string ReqText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PayAccount Create()
        {
            return EF.DataPortal.Create<FI_PayAccount>();
        }

		public static FI_PayAccount Fetch(System.Linq.Expressions.Expression<Func<FI_PayAccount, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PayAccount>(exp,values);
            return EF.DataPortal.Fetch<FI_PayAccount>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PayAccounts))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PayAccounts:ReadOnlyListBase<FI_PayAccounts,FI_PayAccount>
    {
        #region Factory Methods

        public static FI_PayAccounts Fetch()
        {
            return EF.DataPortal.Fetch<FI_PayAccounts>();
        }

		public static FI_PayAccounts Fetch(System.Linq.Expressions.Expression<Func<FI_PayAccount, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PayAccount>(exp,values);
            return EF.DataPortal.Fetch<FI_PayAccounts>(lambda);
		}

		public static FI_PayAccounts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PayAccounts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PayAccounts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PayAccount, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PayAccounts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PayAccount>(exp,values)});
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
