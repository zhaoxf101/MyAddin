using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PItemStaGrp))]
#if Dev
    [RunLocal]
#endif

	public class PM_PItemStaGrp:ReadOnlyBase<PM_PItemStaGrp>
    {
        #region Business Methods

		
        public string PItemStaGrpCode
        {
            get ;
            set ;
        }

		
        public string PItemStaGrpName
        {
            get ;
            set ;
        }

		
        public bool Active
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

		public static PM_PItemStaGrp Create()
        {
            return EF.DataPortal.Create<PM_PItemStaGrp>();
        }

		public static PM_PItemStaGrp Fetch(System.Linq.Expressions.Expression<Func<PM_PItemStaGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PItemStaGrp>(exp,values);
            return EF.DataPortal.Fetch<PM_PItemStaGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PItemStaGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PItemStaGrps:ReadOnlyListBase<PM_PItemStaGrps,PM_PItemStaGrp>
    {
        #region Factory Methods

        public static PM_PItemStaGrps Fetch()
        {
            return EF.DataPortal.Fetch<PM_PItemStaGrps>();
        }

		public static PM_PItemStaGrps Fetch(System.Linq.Expressions.Expression<Func<PM_PItemStaGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PItemStaGrp>(exp,values);
            return EF.DataPortal.Fetch<PM_PItemStaGrps>(lambda);
		}

		public static PM_PItemStaGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PItemStaGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PItemStaGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PItemStaGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PItemStaGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PItemStaGrp>(exp,values)});
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
