using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusWorkers))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusWorkers:ReadOnlyBase<HR_EmpBusWorkers>
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

		
        public string WorkersCode
        {
            get ;
            set ;
        }

		
        public string PositionLevel
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

		public static HR_EmpBusWorkers Create()
        {
            return EF.DataPortal.Create<HR_EmpBusWorkers>();
        }

		public static HR_EmpBusWorkers Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusWorkers, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusWorkers>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusWorkers>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusWorkerss))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusWorkerss:ReadOnlyListBase<HR_EmpBusWorkerss,HR_EmpBusWorkers>
    {
        #region Factory Methods

        public static HR_EmpBusWorkerss Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusWorkerss>();
        }

		public static HR_EmpBusWorkerss Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusWorkers, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusWorkers>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusWorkerss>(lambda);
		}

		public static HR_EmpBusWorkerss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusWorkerss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusWorkerss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusWorkers, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusWorkerss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusWorkers>(exp,values)});
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
