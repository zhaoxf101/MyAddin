using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudFDExpItem))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudFDExpItem:ReadOnlyBase<PM_BudFDExpItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public string PBudExpItemCode
        {
            get ;
            set ;
        }

		
        public bool IsResBud
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool? IsAdd
        {
            get ;
            set ;
        }

		
        public bool CanChg
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal ResFDSum
        {
            get ;
            set ;
        }

		
        public decimal BudAmt
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

		
        public decimal? PFDAmt
        {
            get ;
            set ;
        }

		
        public decimal? TFDAmt
        {
            get ;
            set ;
        }

		
        public decimal? EFDAmt
        {
            get ;
            set ;
        }

		
        public string PName
        {
            get ;
            set ;
        }

		
        public string TName
        {
            get ;
            set ;
        }

		
        public string ExpItemName
        {
            get ;
            set ;
        }

		
        public string Ecode
        {
            get ;
            set ;
        }

		
        public string EName
        {
            get ;
            set ;
        }

		
        public decimal? PBudAmt
        {
            get ;
            set ;
        }

		
        public decimal? TBudAmt
        {
            get ;
            set ;
        }

		
        public decimal? EBudAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_BudFDExpItem Create()
        {
            return EF.DataPortal.Create<PM_BudFDExpItem>();
        }

		public static PM_BudFDExpItem Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDExpItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDExpItem>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDExpItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudFDExpItems))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudFDExpItems:ReadOnlyListBase<PM_BudFDExpItems,PM_BudFDExpItem>
    {
        #region Factory Methods

        public static PM_BudFDExpItems Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudFDExpItems>();
        }

		public static PM_BudFDExpItems Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDExpItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDExpItem>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDExpItems>(lambda);
		}

		public static PM_BudFDExpItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudFDExpItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudFDExpItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudFDExpItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudFDExpItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudFDExpItem>(exp,values)});
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
