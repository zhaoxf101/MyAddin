using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_Class_New))]
#if Dev
    [RunLocal]
#endif

	public class SM_Class_New:ReadOnlyBase<SM_Class_New>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid ClassId
        {
            get ;
            set ;
        }

		
        public Guid GradeId
        {
            get ;
            set ;
        }

		
        public string ClassCode
        {
            get ;
            set ;
        }

		
        public string ClassName
        {
            get ;
            set ;
        }

		
        public Guid SpecialityId
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string Status
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

		public static SM_Class_New Create()
        {
            return EF.DataPortal.Create<SM_Class_New>();
        }

		public static SM_Class_New Fetch(System.Linq.Expressions.Expression<Func<SM_Class_New, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_Class_New>(exp,values);
            return EF.DataPortal.Fetch<SM_Class_New>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_Class_News))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_Class_News:ReadOnlyListBase<SM_Class_News,SM_Class_New>
    {
        #region Factory Methods

        public static SM_Class_News Fetch()
        {
            return EF.DataPortal.Fetch<SM_Class_News>();
        }

		public static SM_Class_News Fetch(System.Linq.Expressions.Expression<Func<SM_Class_New, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_Class_New>(exp,values);
            return EF.DataPortal.Fetch<SM_Class_News>(lambda);
		}

		public static SM_Class_News Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_Class_News>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_Class_News Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_Class_New, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_Class_News>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_Class_New>(exp,values)});
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
