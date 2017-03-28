using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(MM_MatGrp))]
#if Dev
    [RunLocal]
#endif

	public class MM_MatGrp:ReadOnlyBase<MM_MatGrp>
    {
        #region Business Methods

		
        public string MatGrp
        {
            get ;
            set ;
        }

		
        public string LText
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

		public static MM_MatGrp Create()
        {
            return EF.DataPortal.Create<MM_MatGrp>();
        }

		public static MM_MatGrp Fetch(System.Linq.Expressions.Expression<Func<MM_MatGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<MM_MatGrp>(exp,values);
            return EF.DataPortal.Fetch<MM_MatGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(MM_MatGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class MM_MatGrps:ReadOnlyListBase<MM_MatGrps,MM_MatGrp>
    {
        #region Factory Methods

        public static MM_MatGrps Fetch()
        {
            return EF.DataPortal.Fetch<MM_MatGrps>();
        }

		public static MM_MatGrps Fetch(System.Linq.Expressions.Expression<Func<MM_MatGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<MM_MatGrp>(exp,values);
            return EF.DataPortal.Fetch<MM_MatGrps>(lambda);
		}

		public static MM_MatGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<MM_MatGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static MM_MatGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<MM_MatGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<MM_MatGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<MM_MatGrp>(exp,values)});
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
