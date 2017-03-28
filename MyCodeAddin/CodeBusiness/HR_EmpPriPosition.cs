using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpPriPosition))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpPriPosition:ReadOnlyBase<HR_EmpPriPosition>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string EmpStatusCode
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
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

		public static HR_EmpPriPosition Create()
        {
            return EF.DataPortal.Create<HR_EmpPriPosition>();
        }

		public static HR_EmpPriPosition Fetch(System.Linq.Expressions.Expression<Func<HR_EmpPriPosition, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpPriPosition>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpPriPosition>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpPriPositions))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpPriPositions:ReadOnlyListBase<HR_EmpPriPositions,HR_EmpPriPosition>
    {
        #region Factory Methods

        public static HR_EmpPriPositions Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpPriPositions>();
        }

		public static HR_EmpPriPositions Fetch(System.Linq.Expressions.Expression<Func<HR_EmpPriPosition, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpPriPosition>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpPriPositions>(lambda);
		}

		public static HR_EmpPriPositions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpPriPositions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpPriPositions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpPriPosition, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpPriPositions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpPriPosition>(exp,values)});
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
