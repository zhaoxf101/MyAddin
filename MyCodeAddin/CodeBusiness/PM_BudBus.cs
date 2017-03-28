using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_BudBus))]
#if Dev
    [RunLocal]
#endif

	public class PM_BudBus:ReadOnlyBase<PM_BudBus>
    {
        #region Business Methods

		
        public string BudBusCode
        {
            get ;
            set ;
        }

		
        public string BudBusName
        {
            get ;
            set ;
        }

		
        public string BudBusGrp
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static PM_BudBus Create()
        {
            return EF.DataPortal.Create<PM_BudBus>();
        }

		public static PM_BudBus Fetch(System.Linq.Expressions.Expression<Func<PM_BudBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_BudBus>(exp,values);
            return EF.DataPortal.Fetch<PM_BudBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_BudBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_BudBuss:ReadOnlyListBase<PM_BudBuss,PM_BudBus>
    {
        #region Factory Methods

        public static PM_BudBuss Fetch()
        {
            return EF.DataPortal.Fetch<PM_BudBuss>();
        }

		public static PM_BudBuss Fetch(System.Linq.Expressions.Expression<Func<PM_BudBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_BudBus>(exp,values);
            return EF.DataPortal.Fetch<PM_BudBuss>(lambda);
		}

		public static PM_BudBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_BudBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_BudBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_BudBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_BudBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_BudBus>(exp,values)});
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
