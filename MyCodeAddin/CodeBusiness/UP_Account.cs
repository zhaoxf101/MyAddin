using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(UP_Account))]
#if Dev
    [RunLocal]
#endif

	public class UP_Account:ReadOnlyBase<UP_Account>
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

		
        public string AccountNo
        {
            get ;
            set ;
        }

		
        public string AccountName
        {
            get ;
            set ;
        }

		
        public string UserCode
        {
            get ;
            set ;
        }

		
        public decimal InAmount
        {
            get ;
            set ;
        }

		
        public decimal ExpAccount
        {
            get ;
            set ;
        }

		
        public string AccTypeCode
        {
            get ;
            set ;
        }

		
        public Guid AccountGroupId
        {
            get ;
            set ;
        }

		
        public string Status
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public bool IsUse
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

		public static UP_Account Create()
        {
            return EF.DataPortal.Create<UP_Account>();
        }

		public static UP_Account Fetch(System.Linq.Expressions.Expression<Func<UP_Account, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<UP_Account>(exp,values);
            return EF.DataPortal.Fetch<UP_Account>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(UP_Accounts))]
#if Dev
    [RunLocal]
#endif
	
	public class UP_Accounts:ReadOnlyListBase<UP_Accounts,UP_Account>
    {
        #region Factory Methods

        public static UP_Accounts Fetch()
        {
            return EF.DataPortal.Fetch<UP_Accounts>();
        }

		public static UP_Accounts Fetch(System.Linq.Expressions.Expression<Func<UP_Account, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<UP_Account>(exp,values);
            return EF.DataPortal.Fetch<UP_Accounts>(lambda);
		}

		public static UP_Accounts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<UP_Accounts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static UP_Accounts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<UP_Account, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<UP_Accounts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<UP_Account>(exp,values)});
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
