using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpPostion))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpPostion:ReadOnlyBase<HR_EmpPostion>
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

		
        public bool ChiefX
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

		public static HR_EmpPostion Create()
        {
            return EF.DataPortal.Create<HR_EmpPostion>();
        }

		public static HR_EmpPostion Fetch(System.Linq.Expressions.Expression<Func<HR_EmpPostion, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpPostion>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpPostion>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpPostions))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpPostions:ReadOnlyListBase<HR_EmpPostions,HR_EmpPostion>
    {
        #region Factory Methods

        public static HR_EmpPostions Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpPostions>();
        }

		public static HR_EmpPostions Fetch(System.Linq.Expressions.Expression<Func<HR_EmpPostion, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpPostion>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpPostions>(lambda);
		}

		public static HR_EmpPostions Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpPostions>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpPostions Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpPostion, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpPostions>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpPostion>(exp,values)});
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
