using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_UnitedBank))]
#if Dev
    [RunLocal]
#endif

	public class FI_UnitedBank:ReadOnlyBase<FI_UnitedBank>
    {
        #region Business Methods

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string BankId
        {
            get ;
            set ;
        }

		
        public string BankPName
        {
            get ;
            set ;
        }

		
        public string AreaCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_UnitedBank Create()
        {
            return EF.DataPortal.Create<FI_UnitedBank>();
        }

		public static FI_UnitedBank Fetch(System.Linq.Expressions.Expression<Func<FI_UnitedBank, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_UnitedBank>(exp,values);
            return EF.DataPortal.Fetch<FI_UnitedBank>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_UnitedBanks))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_UnitedBanks:ReadOnlyListBase<FI_UnitedBanks,FI_UnitedBank>
    {
        #region Factory Methods

        public static FI_UnitedBanks Fetch()
        {
            return EF.DataPortal.Fetch<FI_UnitedBanks>();
        }

		public static FI_UnitedBanks Fetch(System.Linq.Expressions.Expression<Func<FI_UnitedBank, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_UnitedBank>(exp,values);
            return EF.DataPortal.Fetch<FI_UnitedBanks>(lambda);
		}

		public static FI_UnitedBanks Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_UnitedBanks>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_UnitedBanks Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_UnitedBank, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_UnitedBanks>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_UnitedBank>(exp,values)});
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
