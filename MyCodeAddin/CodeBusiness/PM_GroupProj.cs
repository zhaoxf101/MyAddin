using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_GroupProj))]
#if Dev
    [RunLocal]
#endif

	public class PM_GroupProj:ReadOnlyBase<PM_GroupProj>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjGrpCode
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public int? Sort
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

		public static PM_GroupProj Create()
        {
            return EF.DataPortal.Create<PM_GroupProj>();
        }

		public static PM_GroupProj Fetch(System.Linq.Expressions.Expression<Func<PM_GroupProj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_GroupProj>(exp,values);
            return EF.DataPortal.Fetch<PM_GroupProj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_GroupProjs))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_GroupProjs:ReadOnlyListBase<PM_GroupProjs,PM_GroupProj>
    {
        #region Factory Methods

        public static PM_GroupProjs Fetch()
        {
            return EF.DataPortal.Fetch<PM_GroupProjs>();
        }

		public static PM_GroupProjs Fetch(System.Linq.Expressions.Expression<Func<PM_GroupProj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_GroupProj>(exp,values);
            return EF.DataPortal.Fetch<PM_GroupProjs>(lambda);
		}

		public static PM_GroupProjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_GroupProjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_GroupProjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_GroupProj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_GroupProjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_GroupProj>(exp,values)});
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
