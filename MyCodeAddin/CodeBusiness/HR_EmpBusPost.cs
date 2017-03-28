using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusPost))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusPost:ReadOnlyBase<HR_EmpBusPost>
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

		
        public string PostCode
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

		public static HR_EmpBusPost Create()
        {
            return EF.DataPortal.Create<HR_EmpBusPost>();
        }

		public static HR_EmpBusPost Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusPost, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusPost>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusPost>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusPosts))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusPosts:ReadOnlyListBase<HR_EmpBusPosts,HR_EmpBusPost>
    {
        #region Factory Methods

        public static HR_EmpBusPosts Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusPosts>();
        }

		public static HR_EmpBusPosts Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusPost, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusPost>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusPosts>(lambda);
		}

		public static HR_EmpBusPosts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusPosts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusPosts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusPost, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusPosts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusPost>(exp,values)});
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
