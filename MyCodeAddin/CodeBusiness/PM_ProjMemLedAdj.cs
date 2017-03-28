using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjMemLedAdj))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjMemLedAdj:ReadOnlyBase<PM_ProjMemLedAdj>
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

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string AdjDate
        {
            get ;
            set ;
        }

		
        public decimal CurAmt
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

		public static PM_ProjMemLedAdj Create()
        {
            return EF.DataPortal.Create<PM_ProjMemLedAdj>();
        }

		public static PM_ProjMemLedAdj Fetch(System.Linq.Expressions.Expression<Func<PM_ProjMemLedAdj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjMemLedAdj>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjMemLedAdj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjMemLedAdjs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjMemLedAdjs:ReadOnlyListBase<PM_ProjMemLedAdjs,PM_ProjMemLedAdj>
    {
        #region Factory Methods

        public static PM_ProjMemLedAdjs Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjMemLedAdjs>();
        }

		public static PM_ProjMemLedAdjs Fetch(System.Linq.Expressions.Expression<Func<PM_ProjMemLedAdj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjMemLedAdj>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjMemLedAdjs>(lambda);
		}

		public static PM_ProjMemLedAdjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjMemLedAdjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjMemLedAdjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjMemLedAdj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjMemLedAdjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjMemLedAdj>(exp,values)});
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
