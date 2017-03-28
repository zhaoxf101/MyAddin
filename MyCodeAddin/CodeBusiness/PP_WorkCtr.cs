using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PP_WorkCtr))]
#if Dev
    [RunLocal]
#endif

	public class PP_WorkCtr:ReadOnlyBase<PP_WorkCtr>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Plant
        {
            get ;
            set ;
        }

		
        public string WorkCtr
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public string WorkCtrTYP
        {
            get ;
            set ;
        }

		
        public bool? IsDel
        {
            get ;
            set ;
        }

		
        public string Addr
        {
            get ;
            set ;
        }

		
        public string Leader
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public int? LOANZ
        {
            get ;
            set ;
        }

		
        public string SimCode
        {
            get ;
            set ;
        }

		
        public string AccCode
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

		public static PP_WorkCtr Create()
        {
            return EF.DataPortal.Create<PP_WorkCtr>();
        }

		public static PP_WorkCtr Fetch(System.Linq.Expressions.Expression<Func<PP_WorkCtr, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PP_WorkCtr>(exp,values);
            return EF.DataPortal.Fetch<PP_WorkCtr>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PP_WorkCtrs))]
#if Dev
    [RunLocal]
#endif
	
	public class PP_WorkCtrs:ReadOnlyListBase<PP_WorkCtrs,PP_WorkCtr>
    {
        #region Factory Methods

        public static PP_WorkCtrs Fetch()
        {
            return EF.DataPortal.Fetch<PP_WorkCtrs>();
        }

		public static PP_WorkCtrs Fetch(System.Linq.Expressions.Expression<Func<PP_WorkCtr, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PP_WorkCtr>(exp,values);
            return EF.DataPortal.Fetch<PP_WorkCtrs>(lambda);
		}

		public static PP_WorkCtrs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PP_WorkCtrs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PP_WorkCtrs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PP_WorkCtr, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PP_WorkCtrs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PP_WorkCtr>(exp,values)});
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
