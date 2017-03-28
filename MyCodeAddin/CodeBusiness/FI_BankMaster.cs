using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BankMaster))]
#if Dev
    [RunLocal]
#endif

	public class FI_BankMaster:ReadOnlyBase<FI_BankMaster>
    {
        #region Business Methods

		
        public string BankId
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

		
        public int Sort
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BankMaster Create()
        {
            return EF.DataPortal.Create<FI_BankMaster>();
        }

		public static FI_BankMaster Fetch(System.Linq.Expressions.Expression<Func<FI_BankMaster, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BankMaster>(exp,values);
            return EF.DataPortal.Fetch<FI_BankMaster>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BankMasters))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BankMasters:ReadOnlyListBase<FI_BankMasters,FI_BankMaster>
    {
        #region Factory Methods

        public static FI_BankMasters Fetch()
        {
            return EF.DataPortal.Fetch<FI_BankMasters>();
        }

		public static FI_BankMasters Fetch(System.Linq.Expressions.Expression<Func<FI_BankMaster, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BankMaster>(exp,values);
            return EF.DataPortal.Fetch<FI_BankMasters>(lambda);
		}

		public static FI_BankMasters Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BankMasters>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BankMasters Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BankMaster, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BankMasters>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BankMaster>(exp,values)});
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
