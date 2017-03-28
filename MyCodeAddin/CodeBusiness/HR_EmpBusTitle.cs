using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusTitle))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusTitle:ReadOnlyBase<HR_EmpBusTitle>
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

		public static HR_EmpBusTitle Create()
        {
            return EF.DataPortal.Create<HR_EmpBusTitle>();
        }

		public static HR_EmpBusTitle Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusTitle, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusTitle>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusTitle>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusTitles))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusTitles:ReadOnlyListBase<HR_EmpBusTitles,HR_EmpBusTitle>
    {
        #region Factory Methods

        public static HR_EmpBusTitles Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusTitles>();
        }

		public static HR_EmpBusTitles Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusTitle, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusTitle>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusTitles>(lambda);
		}

		public static HR_EmpBusTitles Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusTitles>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusTitles Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusTitle, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusTitles>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusTitle>(exp,values)});
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
