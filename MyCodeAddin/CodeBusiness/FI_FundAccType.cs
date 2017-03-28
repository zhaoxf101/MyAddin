using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundAccType))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundAccType:ReadOnlyBase<FI_FundAccType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FundAccTypeCode
        {
            get ;
            set ;
        }

		
        public string FundAccTypeName
        {
            get ;
            set ;
        }

		
        public bool IsCtrlAcc
        {
            get ;
            set ;
        }

		
        public bool IsEscrow
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_FundAccType Create()
        {
            return EF.DataPortal.Create<FI_FundAccType>();
        }

		public static FI_FundAccType Fetch(System.Linq.Expressions.Expression<Func<FI_FundAccType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundAccType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundAccType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundAccTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundAccTypes:ReadOnlyListBase<FI_FundAccTypes,FI_FundAccType>
    {
        #region Factory Methods

        public static FI_FundAccTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundAccTypes>();
        }

		public static FI_FundAccTypes Fetch(System.Linq.Expressions.Expression<Func<FI_FundAccType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundAccType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundAccTypes>(lambda);
		}

		public static FI_FundAccTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundAccTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundAccTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundAccType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundAccTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundAccType>(exp,values)});
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
