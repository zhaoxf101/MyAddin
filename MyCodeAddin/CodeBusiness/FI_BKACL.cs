using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_BKACL))]
#if Dev
    [RunLocal]
#endif

	public class FI_BKACL:ReadOnlyBase<FI_BKACL>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BKACTypeCode
        {
            get ;
            set ;
        }

		
        public string BKACTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_BKACL Create()
        {
            return EF.DataPortal.Create<FI_BKACL>();
        }

		public static FI_BKACL Fetch(System.Linq.Expressions.Expression<Func<FI_BKACL, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_BKACL>(exp,values);
            return EF.DataPortal.Fetch<FI_BKACL>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_BKACLs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_BKACLs:ReadOnlyListBase<FI_BKACLs,FI_BKACL>
    {
        #region Factory Methods

        public static FI_BKACLs Fetch()
        {
            return EF.DataPortal.Fetch<FI_BKACLs>();
        }

		public static FI_BKACLs Fetch(System.Linq.Expressions.Expression<Func<FI_BKACL, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_BKACL>(exp,values);
            return EF.DataPortal.Fetch<FI_BKACLs>(lambda);
		}

		public static FI_BKACLs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_BKACLs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_BKACLs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_BKACL, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_BKACLs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_BKACL>(exp,values)});
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
