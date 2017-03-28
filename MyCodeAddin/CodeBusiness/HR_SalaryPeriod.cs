using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryPeriod))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryPeriod:ReadOnlyBase<HR_SalaryPeriod>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryPeriod
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string SalaryRange
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

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public bool IsAppoved
        {
            get ;
            set ;
        }

		
        public string AccPeriod
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryPeriod Create()
        {
            return EF.DataPortal.Create<HR_SalaryPeriod>();
        }

		public static HR_SalaryPeriod Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryPeriod, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryPeriod>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryPeriod>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryPeriods))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryPeriods:ReadOnlyListBase<HR_SalaryPeriods,HR_SalaryPeriod>
    {
        #region Factory Methods

        public static HR_SalaryPeriods Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryPeriods>();
        }

		public static HR_SalaryPeriods Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryPeriod, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryPeriod>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryPeriods>(lambda);
		}

		public static HR_SalaryPeriods Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryPeriods>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryPeriods Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryPeriod, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryPeriods>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryPeriod>(exp,values)});
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
