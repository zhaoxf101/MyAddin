using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryConfirmDetail))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryConfirmDetail:ReadOnlyBase<HR_SalaryConfirmDetail>
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

		
        public string SalaryPeriod
        {
            get ;
            set ;
        }

		
        public string SalaryRanage
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

		
        public string SalaryConfirmType
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public bool IsConfirm
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryConfirmDetail Create()
        {
            return EF.DataPortal.Create<HR_SalaryConfirmDetail>();
        }

		public static HR_SalaryConfirmDetail Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryConfirmDetail, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryConfirmDetail>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryConfirmDetail>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryConfirmDetails))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryConfirmDetails:ReadOnlyListBase<HR_SalaryConfirmDetails,HR_SalaryConfirmDetail>
    {
        #region Factory Methods

        public static HR_SalaryConfirmDetails Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmDetails>();
        }

		public static HR_SalaryConfirmDetails Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryConfirmDetail, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryConfirmDetail>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryConfirmDetails>(lambda);
		}

		public static HR_SalaryConfirmDetails Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmDetails>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryConfirmDetails Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryConfirmDetail, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirmDetails>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryConfirmDetail>(exp,values)});
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
