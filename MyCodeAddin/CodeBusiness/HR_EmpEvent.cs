using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpEvent))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpEvent:ReadOnlyBase<HR_EmpEvent>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EmpEvent
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public bool IsInfo
        {
            get ;
            set ;
        }

		
        public string WebObject
        {
            get ;
            set ;
        }

		
        public string WinObject
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpEvent Create()
        {
            return EF.DataPortal.Create<HR_EmpEvent>();
        }

		public static HR_EmpEvent Fetch(System.Linq.Expressions.Expression<Func<HR_EmpEvent, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpEvent>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpEvent>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpEvents))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpEvents:ReadOnlyListBase<HR_EmpEvents,HR_EmpEvent>
    {
        #region Factory Methods

        public static HR_EmpEvents Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpEvents>();
        }

		public static HR_EmpEvents Fetch(System.Linq.Expressions.Expression<Func<HR_EmpEvent, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpEvent>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpEvents>(lambda);
		}

		public static HR_EmpEvents Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpEvents>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpEvents Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpEvent, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpEvents>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpEvent>(exp,values)});
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
