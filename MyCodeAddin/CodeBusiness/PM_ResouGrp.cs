using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ResouGrp))]
#if Dev
    [RunLocal]
#endif

	public class PM_ResouGrp:ReadOnlyBase<PM_ResouGrp>
    {
        #region Business Methods

		
        public string ResouGrpCode
        {
            get ;
            set ;
        }

		
        public string ResouGrpName
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

		public static PM_ResouGrp Create()
        {
            return EF.DataPortal.Create<PM_ResouGrp>();
        }

		public static PM_ResouGrp Fetch(System.Linq.Expressions.Expression<Func<PM_ResouGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ResouGrp>(exp,values);
            return EF.DataPortal.Fetch<PM_ResouGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ResouGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ResouGrps:ReadOnlyListBase<PM_ResouGrps,PM_ResouGrp>
    {
        #region Factory Methods

        public static PM_ResouGrps Fetch()
        {
            return EF.DataPortal.Fetch<PM_ResouGrps>();
        }

		public static PM_ResouGrps Fetch(System.Linq.Expressions.Expression<Func<PM_ResouGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ResouGrp>(exp,values);
            return EF.DataPortal.Fetch<PM_ResouGrps>(lambda);
		}

		public static PM_ResouGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ResouGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ResouGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ResouGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ResouGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ResouGrp>(exp,values)});
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
