using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpSubsidyPayment))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpSubsidyPayment:ReadOnlyBase<FI_ExpSubsidyPayment>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
        {
            get ;
            set ;
        }

		
        public string Staff
        {
            get ;
            set ;
        }

		
        public string UType
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpSubsidyPayment Create()
        {
            return EF.DataPortal.Create<FI_ExpSubsidyPayment>();
        }

		public static FI_ExpSubsidyPayment Fetch(System.Linq.Expressions.Expression<Func<FI_ExpSubsidyPayment, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpSubsidyPayment>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpSubsidyPayment>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpSubsidyPayments))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpSubsidyPayments:ReadOnlyListBase<FI_ExpSubsidyPayments,FI_ExpSubsidyPayment>
    {
        #region Factory Methods

        public static FI_ExpSubsidyPayments Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpSubsidyPayments>();
        }

		public static FI_ExpSubsidyPayments Fetch(System.Linq.Expressions.Expression<Func<FI_ExpSubsidyPayment, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpSubsidyPayment>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpSubsidyPayments>(lambda);
		}

		public static FI_ExpSubsidyPayments Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpSubsidyPayments>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpSubsidyPayments Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpSubsidyPayment, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpSubsidyPayments>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpSubsidyPayment>(exp,values)});
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
