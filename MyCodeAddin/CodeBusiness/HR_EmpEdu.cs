using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpEdu))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpEdu:ReadOnlyBase<HR_EmpEdu>
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

		
        public string SchoolName
        {
            get ;
            set ;
        }

		
        public string StartPeriod
        {
            get ;
            set ;
        }

		
        public string EndPeriod
        {
            get ;
            set ;
        }

		
        public string EduGrade
        {
            get ;
            set ;
        }

		
        public bool IsMaxEdu
        {
            get ;
            set ;
        }

		
        public string DegreeGrade
        {
            get ;
            set ;
        }

		
        public bool IsMaxDegree
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

		public static HR_EmpEdu Create()
        {
            return EF.DataPortal.Create<HR_EmpEdu>();
        }

		public static HR_EmpEdu Fetch(System.Linq.Expressions.Expression<Func<HR_EmpEdu, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpEdu>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpEdu>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpEdus))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpEdus:ReadOnlyListBase<HR_EmpEdus,HR_EmpEdu>
    {
        #region Factory Methods

        public static HR_EmpEdus Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpEdus>();
        }

		public static HR_EmpEdus Fetch(System.Linq.Expressions.Expression<Func<HR_EmpEdu, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpEdu>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpEdus>(lambda);
		}

		public static HR_EmpEdus Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpEdus>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpEdus Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpEdu, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpEdus>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpEdu>(exp,values)});
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
