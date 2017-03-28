using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryAlterSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryAlterSub:ReadOnlyBase<HR_SalaryAlterSub>
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

		
        public string SalaryAlterNo
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
        {
            get ;
            set ;
        }

		
        public decimal Amt
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

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public Guid? OldId
        {
            get ;
            set ;
        }

		
        public string ActionType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryAlterSub Create()
        {
            return EF.DataPortal.Create<HR_SalaryAlterSub>();
        }

		public static HR_SalaryAlterSub Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryAlterSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryAlterSub>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryAlterSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryAlterSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryAlterSubs:ReadOnlyListBase<HR_SalaryAlterSubs,HR_SalaryAlterSub>
    {
        #region Factory Methods

        public static HR_SalaryAlterSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryAlterSubs>();
        }

		public static HR_SalaryAlterSubs Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryAlterSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryAlterSub>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryAlterSubs>(lambda);
		}

		public static HR_SalaryAlterSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryAlterSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryAlterSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryAlterSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryAlterSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryAlterSub>(exp,values)});
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
