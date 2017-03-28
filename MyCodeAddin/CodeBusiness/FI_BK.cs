using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BK))]
#if Dev
    [RunLocal]
#endif

	public class FI_BK:ReadOnlyBase<FI_BK>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BKCode
        {
            get ;
            set ;
        }

		
        public string BKName
        {
            get ;
            set ;
        }

		
        public string BKSim
        {
            get ;
            set ;
        }

		
        public bool IsBankTran
        {
            get ;
            set ;
        }

		
        public bool CanChk
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsPassCode
        {
            get ;
            set ;
        }

		
        public string Customer
        {
            get ;
            set ;
        }

		
        public string BankUserId
        {
            get ;
            set ;
        }

		
        public string CIS
        {
            get ;
            set ;
        }

		
        public string BankParentId
        {
            get ;
            set ;
        }

		
        public string BankType
        {
            get ;
            set ;
        }

		
        public string Version
        {
            get ;
            set ;
        }

		
        public string GroupCIS
        {
            get ;
            set ;
        }

		
        public string IP
        {
            get ;
            set ;
        }

		
        public int Port
        {
            get ;
            set ;
        }

		
        public string URL
        {
            get ;
            set ;
        }

		
        public string URL1
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

		
        public string BillCode
        {
            get ;
            set ;
        }

		
        public string BillProName
        {
            get ;
            set ;
        }

		
        public string UseCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BK Create()
        {
            return EF.DataPortal.Create<FI_BK>();
        }

		public static FI_BK Fetch(System.Linq.Expressions.Expression<Func<FI_BK, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BK>(exp,values);
            return EF.DataPortal.Fetch<FI_BK>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BKs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BKs:ReadOnlyListBase<FI_BKs,FI_BK>
    {
        #region Factory Methods

        public static FI_BKs Fetch()
        {
            return EF.DataPortal.Fetch<FI_BKs>();
        }

		public static FI_BKs Fetch(System.Linq.Expressions.Expression<Func<FI_BK, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BK>(exp,values);
            return EF.DataPortal.Fetch<FI_BKs>(lambda);
		}

		public static FI_BKs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BKs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BKs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BK, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BKs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BK>(exp,values)});
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
