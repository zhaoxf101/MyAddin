using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusEdu))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusEdu:ReadOnlyBase<HR_EmpBusEdu>
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

		
        public string EmpBusNo
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

		
        public string ActionType
        {
            get ;
            set ;
        }

		
        public Guid? OldId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpBusEdu Create()
        {
            return EF.DataPortal.Create<HR_EmpBusEdu>();
        }

		public static HR_EmpBusEdu Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusEdu, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusEdu>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusEdu>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusEdus))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusEdus:ReadOnlyListBase<HR_EmpBusEdus,HR_EmpBusEdu>
    {
        #region Factory Methods

        public static HR_EmpBusEdus Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusEdus>();
        }

		public static HR_EmpBusEdus Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusEdu, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusEdu>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusEdus>(lambda);
		}

		public static HR_EmpBusEdus Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusEdus>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusEdus Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusEdu, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusEdus>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusEdu>(exp,values)});
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
