using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PProject))]
#if Dev
    [RunLocal]
#endif

	public class FI_PProject:ReadOnlyBase<FI_PProject>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string PProjCode
        {
            get ;
            set ;
        }

		
        public string PProjName
        {
            get ;
            set ;
        }

		
        public string FundCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PProject Create()
        {
            return EF.DataPortal.Create<FI_PProject>();
        }

		public static FI_PProject Fetch(System.Linq.Expressions.Expression<Func<FI_PProject, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PProject>(exp,values);
            return EF.DataPortal.Fetch<FI_PProject>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PProjects))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PProjects:ReadOnlyListBase<FI_PProjects,FI_PProject>
    {
        #region Factory Methods

        public static FI_PProjects Fetch()
        {
            return EF.DataPortal.Fetch<FI_PProjects>();
        }

		public static FI_PProjects Fetch(System.Linq.Expressions.Expression<Func<FI_PProject, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PProject>(exp,values);
            return EF.DataPortal.Fetch<FI_PProjects>(lambda);
		}

		public static FI_PProjects Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PProjects>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PProjects Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PProject, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PProjects>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PProject>(exp,values)});
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
