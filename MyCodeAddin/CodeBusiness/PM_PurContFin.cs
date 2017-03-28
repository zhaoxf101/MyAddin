using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PurContFin))]
#if Dev
    [RunLocal]
#endif

	public class PM_PurContFin:ReadOnlyBase<PM_PurContFin>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ContractId
        {
            get ;
            set ;
        }

		
        public decimal FinalAmt
        {
            get ;
            set ;
        }

		
        public bool IsAppr
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

		
        public string CheckUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_PurContFin Create()
        {
            return EF.DataPortal.Create<PM_PurContFin>();
        }

		public static PM_PurContFin Fetch(System.Linq.Expressions.Expression<Func<PM_PurContFin, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContFin>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContFin>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PurContFins))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PurContFins:ReadOnlyListBase<PM_PurContFins,PM_PurContFin>
    {
        #region Factory Methods

        public static PM_PurContFins Fetch()
        {
            return EF.DataPortal.Fetch<PM_PurContFins>();
        }

		public static PM_PurContFins Fetch(System.Linq.Expressions.Expression<Func<PM_PurContFin, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PurContFin>(exp,values);
            return EF.DataPortal.Fetch<PM_PurContFins>(lambda);
		}

		public static PM_PurContFins Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PurContFins>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PurContFins Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PurContFin, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PurContFins>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PurContFin>(exp,values)});
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
