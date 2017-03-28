using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_WoffProj))]
#if Dev
    [RunLocal]
#endif

	public class PM_WoffProj:ReadOnlyBase<PM_WoffProj>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WoffCode
        {
            get ;
            set ;
        }

		
        public string LoanCode
        {
            get ;
            set ;
        }

		
        public string WoffName
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

		
        public decimal? WoffAmt
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public System.Data.Linq.Binary TimeStamp
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

		public static PM_WoffProj Create()
        {
            return EF.DataPortal.Create<PM_WoffProj>();
        }

		public static PM_WoffProj Fetch(System.Linq.Expressions.Expression<Func<PM_WoffProj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_WoffProj>(exp,values);
            return EF.DataPortal.Fetch<PM_WoffProj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_WoffProjs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_WoffProjs:ReadOnlyListBase<PM_WoffProjs,PM_WoffProj>
    {
        #region Factory Methods

        public static PM_WoffProjs Fetch()
        {
            return EF.DataPortal.Fetch<PM_WoffProjs>();
        }

		public static PM_WoffProjs Fetch(System.Linq.Expressions.Expression<Func<PM_WoffProj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_WoffProj>(exp,values);
            return EF.DataPortal.Fetch<PM_WoffProjs>(lambda);
		}

		public static PM_WoffProjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_WoffProjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_WoffProjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_WoffProj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_WoffProjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_WoffProj>(exp,values)});
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
