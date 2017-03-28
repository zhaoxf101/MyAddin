using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PBudSource))]
#if Dev
    [RunLocal]
#endif

	public class FI_PBudSource:ReadOnlyBase<FI_PBudSource>
    {
        #region Business Methods

		
        public string BudSourceCode
        {
            get ;
            set ;
        }

		
        public string BudSourceName
        {
            get ;
            set ;
        }

		
        public string BudSourceGrpCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PBudSource Create()
        {
            return EF.DataPortal.Create<FI_PBudSource>();
        }

		public static FI_PBudSource Fetch(System.Linq.Expressions.Expression<Func<FI_PBudSource, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudSource>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudSource>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PBudSources))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PBudSources:ReadOnlyListBase<FI_PBudSources,FI_PBudSource>
    {
        #region Factory Methods

        public static FI_PBudSources Fetch()
        {
            return EF.DataPortal.Fetch<FI_PBudSources>();
        }

		public static FI_PBudSources Fetch(System.Linq.Expressions.Expression<Func<FI_PBudSource, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PBudSource>(exp,values);
            return EF.DataPortal.Fetch<FI_PBudSources>(lambda);
		}

		public static FI_PBudSources Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PBudSources>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PBudSources Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PBudSource, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PBudSources>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PBudSource>(exp,values)});
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
