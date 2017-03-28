using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankCard))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankCard:ReadOnlyBase<FI_BankCard>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public int Position
        {
            get ;
            set ;
        }

		
        public string CardUserCode
        {
            get ;
            set ;
        }

		
        public string CardUserType
        {
            get ;
            set ;
        }

		
        public string UnitedBankId1
        {
            get ;
            set ;
        }

		
        public bool IsToPub
        {
            get ;
            set ;
        }

		
        public string BankCardNo
        {
            get ;
            set ;
        }

		
        public string BankCardTypeCode
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
        public bool IsExpBus
        {
            get ;
            set ;
        }

		
        public bool IsSubsidy
        {
            get ;
            set ;
        }

		
        public bool IsOriginal
        {
            get ;
            set ;
        }

		
        public string OriginalBankCardNo
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

		
        public string UnitedBankId
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

		
		#endregion

		#region Factory Methods

		public static FI_BankCard Create()
        {
            return EF.DataPortal.Create<FI_BankCard>();
        }

		public static FI_BankCard Fetch(System.Linq.Expressions.Expression<Func<FI_BankCard, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankCard>(exp,values);
            return EF.DataPortal.Fetch<FI_BankCard>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankCards))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankCards:ReadOnlyListBase<FI_BankCards,FI_BankCard>
    {
        #region Factory Methods

        public static FI_BankCards Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankCards>();
        }

		public static FI_BankCards Fetch(System.Linq.Expressions.Expression<Func<FI_BankCard, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankCard>(exp,values);
            return EF.DataPortal.Fetch<FI_BankCards>(lambda);
		}

		public static FI_BankCards Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankCards>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankCards Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankCard, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankCards>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankCard>(exp,values)});
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
