using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusStatus))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusStatus:ReadOnlyBase<HR_EmpBusStatus>
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

		
        public string StatusCode
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

		public static HR_EmpBusStatus Create()
        {
            return EF.DataPortal.Create<HR_EmpBusStatus>();
        }

		public static HR_EmpBusStatus Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusStatus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusStatus>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusStatus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusStatuss))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusStatuss:ReadOnlyListBase<HR_EmpBusStatuss,HR_EmpBusStatus>
    {
        #region Factory Methods

        public static HR_EmpBusStatuss Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusStatuss>();
        }

		public static HR_EmpBusStatuss Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusStatus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusStatus>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusStatuss>(lambda);
		}

		public static HR_EmpBusStatuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusStatuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusStatuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusStatus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusStatuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusStatus>(exp,values)});
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
