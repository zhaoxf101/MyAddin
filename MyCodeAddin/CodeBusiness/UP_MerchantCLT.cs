using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_MerchantCLT))]
#if Dev
    [RunLocal]
#endif

	public class UP_MerchantCLT:ReadOnlyBase<UP_MerchantCLT>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid MerchantId
        {
            get ;
            set ;
        }

		
        public string BankAccount
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
        public string BookName
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public Guid AccountId
        {
            get ;
            set ;
        }

		
        public bool IsPublic
        {
            get ;
            set ;
        }

		
        public string UserCode
        {
            get ;
            set ;
        }

		
        public string RowStatus
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

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static UP_MerchantCLT Create()
        {
            return EF.DataPortal.Create<UP_MerchantCLT>();
        }

		public static UP_MerchantCLT Fetch(System.Linq.Expressions.Expression<Func<UP_MerchantCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_MerchantCLT>(exp,values);
            return EF.DataPortal.Fetch<UP_MerchantCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_MerchantCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_MerchantCLTs:ReadOnlyListBase<UP_MerchantCLTs,UP_MerchantCLT>
    {
        #region Factory Methods

        public static UP_MerchantCLTs Fetch()
        {
            return EF.DataPortal.Fetch<UP_MerchantCLTs>();
        }

		public static UP_MerchantCLTs Fetch(System.Linq.Expressions.Expression<Func<UP_MerchantCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_MerchantCLT>(exp,values);
            return EF.DataPortal.Fetch<UP_MerchantCLTs>(lambda);
		}

		public static UP_MerchantCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_MerchantCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_MerchantCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_MerchantCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_MerchantCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_MerchantCLT>(exp,values)});
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
