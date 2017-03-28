using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EventEmpBillSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_EventEmpBillSub:ReadOnlyBase<HR_EventEmpBillSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string RelationGroup
        {
            get ;
            set ;
        }

		
        public bool IsAppovel
        {
            get ;
            set ;
        }

		
        public int Sort
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EventEmpBillSub Create()
        {
            return EF.DataPortal.Create<HR_EventEmpBillSub>();
        }

		public static HR_EventEmpBillSub Fetch(System.Linq.Expressions.Expression<Func<HR_EventEmpBillSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EventEmpBillSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EventEmpBillSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EventEmpBillSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EventEmpBillSubs:ReadOnlyListBase<HR_EventEmpBillSubs,HR_EventEmpBillSub>
    {
        #region Factory Methods

        public static HR_EventEmpBillSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_EventEmpBillSubs>();
        }

		public static HR_EventEmpBillSubs Fetch(System.Linq.Expressions.Expression<Func<HR_EventEmpBillSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EventEmpBillSub>(exp,values);
            return EF.DataPortal.Fetch<HR_EventEmpBillSubs>(lambda);
		}

		public static HR_EventEmpBillSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EventEmpBillSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EventEmpBillSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EventEmpBillSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EventEmpBillSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EventEmpBillSub>(exp,values)});
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
