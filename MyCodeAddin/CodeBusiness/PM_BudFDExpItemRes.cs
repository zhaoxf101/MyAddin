using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudFDExpItemRes))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudFDExpItemRes:ReadOnlyBase<PM_BudFDExpItemRes>
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

		
        public string ResouItemCode
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

		
        public decimal BudAmt
        {
            get ;
            set ;
        }

		
        public decimal FDQty
        {
            get ;
            set ;
        }

		
        public decimal BudQty
        {
            get ;
            set ;
        }

		
        public bool IsPbuy
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

		public static PM_BudFDExpItemRes Create()
        {
            return EF.DataPortal.Create<PM_BudFDExpItemRes>();
        }

		public static PM_BudFDExpItemRes Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDExpItemRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDExpItemRes>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDExpItemRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudFDExpItemRess))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudFDExpItemRess:ReadOnlyListBase<PM_BudFDExpItemRess,PM_BudFDExpItemRes>
    {
        #region Factory Methods

        public static PM_BudFDExpItemRess Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudFDExpItemRess>();
        }

		public static PM_BudFDExpItemRess Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDExpItemRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDExpItemRes>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDExpItemRess>(lambda);
		}

		public static PM_BudFDExpItemRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudFDExpItemRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudFDExpItemRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudFDExpItemRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudFDExpItemRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudFDExpItemRes>(exp,values)});
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
