using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AccYearSet))]
#if Dev
    [RunLocal]
#endif

	public class FI_AccYearSet:ReadOnlyBase<FI_AccYearSet>
    {
        #region Business Methods

		
        public string AccYearSet
        {
            get ;
            set ;
        }

		
        public bool IsGCalendar
        {
            get ;
            set ;
        }

		
        public int PidQty
        {
            get ;
            set ;
        }

		
        public int SpecPidQty
        {
            get ;
            set ;
        }

		
        public string DText
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

		public static FI_AccYearSet Create()
        {
            return EF.DataPortal.Create<FI_AccYearSet>();
        }

		public static FI_AccYearSet Fetch(System.Linq.Expressions.Expression<Func<FI_AccYearSet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AccYearSet>(exp,values);
            return EF.DataPortal.Fetch<FI_AccYearSet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AccYearSets))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AccYearSets:ReadOnlyListBase<FI_AccYearSets,FI_AccYearSet>
    {
        #region Factory Methods

        public static FI_AccYearSets Fetch()
        {
            return EF.DataPortal.Fetch<FI_AccYearSets>();
        }

		public static FI_AccYearSets Fetch(System.Linq.Expressions.Expression<Func<FI_AccYearSet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AccYearSet>(exp,values);
            return EF.DataPortal.Fetch<FI_AccYearSets>(lambda);
		}

		public static FI_AccYearSets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AccYearSets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AccYearSets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AccYearSet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AccYearSets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AccYearSet>(exp,values)});
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
