using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryModeEmp))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryModeEmp:ReadOnlyBase<HR_SalaryModeEmp>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ModeCode
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryModeEmp Create()
        {
            return EF.DataPortal.Create<HR_SalaryModeEmp>();
        }

		public static HR_SalaryModeEmp Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryModeEmp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryModeEmp>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryModeEmp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryModeEmps))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryModeEmps:ReadOnlyListBase<HR_SalaryModeEmps,HR_SalaryModeEmp>
    {
        #region Factory Methods

        public static HR_SalaryModeEmps Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryModeEmps>();
        }

		public static HR_SalaryModeEmps Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryModeEmp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryModeEmp>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryModeEmps>(lambda);
		}

		public static HR_SalaryModeEmps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryModeEmps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryModeEmps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryModeEmp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryModeEmps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryModeEmp>(exp,values)});
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
