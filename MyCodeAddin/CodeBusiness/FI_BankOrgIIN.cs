using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankOrgIIN))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankOrgIIN:ReadOnlyBase<FI_BankOrgIIN>
    {
        #region Business Methods

		
        public string BankOrgCode
        {
            get ;
            set ;
        }

		
        public string BankIINCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BankOrgIIN Create()
        {
            return EF.DataPortal.Create<FI_BankOrgIIN>();
        }

		public static FI_BankOrgIIN Fetch(System.Linq.Expressions.Expression<Func<FI_BankOrgIIN, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankOrgIIN>(exp,values);
            return EF.DataPortal.Fetch<FI_BankOrgIIN>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankOrgIINs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankOrgIINs:ReadOnlyListBase<FI_BankOrgIINs,FI_BankOrgIIN>
    {
        #region Factory Methods

        public static FI_BankOrgIINs Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankOrgIINs>();
        }

		public static FI_BankOrgIINs Fetch(System.Linq.Expressions.Expression<Func<FI_BankOrgIIN, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankOrgIIN>(exp,values);
            return EF.DataPortal.Fetch<FI_BankOrgIINs>(lambda);
		}

		public static FI_BankOrgIINs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankOrgIINs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankOrgIINs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankOrgIIN, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankOrgIINs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankOrgIIN>(exp,values)});
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
