using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmployeeBill))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmployeeBill:ReadOnlyBase<HR_EmployeeBill>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid ID
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string EmpName
        {
            get ;
            set ;
        }

		
        public string IDType
        {
            get ;
            set ;
        }

		
        public string IDNo
        {
            get ;
            set ;
        }

		
        public string Hometown
        {
            get ;
            set ;
        }

		
        public string Sex
        {
            get ;
            set ;
        }

		
        public string Politics
        {
            get ;
            set ;
        }

		
        public DateTime? Birthday
        {
            get ;
            set ;
        }

		
        public string Country
        {
            get ;
            set ;
        }

		
        public string Addr
        {
            get ;
            set ;
        }

		
        public string Nation
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmployeeBill Create()
        {
            return EF.DataPortal.Create<HR_EmployeeBill>();
        }

		public static HR_EmployeeBill Fetch(System.Linq.Expressions.Expression<Func<HR_EmployeeBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmployeeBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmployeeBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmployeeBills))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmployeeBills:ReadOnlyListBase<HR_EmployeeBills,HR_EmployeeBill>
    {
        #region Factory Methods

        public static HR_EmployeeBills Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmployeeBills>();
        }

		public static HR_EmployeeBills Fetch(System.Linq.Expressions.Expression<Func<HR_EmployeeBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmployeeBill>(exp,values);
            return EF.DataPortal.Fetch<HR_EmployeeBills>(lambda);
		}

		public static HR_EmployeeBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmployeeBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmployeeBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmployeeBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmployeeBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmployeeBill>(exp,values)});
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
