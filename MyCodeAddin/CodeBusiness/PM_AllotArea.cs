using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotArea))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotArea:ReadOnlyBase<PM_AllotArea>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotAreaCode
        {
            get ;
            set ;
        }

		
        public string AllotAreaName
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static PM_AllotArea Create()
        {
            return EF.DataPortal.Create<PM_AllotArea>();
        }

		public static PM_AllotArea Fetch(System.Linq.Expressions.Expression<Func<PM_AllotArea, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotArea>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotArea>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotAreas))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotAreas:ReadOnlyListBase<PM_AllotAreas,PM_AllotArea>
    {
        #region Factory Methods

        public static PM_AllotAreas Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotAreas>();
        }

		public static PM_AllotAreas Fetch(System.Linq.Expressions.Expression<Func<PM_AllotArea, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotArea>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAreas>(lambda);
		}

		public static PM_AllotAreas Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotAreas>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotAreas Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotArea, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotAreas>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotArea>(exp,values)});
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
