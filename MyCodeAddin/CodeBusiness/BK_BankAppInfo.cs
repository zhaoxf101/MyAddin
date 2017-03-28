using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(BK_BankAppInfo))]
#if Dev
    [RunLocal]
#endif

	public class BK_BankAppInfo:ReadOnlyBase<BK_BankAppInfo>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string MsgId
        {
            get ;
            set ;
        }

		
        public string ItemId
        {
            get ;
            set ;
        }

		
        public string ItemType
        {
            get ;
            set ;
        }

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public string Account
        {
            get ;
            set ;
        }

		
        public string AccName
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

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string HandleUser
        {
            get ;
            set ;
        }

		
        public string State
        {
            get ;
            set ;
        }

		
        public string Message
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

		
		#endregion

		#region Factory Methods

		public static BK_BankAppInfo Create()
        {
            return EF.DataPortal.Create<BK_BankAppInfo>();
        }

		public static BK_BankAppInfo Fetch(System.Linq.Expressions.Expression<Func<BK_BankAppInfo, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<BK_BankAppInfo>(exp,values);
            return EF.DataPortal.Fetch<BK_BankAppInfo>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(BK_BankAppInfos))]
#if Dev
    [RunLocal]
#endif
	
	public class BK_BankAppInfos:ReadOnlyListBase<BK_BankAppInfos,BK_BankAppInfo>
    {
        #region Factory Methods

        public static BK_BankAppInfos Fetch()
        {
            return EF.DataPortal.Fetch<BK_BankAppInfos>();
        }

		public static BK_BankAppInfos Fetch(System.Linq.Expressions.Expression<Func<BK_BankAppInfo, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<BK_BankAppInfo>(exp,values);
            return EF.DataPortal.Fetch<BK_BankAppInfos>(lambda);
		}

		public static BK_BankAppInfos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<BK_BankAppInfos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static BK_BankAppInfos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<BK_BankAppInfo, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<BK_BankAppInfos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<BK_BankAppInfo>(exp,values)});
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
