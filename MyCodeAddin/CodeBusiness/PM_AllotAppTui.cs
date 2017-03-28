using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_AllotAppTui))]
#if Dev
    [RunLocal]
#endif

	public class PM_AllotAppTui:ReadOnlyBase<PM_AllotAppTui>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AllotAppNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string ClassCode
        {
            get ;
            set ;
        }

		
        public string FeeItemCode
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public decimal LAmt
        {
            get ;
            set ;
        }

		
        public decimal UAmt
        {
            get ;
            set ;
        }

		
        public decimal FDAmt
        {
            get ;
            set ;
        }

		
        public decimal AppAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_AllotAppTui Create()
        {
            return EF.DataPortal.Create<PM_AllotAppTui>();
        }

		public static PM_AllotAppTui Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppTui, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppTui>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppTui>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_AllotAppTuis))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_AllotAppTuis:ReadOnlyListBase<PM_AllotAppTuis,PM_AllotAppTui>
    {
        #region Factory Methods

        public static PM_AllotAppTuis Fetch()
        {
            return EF.DataPortal.Fetch<PM_AllotAppTuis>();
        }

		public static PM_AllotAppTuis Fetch(System.Linq.Expressions.Expression<Func<PM_AllotAppTui, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_AllotAppTui>(exp,values);
            return EF.DataPortal.Fetch<PM_AllotAppTuis>(lambda);
		}

		public static PM_AllotAppTuis Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_AllotAppTuis>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_AllotAppTuis Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_AllotAppTui, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_AllotAppTuis>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_AllotAppTui>(exp,values)});
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
