using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_SalaryAlterType))]
#if Dev
    [RunLocal]
#endif

	public class HR_SalaryAlterType:ReadOnlyBase<HR_SalaryAlterType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string SalaryAlterType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public bool IsConfirmEmp
        {
            get ;
            set ;
        }

		
        public bool IsConfirmSalary
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_SalaryAlterType Create()
        {
            return EF.DataPortal.Create<HR_SalaryAlterType>();
        }

		public static HR_SalaryAlterType Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryAlterType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryAlterType>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryAlterType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_SalaryAlterTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_SalaryAlterTypes:ReadOnlyListBase<HR_SalaryAlterTypes,HR_SalaryAlterType>
    {
        #region Factory Methods

        public static HR_SalaryAlterTypes Fetch()
        {
            return EF.DataPortal.Fetch<HR_SalaryAlterTypes>();
        }

		public static HR_SalaryAlterTypes Fetch(System.Linq.Expressions.Expression<Func<HR_SalaryAlterType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_SalaryAlterType>(exp,values);
            return EF.DataPortal.Fetch<HR_SalaryAlterTypes>(lambda);
		}

		public static HR_SalaryAlterTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_SalaryAlterTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_SalaryAlterTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_SalaryAlterType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_SalaryAlterTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_SalaryAlterType>(exp,values)});
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
