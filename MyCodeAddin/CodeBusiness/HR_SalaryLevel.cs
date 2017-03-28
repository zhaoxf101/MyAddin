using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryLevel))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryLevel:ReadOnlyBase<HR_SalaryLevel>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryLevel
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string PostCode
        {
            get ;
            set ;
        }

		
        public string Mark
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryLevel Create()
        {
            return EF.DataPortal.Create<HR_SalaryLevel>();
        }

		public static HR_SalaryLevel Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryLevel, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryLevel>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryLevels))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryLevels:ReadOnlyListBase<HR_SalaryLevels,HR_SalaryLevel>
    {
        #region Factory Methods

        public static HR_SalaryLevels Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryLevels>();
        }

		public static HR_SalaryLevels Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryLevel, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryLevel>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryLevels>(lambda);
		}

		public static HR_SalaryLevels Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryLevels>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryLevels Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryLevel, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryLevels>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryLevel>(exp,values)});
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
