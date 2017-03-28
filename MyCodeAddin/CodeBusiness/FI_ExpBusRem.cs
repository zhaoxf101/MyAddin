using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpBusRem))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpBusRem:ReadOnlyBase<FI_ExpBusRem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ObjId
        {
            get ;
            set ;
        }

		
        public string ItemCode
        {
            get ;
            set ;
        }

		
        public int RowId
        {
            get ;
            set ;
        }

		
        public string RemType
        {
            get ;
            set ;
        }

		
        public string BankCode
        {
            get ;
            set ;
        }

		
        public string BankDep
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

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public bool IsGovPayPlan
        {
            get ;
            set ;
        }

		
        public string GovPlayCode
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string TransactionNo
        {
            get ;
            set ;
        }

		
        public string BankId
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpBusRem Create()
        {
            return EF.DataPortal.Create<FI_ExpBusRem>();
        }

		public static FI_ExpBusRem Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusRem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusRem>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusRem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpBusRems))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpBusRems:ReadOnlyListBase<FI_ExpBusRems,FI_ExpBusRem>
    {
        #region Factory Methods

        public static FI_ExpBusRems Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpBusRems>();
        }

		public static FI_ExpBusRems Fetch(System.Linq.Expressions.Expression<Func<FI_ExpBusRem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpBusRem>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpBusRems>(lambda);
		}

		public static FI_ExpBusRems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpBusRems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpBusRems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpBusRem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpBusRems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpBusRem>(exp,values)});
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
