using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryAlter))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryAlter:ReadOnlyBase<HR_SalaryAlter>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryAlterNo
        {
            get ;
            set ;
        }

		
        public string SalaryAlterType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string FileNo
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

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool IsConfirmEmp
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public bool IsConfirmSalary
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
        {
            get ;
            set ;
        }

		
        public bool IsStop
        {
            get ;
            set ;
        }

		
        public bool IsAppoved
        {
            get ;
            set ;
        }

		
        public bool IsBatch
        {
            get ;
            set ;
        }

		
        public string EmpBusNo
        {
            get ;
            set ;
        }

		
        public string BarCode
        {
            get ;
            set ;
        }

		
        public string SalaryRange
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

		public static HR_SalaryAlter Create()
        {
            return EF.DataPortal.Create<HR_SalaryAlter>();
        }

		public static HR_SalaryAlter Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryAlter, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryAlter>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryAlter>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryAlters))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryAlters:ReadOnlyListBase<HR_SalaryAlters,HR_SalaryAlter>
    {
        #region Factory Methods

        public static HR_SalaryAlters Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryAlters>();
        }

		public static HR_SalaryAlters Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryAlter, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryAlter>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryAlters>(lambda);
		}

		public static HR_SalaryAlters Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryAlters>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryAlters Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryAlter, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryAlters>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryAlter>(exp,values)});
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
