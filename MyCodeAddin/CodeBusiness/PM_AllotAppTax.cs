using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotAppTax))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotAppTax:ReadOnlyBase<PM_AllotAppTax>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotAppNo
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

		
        public string ItemText
        {
            get ;
            set ;
        }

		
        public string InvNo
        {
            get ;
            set ;
        }

		
        public decimal LAmt
        {
            get ;
            set ;
        }

		
        public decimal CAmt
        {
            get ;
            set ;
        }

		
        public decimal OAmt
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public decimal UAmt
        {
            get ;
            set ;
        }

		
        public string TaxCode
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal AppAmt
        {
            get ;
            set ;
        }

		
        public string Memo
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

		
		#endregion

		#region Factory Methods

		public static PM_AllotAppTax Create()
        {
            return EF.DataPortal.Create<PM_AllotAppTax>();
        }

		public static PM_AllotAppTax Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppTax, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppTax>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppTax>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotAppTaxs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotAppTaxs:ReadOnlyListBase<PM_AllotAppTaxs,PM_AllotAppTax>
    {
        #region Factory Methods

        public static PM_AllotAppTaxs Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotAppTaxs>();
        }

		public static PM_AllotAppTaxs Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppTax, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppTax>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppTaxs>(lambda);
		}

		public static PM_AllotAppTaxs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotAppTaxs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotAppTaxs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotAppTax, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotAppTaxs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotAppTax>(exp,values)});
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
