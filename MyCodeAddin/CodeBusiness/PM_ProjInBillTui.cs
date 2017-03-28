using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjInBillTui))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjInBillTui:ReadOnlyBase<PM_ProjInBillTui>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ProjInNo
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

		public static PM_ProjInBillTui Create()
        {
            return EF.DataPortal.Create<PM_ProjInBillTui>();
        }

		public static PM_ProjInBillTui Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInBillTui, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInBillTui>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInBillTui>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjInBillTuis))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjInBillTuis:ReadOnlyListBase<PM_ProjInBillTuis,PM_ProjInBillTui>
    {
        #region Factory Methods

        public static PM_ProjInBillTuis Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjInBillTuis>();
        }

		public static PM_ProjInBillTuis Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInBillTui, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInBillTui>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInBillTuis>(lambda);
		}

		public static PM_ProjInBillTuis Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjInBillTuis>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjInBillTuis Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjInBillTui, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjInBillTuis>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjInBillTui>(exp,values)});
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
