using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_ProcRoute))]
#if Dev
    [RunLocal]
#endif

	public class PP_ProcRoute:ReadOnlyBase<PP_ProcRoute>
    {
        #region Business Methods

		
        public string PLNNR
        {
            get ;
            set ;
        }

		
        public string PLNAL
        {
            get ;
            set ;
        }

		
        public string MaterialCode
        {
            get ;
            set ;
        }

		
        public string Plant
        {
            get ;
            set ;
        }

		
        public DateTime? UseDate
        {
            get ;
            set ;
        }

		
        public bool? IsDel
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string STLNR
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

		public static PP_ProcRoute Create()
        {
            return EF.DataPortal.Create<PP_ProcRoute>();
        }

		public static PP_ProcRoute Fetch(System.Linq.Expressions.Expression<Func<PP_ProcRoute, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_ProcRoute>(exp,values);
            return EF.DataPortal.Fetch<PP_ProcRoute>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_ProcRoutes))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_ProcRoutes:ReadOnlyListBase<PP_ProcRoutes,PP_ProcRoute>
    {
        #region Factory Methods

        public static PP_ProcRoutes Fetch()
        {
            return EF.DataPortal.Fetch<PP_ProcRoutes>();
        }

		public static PP_ProcRoutes Fetch(System.Linq.Expressions.Expression<Func<PP_ProcRoute, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_ProcRoute>(exp,values);
            return EF.DataPortal.Fetch<PP_ProcRoutes>(lambda);
		}

		public static PP_ProcRoutes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_ProcRoutes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_ProcRoutes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_ProcRoute, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_ProcRoutes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_ProcRoute>(exp,values)});
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
