using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CO_ProfitCtr))]
#if Dev
    [RunLocal]
#endif

	public class CO_ProfitCtr:ReadOnlyBase<CO_ProfitCtr>
    {
        #region Business Methods

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string ProfitCtrGroup
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

		public static CO_ProfitCtr Create()
        {
            return EF.DataPortal.Create<CO_ProfitCtr>();
        }

		public static CO_ProfitCtr Fetch(System.Linq.Expressions.Expression<Func<CO_ProfitCtr, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CO_ProfitCtr>(exp,values);
            return EF.DataPortal.Fetch<CO_ProfitCtr>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CO_ProfitCtrs))]
#if Dev
    [RunLocal]
#endif
	
	public class CO_ProfitCtrs:ReadOnlyListBase<CO_ProfitCtrs,CO_ProfitCtr>
    {
        #region Factory Methods

        public static CO_ProfitCtrs Fetch()
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrs>();
        }

		public static CO_ProfitCtrs Fetch(System.Linq.Expressions.Expression<Func<CO_ProfitCtr, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CO_ProfitCtr>(exp,values);
            return EF.DataPortal.Fetch<CO_ProfitCtrs>(lambda);
		}

		public static CO_ProfitCtrs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CO_ProfitCtrs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CO_ProfitCtr, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CO_ProfitCtrs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CO_ProfitCtr>(exp,values)});
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
