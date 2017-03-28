using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpDepart))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpDepart:ReadOnlyBase<HR_EmpDepart>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid Id
        {
            get ;
            set ;
        }

		
        public string EmpCode
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

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string PositionCode
        {
            get ;
            set ;
        }

		
        public string RowStatus
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

		public static HR_EmpDepart Create()
        {
            return EF.DataPortal.Create<HR_EmpDepart>();
        }

		public static HR_EmpDepart Fetch(System.Linq.Expressions.Expression<Func<HR_EmpDepart, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpDepart>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpDepart>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpDeparts))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpDeparts:ReadOnlyListBase<HR_EmpDeparts,HR_EmpDepart>
    {
        #region Factory Methods

        public static HR_EmpDeparts Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpDeparts>();
        }

		public static HR_EmpDeparts Fetch(System.Linq.Expressions.Expression<Func<HR_EmpDepart, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpDepart>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpDeparts>(lambda);
		}

		public static HR_EmpDeparts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpDeparts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpDeparts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpDepart, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpDeparts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpDepart>(exp,values)});
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
