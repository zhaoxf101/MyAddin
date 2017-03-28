using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpTitle))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpTitle:ReadOnlyBase<HR_EmpTitle>
    {
        #region Business Methods

		
        public Guid Id
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

		
        public string TitleCode
        {
            get ;
            set ;
        }

		
        public string SalaryLevel
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

		public static HR_EmpTitle Create()
        {
            return EF.DataPortal.Create<HR_EmpTitle>();
        }

		public static HR_EmpTitle Fetch(System.Linq.Expressions.Expression<Func<HR_EmpTitle, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpTitle>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpTitle>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpTitles))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpTitles:ReadOnlyListBase<HR_EmpTitles,HR_EmpTitle>
    {
        #region Factory Methods

        public static HR_EmpTitles Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpTitles>();
        }

		public static HR_EmpTitles Fetch(System.Linq.Expressions.Expression<Func<HR_EmpTitle, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpTitle>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpTitles>(lambda);
		}

		public static HR_EmpTitles Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpTitles>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpTitles Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpTitle, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpTitles>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpTitle>(exp,values)});
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
