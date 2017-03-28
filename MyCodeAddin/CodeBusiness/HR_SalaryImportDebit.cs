using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryImportDebit))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryImportDebit:ReadOnlyBase<HR_SalaryImportDebit>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryCode
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string DebitItemCode
        {
            get ;
            set ;
        }

		
        public string DebitItemName
        {
            get ;
            set ;
        }

		
        public decimal DetbitAmt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryImportDebit Create()
        {
            return EF.DataPortal.Create<HR_SalaryImportDebit>();
        }

		public static HR_SalaryImportDebit Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryImportDebit, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryImportDebit>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryImportDebit>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryImportDebits))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryImportDebits:ReadOnlyListBase<HR_SalaryImportDebits,HR_SalaryImportDebit>
    {
        #region Factory Methods

        public static HR_SalaryImportDebits Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryImportDebits>();
        }

		public static HR_SalaryImportDebits Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryImportDebit, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryImportDebit>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryImportDebits>(lambda);
		}

		public static HR_SalaryImportDebits Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryImportDebits>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryImportDebits Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryImportDebit, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryImportDebits>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryImportDebit>(exp,values)});
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
