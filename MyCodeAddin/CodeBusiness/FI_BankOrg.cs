using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankOrg))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankOrg:ReadOnlyBase<FI_BankOrg>
    {
        #region Business Methods

		
        public string BankOrgCode
        {
            get ;
            set ;
        }

		
        public string BankOrgName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BankOrg Create()
        {
            return EF.DataPortal.Create<FI_BankOrg>();
        }

		public static FI_BankOrg Fetch(System.Linq.Expressions.Expression<Func<FI_BankOrg, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankOrg>(exp,values);
            return EF.DataPortal.Fetch<FI_BankOrg>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankOrgs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankOrgs:ReadOnlyListBase<FI_BankOrgs,FI_BankOrg>
    {
        #region Factory Methods

        public static FI_BankOrgs Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankOrgs>();
        }

		public static FI_BankOrgs Fetch(System.Linq.Expressions.Expression<Func<FI_BankOrg, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankOrg>(exp,values);
            return EF.DataPortal.Fetch<FI_BankOrgs>(lambda);
		}

		public static FI_BankOrgs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankOrgs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankOrgs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankOrg, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankOrgs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankOrg>(exp,values)});
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
