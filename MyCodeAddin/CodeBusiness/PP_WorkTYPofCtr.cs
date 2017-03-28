using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_WorkTYPofCtr))]
#if Dev
    [RunLocal]
#endif

	public class PP_WorkTYPofCtr:ReadOnlyBase<PP_WorkTYPofCtr>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string WorkCtr
        {
            get ;
            set ;
        }

		
        public string ACTXK
        {
            get ;
            set ;
        }

		
        public string ACTXY
        {
            get ;
            set ;
        }

		
        public string WorkType
        {
            get ;
            set ;
        }

		
        public string UnitCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PP_WorkTYPofCtr Create()
        {
            return EF.DataPortal.Create<PP_WorkTYPofCtr>();
        }

		public static PP_WorkTYPofCtr Fetch(System.Linq.Expressions.Expression<Func<PP_WorkTYPofCtr, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_WorkTYPofCtr>(exp,values);
            return EF.DataPortal.Fetch<PP_WorkTYPofCtr>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_WorkTYPofCtrs))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_WorkTYPofCtrs:ReadOnlyListBase<PP_WorkTYPofCtrs,PP_WorkTYPofCtr>
    {
        #region Factory Methods

        public static PP_WorkTYPofCtrs Fetch()
        {
            return EF.DataPortal.Fetch<PP_WorkTYPofCtrs>();
        }

		public static PP_WorkTYPofCtrs Fetch(System.Linq.Expressions.Expression<Func<PP_WorkTYPofCtr, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_WorkTYPofCtr>(exp,values);
            return EF.DataPortal.Fetch<PP_WorkTYPofCtrs>(lambda);
		}

		public static PP_WorkTYPofCtrs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_WorkTYPofCtrs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_WorkTYPofCtrs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_WorkTYPofCtr, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_WorkTYPofCtrs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_WorkTYPofCtr>(exp,values)});
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
