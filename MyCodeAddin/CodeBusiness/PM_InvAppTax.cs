using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_InvAppTax))]
#if Dev
    [RunLocal]
#endif

	public class PM_InvAppTax:ReadOnlyBase<PM_InvAppTax>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string InvAppNo
        {
            get ;
            set ;
        }

		
        public string TaxCode
        {
            get ;
            set ;
        }

		
        public decimal TaxRate
        {
            get ;
            set ;
        }

		
        public string TaxType
        {
            get ;
            set ;
        }

		
        public decimal TaxAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_InvAppTax Create()
        {
            return EF.DataPortal.Create<PM_InvAppTax>();
        }

		public static PM_InvAppTax Fetch(System.Linq.Expressions.Expression<Func<PM_InvAppTax, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_InvAppTax>(exp,values);
            return EF.DataPortal.Fetch<PM_InvAppTax>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_InvAppTaxs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_InvAppTaxs:ReadOnlyListBase<PM_InvAppTaxs,PM_InvAppTax>
    {
        #region Factory Methods

        public static PM_InvAppTaxs Fetch()
        {
            return EF.DataPortal.Fetch<PM_InvAppTaxs>();
        }

		public static PM_InvAppTaxs Fetch(System.Linq.Expressions.Expression<Func<PM_InvAppTax, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_InvAppTax>(exp,values);
            return EF.DataPortal.Fetch<PM_InvAppTaxs>(lambda);
		}

		public static PM_InvAppTaxs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_InvAppTaxs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_InvAppTaxs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_InvAppTax, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_InvAppTaxs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_InvAppTax>(exp,values)});
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
