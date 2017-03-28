using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_Speciality_New))]
#if Dev
    [RunLocal]
#endif

	public class SM_Speciality_New:ReadOnlyBase<SM_Speciality_New>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public Guid SpecialityId
        {
            get ;
            set ;
        }

		
        public string SpecialityCode
        {
            get ;
            set ;
        }

		
        public string SpecialityName
        {
            get ;
            set ;
        }

		
        public string SpecialityTypeCode
        {
            get ;
            set ;
        }

		
        public string DegreeCode
        {
            get ;
            set ;
        }

		
        public decimal EduYear
        {
            get ;
            set ;
        }

		
        public string DepCode
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

		
        public string Status
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_Speciality_New Create()
        {
            return EF.DataPortal.Create<SM_Speciality_New>();
        }

		public static SM_Speciality_New Fetch(System.Linq.Expressions.Expression<Func<SM_Speciality_New, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_Speciality_New>(exp,values);
            return EF.DataPortal.Fetch<SM_Speciality_New>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_Speciality_News))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_Speciality_News:ReadOnlyListBase<SM_Speciality_News,SM_Speciality_New>
    {
        #region Factory Methods

        public static SM_Speciality_News Fetch()
        {
            return EF.DataPortal.Fetch<SM_Speciality_News>();
        }

		public static SM_Speciality_News Fetch(System.Linq.Expressions.Expression<Func<SM_Speciality_New, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_Speciality_New>(exp,values);
            return EF.DataPortal.Fetch<SM_Speciality_News>(lambda);
		}

		public static SM_Speciality_News Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_Speciality_News>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_Speciality_News Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_Speciality_New, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_Speciality_News>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_Speciality_New>(exp,values)});
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
