using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryRange))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryRange:ReadOnlyBase<HR_SalaryRange>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryRange
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryRange Create()
        {
            return EF.DataPortal.Create<HR_SalaryRange>();
        }

		public static HR_SalaryRange Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryRange, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryRange>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryRange>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryRanges))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryRanges:ReadOnlyListBase<HR_SalaryRanges,HR_SalaryRange>
    {
        #region Factory Methods

        public static HR_SalaryRanges Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryRanges>();
        }

		public static HR_SalaryRanges Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryRange, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryRange>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryRanges>(lambda);
		}

		public static HR_SalaryRanges Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryRanges>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryRanges Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryRange, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryRanges>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryRange>(exp,values)});
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
