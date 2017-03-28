using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundBudArea))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundBudArea:ReadOnlyBase<FI_FundBudArea>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FundBudAreaCode
        {
            get ;
            set ;
        }

		
        public string FundBudAreaName
        {
            get ;
            set ;
        }

		
        public bool IsGroup
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static FI_FundBudArea Create()
        {
            return EF.DataPortal.Create<FI_FundBudArea>();
        }

		public static FI_FundBudArea Fetch(System.Linq.Expressions.Expression<Func<FI_FundBudArea, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundBudArea>(exp,values);
            return EF.DataPortal.Fetch<FI_FundBudArea>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundBudAreas))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundBudAreas:ReadOnlyListBase<FI_FundBudAreas,FI_FundBudArea>
    {
        #region Factory Methods

        public static FI_FundBudAreas Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundBudAreas>();
        }

		public static FI_FundBudAreas Fetch(System.Linq.Expressions.Expression<Func<FI_FundBudArea, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundBudArea>(exp,values);
            return EF.DataPortal.Fetch<FI_FundBudAreas>(lambda);
		}

		public static FI_FundBudAreas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundBudAreas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundBudAreas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundBudArea, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundBudAreas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundBudArea>(exp,values)});
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
