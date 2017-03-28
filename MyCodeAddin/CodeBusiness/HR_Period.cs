using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Period))]
#if Dev
    [RunLocal]
#endif

	public class HR_Period:ReadOnlyBase<HR_Period>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public bool IsSumTax
        {
            get ;
            set ;
        }

		
        public bool IsLock
        {
            get ;
            set ;
        }

		
        public bool IsCalTax
        {
            get ;
            set ;
        }

		
        public bool IsSettle
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_Period Create()
        {
            return EF.DataPortal.Create<HR_Period>();
        }

		public static HR_Period Fetch(System.Linq.Expressions.Expression<Func<HR_Period, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Period>(exp,values);
            return EF.DataPortal.Fetch<HR_Period>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Periods))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Periods:ReadOnlyListBase<HR_Periods,HR_Period>
    {
        #region Factory Methods

        public static HR_Periods Fetch()
        {
            return EF.DataPortal.Fetch<HR_Periods>();
        }

		public static HR_Periods Fetch(System.Linq.Expressions.Expression<Func<HR_Period, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Period>(exp,values);
            return EF.DataPortal.Fetch<HR_Periods>(lambda);
		}

		public static HR_Periods Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Periods>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Periods Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Period, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Periods>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Period>(exp,values)});
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
