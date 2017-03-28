using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_ProcRouteSeq))]
#if Dev
    [RunLocal]
#endif

	public class PP_ProcRouteSeq:ReadOnlyBase<PP_ProcRouteSeq>
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

		
        public string PLNFL
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

		
        public string FLGAT
        {
            get ;
            set ;
        }

		
        public int? BKNT1
        {
            get ;
            set ;
        }

		
        public int? BKNT2
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PP_ProcRouteSeq Create()
        {
            return EF.DataPortal.Create<PP_ProcRouteSeq>();
        }

		public static PP_ProcRouteSeq Fetch(System.Linq.Expressions.Expression<Func<PP_ProcRouteSeq, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_ProcRouteSeq>(exp,values);
            return EF.DataPortal.Fetch<PP_ProcRouteSeq>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_ProcRouteSeqs))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_ProcRouteSeqs:ReadOnlyListBase<PP_ProcRouteSeqs,PP_ProcRouteSeq>
    {
        #region Factory Methods

        public static PP_ProcRouteSeqs Fetch()
        {
            return EF.DataPortal.Fetch<PP_ProcRouteSeqs>();
        }

		public static PP_ProcRouteSeqs Fetch(System.Linq.Expressions.Expression<Func<PP_ProcRouteSeq, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_ProcRouteSeq>(exp,values);
            return EF.DataPortal.Fetch<PP_ProcRouteSeqs>(lambda);
		}

		public static PP_ProcRouteSeqs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_ProcRouteSeqs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_ProcRouteSeqs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_ProcRouteSeq, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_ProcRouteSeqs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_ProcRouteSeq>(exp,values)});
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
