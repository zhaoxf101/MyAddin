using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmployeeStatus))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmployeeStatus:ReadOnlyBase<HR_EmployeeStatus>
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

		
        public string EmpStatusCode
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

		public static HR_EmployeeStatus Create()
        {
            return EF.DataPortal.Create<HR_EmployeeStatus>();
        }

		public static HR_EmployeeStatus Fetch(System.Linq.Expressions.Expression<Func<HR_EmployeeStatus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmployeeStatus>(exp,values);
            return EF.DataPortal.Fetch<HR_EmployeeStatus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmployeeStatuss))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmployeeStatuss:ReadOnlyListBase<HR_EmployeeStatuss,HR_EmployeeStatus>
    {
        #region Factory Methods

        public static HR_EmployeeStatuss Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmployeeStatuss>();
        }

		public static HR_EmployeeStatuss Fetch(System.Linq.Expressions.Expression<Func<HR_EmployeeStatus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmployeeStatus>(exp,values);
            return EF.DataPortal.Fetch<HR_EmployeeStatuss>(lambda);
		}

		public static HR_EmployeeStatuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmployeeStatuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmployeeStatuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmployeeStatus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmployeeStatuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmployeeStatus>(exp,values)});
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
