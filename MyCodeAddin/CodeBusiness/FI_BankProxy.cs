using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankProxy))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankProxy:ReadOnlyBase<FI_BankProxy>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProxyBankCode
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public string ProxyBankName
        {
            get ;
            set ;
        }

		
        public string ProxyBankUser
        {
            get ;
            set ;
        }

		
        public string BankId
        {
            get ;
            set ;
        }

		
        public string Account
        {
            get ;
            set ;
        }

		
        public string AccText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BankProxy Create()
        {
            return EF.DataPortal.Create<FI_BankProxy>();
        }

		public static FI_BankProxy Fetch(System.Linq.Expressions.Expression<Func<FI_BankProxy, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankProxy>(exp,values);
            return EF.DataPortal.Fetch<FI_BankProxy>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankProxys))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankProxys:ReadOnlyListBase<FI_BankProxys,FI_BankProxy>
    {
        #region Factory Methods

        public static FI_BankProxys Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankProxys>();
        }

		public static FI_BankProxys Fetch(System.Linq.Expressions.Expression<Func<FI_BankProxy, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankProxy>(exp,values);
            return EF.DataPortal.Fetch<FI_BankProxys>(lambda);
		}

		public static FI_BankProxys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankProxys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankProxys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankProxy, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankProxys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankProxy>(exp,values)});
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
