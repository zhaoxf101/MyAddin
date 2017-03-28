using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_ProcRouteProc))]
#if Dev
    [RunLocal]
#endif

	public class PP_ProcRouteProc:ReadOnlyBase<PP_ProcRouteProc>
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

		
        public int PLNKN
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

		
        public bool? PARKZ
        {
            get ;
            set ;
        }

		
        public string VORNR
        {
            get ;
            set ;
        }

		
        public string WorkCtr
        {
            get ;
            set ;
        }

		
        public string Plant
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public decimal? BMSCH
        {
            get ;
            set ;
        }

		
        public string LAR01
        {
            get ;
            set ;
        }

		
        public string VGE01
        {
            get ;
            set ;
        }

		
        public decimal? VGW01
        {
            get ;
            set ;
        }

		
        public string LAR02
        {
            get ;
            set ;
        }

		
        public string VGE02
        {
            get ;
            set ;
        }

		
        public decimal? VGW02
        {
            get ;
            set ;
        }

		
        public string LAR03
        {
            get ;
            set ;
        }

		
        public string VGE03
        {
            get ;
            set ;
        }

		
        public decimal? VGW03
        {
            get ;
            set ;
        }

		
        public string LAR04
        {
            get ;
            set ;
        }

		
        public string VGE04
        {
            get ;
            set ;
        }

		
        public decimal? VGW04
        {
            get ;
            set ;
        }

		
        public string LAR05
        {
            get ;
            set ;
        }

		
        public string VGE05
        {
            get ;
            set ;
        }

		
        public decimal? VGW05
        {
            get ;
            set ;
        }

		
        public string LAR06
        {
            get ;
            set ;
        }

		
        public string VGE06
        {
            get ;
            set ;
        }

		
        public decimal? VGW06
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PP_ProcRouteProc Create()
        {
            return EF.DataPortal.Create<PP_ProcRouteProc>();
        }

		public static PP_ProcRouteProc Fetch(System.Linq.Expressions.Expression<Func<PP_ProcRouteProc, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_ProcRouteProc>(exp,values);
            return EF.DataPortal.Fetch<PP_ProcRouteProc>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_ProcRouteProcs))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_ProcRouteProcs:ReadOnlyListBase<PP_ProcRouteProcs,PP_ProcRouteProc>
    {
        #region Factory Methods

        public static PP_ProcRouteProcs Fetch()
        {
            return EF.DataPortal.Fetch<PP_ProcRouteProcs>();
        }

		public static PP_ProcRouteProcs Fetch(System.Linq.Expressions.Expression<Func<PP_ProcRouteProc, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_ProcRouteProc>(exp,values);
            return EF.DataPortal.Fetch<PP_ProcRouteProcs>(lambda);
		}

		public static PP_ProcRouteProcs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_ProcRouteProcs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_ProcRouteProcs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_ProcRouteProc, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_ProcRouteProcs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_ProcRouteProc>(exp,values)});
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
