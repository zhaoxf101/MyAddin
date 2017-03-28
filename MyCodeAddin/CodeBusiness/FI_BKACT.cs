using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BKACT))]
#if Dev
    [RunLocal]
#endif

	public class FI_BKACT:ReadOnlyBase<FI_BKACT>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Bank
        {
            get ;
            set ;
        }

		
        public string BAID
        {
            get ;
            set ;
        }

		
        public string BkSim
        {
            get ;
            set ;
        }

		
        public string BAccount
        {
            get ;
            set ;
        }

		
        public string BankOrg
        {
            get ;
            set ;
        }

		
        public string Curr
        {
            get ;
            set ;
        }

		
        public string BKACTypeCode
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string BAccCode
        {
            get ;
            set ;
        }

		
        public string Purpose
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsZero
        {
            get ;
            set ;
        }

		
        public int? DisplayOrder
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

		
        public string UserType
        {
            get ;
            set ;
        }

		
        public int? Sort
        {
            get ;
            set ;
        }

		
        public decimal CheckAmt
        {
            get ;
            set ;
        }

		
        public bool IsMainBank
        {
            get ;
            set ;
        }

		
        public string BKCode
        {
            get ;
            set ;
        }

		
        public string SynDate
        {
            get ;
            set ;
        }

		
        public string LastUser
        {
            get ;
            set ;
        }

		
        public DateTime? LastDate
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BKACT Create()
        {
            return EF.DataPortal.Create<FI_BKACT>();
        }

		public static FI_BKACT Fetch(System.Linq.Expressions.Expression<Func<FI_BKACT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BKACT>(exp,values);
            return EF.DataPortal.Fetch<FI_BKACT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BKACTs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BKACTs:ReadOnlyListBase<FI_BKACTs,FI_BKACT>
    {
        #region Factory Methods

        public static FI_BKACTs Fetch()
        {
            return EF.DataPortal.Fetch<FI_BKACTs>();
        }

		public static FI_BKACTs Fetch(System.Linq.Expressions.Expression<Func<FI_BKACT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BKACT>(exp,values);
            return EF.DataPortal.Fetch<FI_BKACTs>(lambda);
		}

		public static FI_BKACTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BKACTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BKACTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BKACT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BKACTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BKACT>(exp,values)});
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
