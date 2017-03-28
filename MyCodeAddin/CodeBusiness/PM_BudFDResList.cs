using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudFDResList))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudFDResList:ReadOnlyBase<PM_BudFDResList>
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

		
        public string ResRow
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

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string ResName
        {
            get ;
            set ;
        }

		
        public string SpecType
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public string Mfrs
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string TechReq
        {
            get ;
            set ;
        }

		
        public bool Freeze
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

		
        public string MaterialCode
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

		public static PM_BudFDResList Create()
        {
            return EF.DataPortal.Create<PM_BudFDResList>();
        }

		public static PM_BudFDResList Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDResList, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDResList>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDResList>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudFDResLists))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudFDResLists:ReadOnlyListBase<PM_BudFDResLists,PM_BudFDResList>
    {
        #region Factory Methods

        public static PM_BudFDResLists Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudFDResLists>();
        }

		public static PM_BudFDResLists Fetch(System.Linq.Expressions.Expression<Func<PM_BudFDResList, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudFDResList>(exp,values);
            return EF.DataPortal.Fetch<PM_BudFDResLists>(lambda);
		}

		public static PM_BudFDResLists Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudFDResLists>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudFDResLists Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudFDResList, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudFDResLists>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudFDResList>(exp,values)});
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
