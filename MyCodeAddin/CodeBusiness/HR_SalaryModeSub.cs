using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryModeSub))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryModeSub:ReadOnlyBase<HR_SalaryModeSub>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ModeCode
        {
            get ;
            set ;
        }

		
        public string SalaryItemCode
        {
            get ;
            set ;
        }

		
        public int? Sort
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string ExpItemRow
        {
            get ;
            set ;
        }

		
        public string ExpItemCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryModeSub Create()
        {
            return EF.DataPortal.Create<HR_SalaryModeSub>();
        }

		public static HR_SalaryModeSub Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryModeSub, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryModeSub>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryModeSub>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryModeSubs))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryModeSubs:ReadOnlyListBase<HR_SalaryModeSubs,HR_SalaryModeSub>
    {
        #region Factory Methods

        public static HR_SalaryModeSubs Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryModeSubs>();
        }

		public static HR_SalaryModeSubs Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryModeSub, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryModeSub>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryModeSubs>(lambda);
		}

		public static HR_SalaryModeSubs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryModeSubs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryModeSubs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryModeSub, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryModeSubs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryModeSub>(exp,values)});
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
