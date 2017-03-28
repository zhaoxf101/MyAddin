using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryItemRes))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryItemRes:ReadOnlyBase<HR_SalaryItemRes>
    {
        #region Business Methods

		
        public string ResouItemCode
        {
            get ;
            set ;
        }

		
        public string SumGroup
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryItemRes Create()
        {
            return EF.DataPortal.Create<HR_SalaryItemRes>();
        }

		public static HR_SalaryItemRes Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryItemRes, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryItemRes>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryItemRes>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryItemRess))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryItemRess:ReadOnlyListBase<HR_SalaryItemRess,HR_SalaryItemRes>
    {
        #region Factory Methods

        public static HR_SalaryItemRess Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryItemRess>();
        }

		public static HR_SalaryItemRess Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryItemRes, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryItemRes>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryItemRess>(lambda);
		}

		public static HR_SalaryItemRess Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryItemRess>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryItemRess Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryItemRes, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryItemRess>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryItemRes>(exp,values)});
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
