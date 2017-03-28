using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AccYear))]
#if Dev
    [RunLocal]
#endif

	public class FI_AccYear:ReadOnlyBase<FI_AccYear>
    {
        #region Business Methods

		
        public string AccYearSet
        {
            get ;
            set ;
        }

		
        public string PostYear
        {
            get ;
            set ;
        }

		
        public string PostMon
        {
            get ;
            set ;
        }

		
        public string PostDay
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string YearAdj
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

		public static FI_AccYear Create()
        {
            return EF.DataPortal.Create<FI_AccYear>();
        }

		public static FI_AccYear Fetch(System.Linq.Expressions.Expression<Func<FI_AccYear, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AccYear>(exp,values);
            return EF.DataPortal.Fetch<FI_AccYear>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AccYears))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AccYears:ReadOnlyListBase<FI_AccYears,FI_AccYear>
    {
        #region Factory Methods

        public static FI_AccYears Fetch()
        {
            return EF.DataPortal.Fetch<FI_AccYears>();
        }

		public static FI_AccYears Fetch(System.Linq.Expressions.Expression<Func<FI_AccYear, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AccYear>(exp,values);
            return EF.DataPortal.Fetch<FI_AccYears>(lambda);
		}

		public static FI_AccYears Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AccYears>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AccYears Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AccYear, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AccYears>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AccYear>(exp,values)});
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
