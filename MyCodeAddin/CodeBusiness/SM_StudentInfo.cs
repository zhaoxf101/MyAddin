using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_StudentInfo))]
#if Dev
    [RunLocal]
#endif

	public class SM_StudentInfo:ReadOnlyBase<SM_StudentInfo>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string StudentName
        {
            get ;
            set ;
        }

		
        public string Sex
        {
            get ;
            set ;
        }

		
        public string BirDate
        {
            get ;
            set ;
        }

		
        public DateTime? Birth
        {
            get ;
            set ;
        }

		
        public string Nation
        {
            get ;
            set ;
        }

		
        public string Hometown
        {
            get ;
            set ;
        }

		
        public string PoliStatesCode
        {
            get ;
            set ;
        }

		
        public string Origin
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

		
        public string StudentStatusCode
        {
            get ;
            set ;
        }

		
        public string CurrentGrade
        {
            get ;
            set ;
        }

		
        public string TrainDirection
        {
            get ;
            set ;
        }

		
        public string IdNo
        {
            get ;
            set ;
        }

		
        public string BankCardNo
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public DateTime? EntranceDate
        {
            get ;
            set ;
        }

		
        public string EntDate
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

		
        public bool IsInReg
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_StudentInfo Create()
        {
            return EF.DataPortal.Create<SM_StudentInfo>();
        }

		public static SM_StudentInfo Fetch(System.Linq.Expressions.Expression<Func<SM_StudentInfo, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_StudentInfo>(exp,values);
            return EF.DataPortal.Fetch<SM_StudentInfo>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_StudentInfos))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_StudentInfos:ReadOnlyListBase<SM_StudentInfos,SM_StudentInfo>
    {
        #region Factory Methods

        public static SM_StudentInfos Fetch()
        {
            return EF.DataPortal.Fetch<SM_StudentInfos>();
        }

		public static SM_StudentInfos Fetch(System.Linq.Expressions.Expression<Func<SM_StudentInfo, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_StudentInfo>(exp,values);
            return EF.DataPortal.Fetch<SM_StudentInfos>(lambda);
		}

		public static SM_StudentInfos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_StudentInfos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_StudentInfos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_StudentInfo, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_StudentInfos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_StudentInfo>(exp,values)});
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
