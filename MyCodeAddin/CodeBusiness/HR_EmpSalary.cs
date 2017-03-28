using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpSalary))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpSalary:ReadOnlyBase<HR_EmpSalary>
    {
        #region Business Methods

		
        public Guid ID
        {
            get ;
            set ;
        }

		
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

		
        public bool IsSalary
        {
            get ;
            set ;
        }

		
        public bool IsInsReturn
        {
            get ;
            set ;
        }

		
        public bool IsSalReturn
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

		
        public bool IsDel
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpSalary Create()
        {
            return EF.DataPortal.Create<HR_EmpSalary>();
        }

		public static HR_EmpSalary Fetch(System.Linq.Expressions.Expression<Func<HR_EmpSalary, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpSalary>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpSalary>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpSalarys))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpSalarys:ReadOnlyListBase<HR_EmpSalarys,HR_EmpSalary>
    {
        #region Factory Methods

        public static HR_EmpSalarys Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpSalarys>();
        }

		public static HR_EmpSalarys Fetch(System.Linq.Expressions.Expression<Func<HR_EmpSalary, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpSalary>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpSalarys>(lambda);
		}

		public static HR_EmpSalarys Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpSalarys>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpSalarys Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpSalary, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpSalarys>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpSalary>(exp,values)});
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
