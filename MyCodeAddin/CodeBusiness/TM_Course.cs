using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TM_Course))]
#if Dev
    [RunLocal]
#endif

	public class TM_Course:ReadOnlyBase<TM_Course>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string CourseCode
        {
            get ;
            set ;
        }

		
        public string CourseName
        {
            get ;
            set ;
        }

		
        public string SpecialityCode
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public bool IsDel
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static TM_Course Create()
        {
            return EF.DataPortal.Create<TM_Course>();
        }

		public static TM_Course Fetch(System.Linq.Expressions.Expression<Func<TM_Course, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TM_Course>(exp,values);
            return EF.DataPortal.Fetch<TM_Course>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TM_Courses))]
#if Dev
    [RunLocal]
#endif
	
	public class TM_Courses:ReadOnlyListBase<TM_Courses,TM_Course>
    {
        #region Factory Methods

        public static TM_Courses Fetch()
        {
            return EF.DataPortal.Fetch<TM_Courses>();
        }

		public static TM_Courses Fetch(System.Linq.Expressions.Expression<Func<TM_Course, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TM_Course>(exp,values);
            return EF.DataPortal.Fetch<TM_Courses>(lambda);
		}

		public static TM_Courses Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TM_Courses>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TM_Courses Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TM_Course, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TM_Courses>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TM_Course>(exp,values)});
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
