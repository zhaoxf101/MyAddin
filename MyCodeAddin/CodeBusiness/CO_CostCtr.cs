using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_CostCtr))]
#if Dev
    [RunLocal]
#endif

	public class CO_CostCtr:ReadOnlyBase<CO_CostCtr>
    {
        #region Business Methods

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string CostCtrType
        {
            get ;
            set ;
        }

		
        public string Leader
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
        {
            get ;
            set ;
        }

		
        public bool? IsDepCommCostCtr
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

		public static CO_CostCtr Create()
        {
            return EF.DataPortal.Create<CO_CostCtr>();
        }

		public static CO_CostCtr Fetch(System.Linq.Expressions.Expression<Func<CO_CostCtr, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_CostCtr>(exp,values);
            return EF.DataPortal.Fetch<CO_CostCtr>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_CostCtrs))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_CostCtrs:ReadOnlyListBase<CO_CostCtrs,CO_CostCtr>
    {
        #region Factory Methods

        public static CO_CostCtrs Fetch()
        {
            return EF.DataPortal.Fetch<CO_CostCtrs>();
        }

		public static CO_CostCtrs Fetch(System.Linq.Expressions.Expression<Func<CO_CostCtr, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_CostCtr>(exp,values);
            return EF.DataPortal.Fetch<CO_CostCtrs>(lambda);
		}

		public static CO_CostCtrs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_CostCtrs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_CostCtrs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_CostCtr, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_CostCtrs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_CostCtr>(exp,values)});
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
