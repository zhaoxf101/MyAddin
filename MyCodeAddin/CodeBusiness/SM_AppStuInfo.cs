using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_AppStuInfo))]
#if Dev
    [RunLocal]
#endif

	public class SM_AppStuInfo:ReadOnlyBase<SM_AppStuInfo>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string AppNo
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string StudentName
        {
            get ;
            set ;
        }

		
        public string SexCode
        {
            get ;
            set ;
        }

		
        public string BirDate
        {
            get ;
            set ;
        }

		
        public string IdNo
        {
            get ;
            set ;
        }

		
        public string NationCode
        {
            get ;
            set ;
        }

		
        public string Hometown
        {
            get ;
            set ;
        }

		
        public string Origin
        {
            get ;
            set ;
        }

		
        public string PoliStatesCode
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string ClassCode
        {
            get ;
            set ;
        }

		
        public string SpecialityCode
        {
            get ;
            set ;
        }

		
        public string DegreeCode
        {
            get ;
            set ;
        }

		
        public string StudyPeriod
        {
            get ;
            set ;
        }

		
        public string LearnFormCode
        {
            get ;
            set ;
        }

		
        public string TrainDirection
        {
            get ;
            set ;
        }

		
        public string EntDate
        {
            get ;
            set ;
        }

		
        public string Tel
        {
            get ;
            set ;
        }

		
        public string MPhone
        {
            get ;
            set ;
        }

		
        public string Email
        {
            get ;
            set ;
        }

		
        public string HomeAddr
        {
            get ;
            set ;
        }

		
        public string DormNo
        {
            get ;
            set ;
        }

		
        public string RoomNo
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

		public static SM_AppStuInfo Create()
        {
            return EF.DataPortal.Create<SM_AppStuInfo>();
        }

		public static SM_AppStuInfo Fetch(System.Linq.Expressions.Expression<Func<SM_AppStuInfo, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStuInfo>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStuInfo>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_AppStuInfos))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_AppStuInfos:ReadOnlyListBase<SM_AppStuInfos,SM_AppStuInfo>
    {
        #region Factory Methods

        public static SM_AppStuInfos Fetch()
        {
            return EF.DataPortal.Fetch<SM_AppStuInfos>();
        }

		public static SM_AppStuInfos Fetch(System.Linq.Expressions.Expression<Func<SM_AppStuInfo, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_AppStuInfo>(exp,values);
            return EF.DataPortal.Fetch<SM_AppStuInfos>(lambda);
		}

		public static SM_AppStuInfos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_AppStuInfos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_AppStuInfos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_AppStuInfo, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_AppStuInfos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_AppStuInfo>(exp,values)});
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
