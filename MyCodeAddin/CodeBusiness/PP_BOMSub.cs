using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_BOMSub))]
#if Dev
    [RunLocal]
#endif

	public class PP_BOMSub:ReadOnlyBase<PP_BOMSub>
    {
        #region Business Methods

		
        public string STLNR
        {
            get ;
            set ;
        }

		
        public string STLAL
        {
            get ;
            set ;
        }

		
        public int STLKN
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

		
        public string IDNRK
        {
            get ;
            set ;
        }

		
        public string POSNR
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
        public decimal? MENGE
        {
            get ;
            set ;
        }

		
        public decimal? FMENG
        {
            get ;
            set ;
        }

		
        public decimal? AUSCH
        {
            get ;
            set ;
        }

		
        public decimal? AVOAU
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PP_BOMSub Create()
        {
            return EF.DataPortal.Create<PP_BOMSub>();
        }

		public static PP_BOMSub Fetch(System.Linq.Expressions.Expression<Func<PP_BOMSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_BOMSub>(exp,values);
            return EF.DataPortal.Fetch<PP_BOMSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_BOMSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_BOMSubs:ReadOnlyListBase<PP_BOMSubs,PP_BOMSub>
    {
        #region Factory Methods

        public static PP_BOMSubs Fetch()
        {
            return EF.DataPortal.Fetch<PP_BOMSubs>();
        }

		public static PP_BOMSubs Fetch(System.Linq.Expressions.Expression<Func<PP_BOMSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_BOMSub>(exp,values);
            return EF.DataPortal.Fetch<PP_BOMSubs>(lambda);
		}

		public static PP_BOMSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_BOMSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_BOMSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_BOMSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_BOMSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_BOMSub>(exp,values)});
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
