using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryConfirmTypeSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryConfirmTypeSub:ReadOnlyBase<HR_SalaryConfirmTypeSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryConfirmType
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
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

		public static HR_SalaryConfirmTypeSub Create()
        {
            return EF.DataPortal.Create<HR_SalaryConfirmTypeSub>();
        }

		public static HR_SalaryConfirmTypeSub Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryConfirmTypeSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryConfirmTypeSub>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypeSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryConfirmTypeSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryConfirmTypeSubs:ReadOnlyListBase<HR_SalaryConfirmTypeSubs,HR_SalaryConfirmTypeSub>
    {
        #region Factory Methods

        public static HR_SalaryConfirmTypeSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypeSubs>();
        }

		public static HR_SalaryConfirmTypeSubs Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryConfirmTypeSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryConfirmTypeSub>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypeSubs>(lambda);
		}

		public static HR_SalaryConfirmTypeSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypeSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryConfirmTypeSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryConfirmTypeSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmTypeSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryConfirmTypeSub>(exp,values)});
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
