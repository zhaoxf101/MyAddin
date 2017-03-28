using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_Employee_New))]
#if Dev
    [RunLocal]
#endif

	public class HR_Employee_New:ReadOnlyBase<HR_Employee_New>
    {
        #region Business Methods

		
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

		
        public string EmpName
        {
            get ;
            set ;
        }

		
        public string IdType
        {
            get ;
            set ;
        }

		
        public string IdNo
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

		
        public string HomeAddress
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

		
        public string WeChatNo
        {
            get ;
            set ;
        }

		
        public string QQNo
        {
            get ;
            set ;
        }

		
        public string ImageUrl
        {
            get ;
            set ;
        }

		
        public bool IsInsReturn
        {
            get ;
            set ;
        }

		
        public bool IsSalReturn
        {
            get ;
            set ;
        }

		
        public string PostTypeCode1
        {
            get ;
            set ;
        }

		
        public string PostTypeCode2
        {
            get ;
            set ;
        }

		
        public string SalaryRangeCode
        {
            get ;
            set ;
        }

		
        public string UsedName
        {
            get ;
            set ;
        }

		
        public string ContactAddress
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static HR_Employee_New Create()
        {
            return EF.DataPortal.Create<HR_Employee_New>();
        }

		public static HR_Employee_New Fetch(System.Linq.Expressions.Expression<Func<HR_Employee_New, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_Employee_New>(exp,values);
            return EF.DataPortal.Fetch<HR_Employee_New>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_Employee_News))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_Employee_News:ReadOnlyListBase<HR_Employee_News,HR_Employee_New>
    {
        #region Factory Methods

        public static HR_Employee_News Fetch()
        {
            return EF.DataPortal.Fetch<HR_Employee_News>();
        }

		public static HR_Employee_News Fetch(System.Linq.Expressions.Expression<Func<HR_Employee_New, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_Employee_New>(exp,values);
            return EF.DataPortal.Fetch<HR_Employee_News>(lambda);
		}

		public static HR_Employee_News Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_Employee_News>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_Employee_News Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_Employee_New, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_Employee_News>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_Employee_New>(exp,values)});
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
