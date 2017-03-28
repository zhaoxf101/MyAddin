using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryConfirm))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryConfirm:ReadOnlyBase<HR_SalaryConfirm>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryPeriod
        {
            get ;
            set ;
        }

		
        public string SalaryConfirmType
        {
            get ;
            set ;
        }

		
        public string SalaryRanageCode
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public bool IsSubmt
        {
            get ;
            set ;
        }

		
        public bool IsAppoved
        {
            get ;
            set ;
        }

		
        public string RowStatus
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryConfirm Create()
        {
            return EF.DataPortal.Create<HR_SalaryConfirm>();
        }

		public static HR_SalaryConfirm Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryConfirm, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryConfirm>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryConfirm>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryConfirms))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryConfirms:ReadOnlyListBase<HR_SalaryConfirms,HR_SalaryConfirm>
    {
        #region Factory Methods

        public static HR_SalaryConfirms Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirms>();
        }

		public static HR_SalaryConfirms Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryConfirm, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryConfirm>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryConfirms>(lambda);
		}

		public static HR_SalaryConfirms Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirms>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryConfirms Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryConfirm, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryConfirms>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryConfirm>(exp,values)});
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
