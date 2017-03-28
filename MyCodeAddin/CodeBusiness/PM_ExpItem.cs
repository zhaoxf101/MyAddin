using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ExpItem))]
#if Dev
    [RunLocal]
#endif

	public class PM_ExpItem:ReadOnlyBase<PM_ExpItem>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjCode
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

		
        public bool IsFixAss
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsBudCtrl
        {
            get ;
            set ;
        }

		
        public bool IsSpecial
        {
            get ;
            set ;
        }

		
        public decimal MinBud
        {
            get ;
            set ;
        }

		
        public decimal MaxBud
        {
            get ;
            set ;
        }

		
        public bool IsAdd
        {
            get ;
            set ;
        }

		
        public bool IsCWCHK
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

		public static PM_ExpItem Create()
        {
            return EF.DataPortal.Create<PM_ExpItem>();
        }

		public static PM_ExpItem Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItem, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItem>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItem>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ExpItems))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ExpItems:ReadOnlyListBase<PM_ExpItems,PM_ExpItem>
    {
        #region Factory Methods

        public static PM_ExpItems Fetch()
        {
            return EF.DataPortal.Fetch<PM_ExpItems>();
        }

		public static PM_ExpItems Fetch(System.Linq.Expressions.Expression<Func<PM_ExpItem, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ExpItem>(exp,values);
            return EF.DataPortal.Fetch<PM_ExpItems>(lambda);
		}

		public static PM_ExpItems Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ExpItems>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ExpItems Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ExpItem, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ExpItems>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ExpItem>(exp,values)});
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
