using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusDepart))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusDepart:ReadOnlyBase<HR_EmpBusDepart>
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

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string PositionCode
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

		public static HR_EmpBusDepart Create()
        {
            return EF.DataPortal.Create<HR_EmpBusDepart>();
        }

		public static HR_EmpBusDepart Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusDepart, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusDepart>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusDepart>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusDeparts))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusDeparts:ReadOnlyListBase<HR_EmpBusDeparts,HR_EmpBusDepart>
    {
        #region Factory Methods

        public static HR_EmpBusDeparts Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusDeparts>();
        }

		public static HR_EmpBusDeparts Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusDepart, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusDepart>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusDeparts>(lambda);
		}

		public static HR_EmpBusDeparts Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusDeparts>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusDeparts Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusDepart, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusDeparts>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusDepart>(exp,values)});
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
