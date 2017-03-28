using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankCardType))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankCardType:ReadOnlyBase<FI_BankCardType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BankCardTypeCode
        {
            get ;
            set ;
        }

		
        public string BankCardTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BankCardType Create()
        {
            return EF.DataPortal.Create<FI_BankCardType>();
        }

		public static FI_BankCardType Fetch(System.Linq.Expressions.Expression<Func<FI_BankCardType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankCardType>(exp,values);
            return EF.DataPortal.Fetch<FI_BankCardType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankCardTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankCardTypes:ReadOnlyListBase<FI_BankCardTypes,FI_BankCardType>
    {
        #region Factory Methods

        public static FI_BankCardTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankCardTypes>();
        }

		public static FI_BankCardTypes Fetch(System.Linq.Expressions.Expression<Func<FI_BankCardType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankCardType>(exp,values);
            return EF.DataPortal.Fetch<FI_BankCardTypes>(lambda);
		}

		public static FI_BankCardTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankCardTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankCardTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankCardType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankCardTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankCardType>(exp,values)});
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
