using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBusSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBusSub:ReadOnlyBase<HR_EmpBusSub>
    {
        #region Business Methods

		
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

		
        public string InfoType
        {
            get ;
            set ;
        }

		
        public string EventType
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
        public bool IsValidate
        {
            get ;
            set ;
        }

		
        public bool IsConfirm
        {
            get ;
            set ;
        }

		
        public bool IsDefaut
        {
            get ;
            set ;
        }

		
        public bool IsShow
        {
            get ;
            set ;
        }

		
        public string DefautPara
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpBusSub Create()
        {
            return EF.DataPortal.Create<HR_EmpBusSub>();
        }

		public static HR_EmpBusSub Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBusSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBusSubs:ReadOnlyListBase<HR_EmpBusSubs,HR_EmpBusSub>
    {
        #region Factory Methods

        public static HR_EmpBusSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBusSubs>();
        }

		public static HR_EmpBusSubs Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBusSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBusSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBusSubs>(lambda);
		}

		public static HR_EmpBusSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBusSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBusSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBusSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBusSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBusSub>(exp,values)});
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
