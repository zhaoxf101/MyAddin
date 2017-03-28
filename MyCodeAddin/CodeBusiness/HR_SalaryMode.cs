using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryMode))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryMode:ReadOnlyBase<HR_SalaryMode>
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

		
        public string ModeText
        {
            get ;
            set ;
        }

		
        public string StatusCode
        {
            get ;
            set ;
        }

		
        public string StaffTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsListPer
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryMode Create()
        {
            return EF.DataPortal.Create<HR_SalaryMode>();
        }

		public static HR_SalaryMode Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryMode, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryMode>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryMode>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryModes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryModes:ReadOnlyListBase<HR_SalaryModes,HR_SalaryMode>
    {
        #region Factory Methods

        public static HR_SalaryModes Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryModes>();
        }

		public static HR_SalaryModes Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryMode, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryMode>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryModes>(lambda);
		}

		public static HR_SalaryModes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryModes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryModes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryMode, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryModes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryMode>(exp,values)});
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
