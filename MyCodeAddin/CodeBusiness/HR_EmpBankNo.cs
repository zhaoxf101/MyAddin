using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_EmpBankNo))]
#if Dev
    [RunLocal]
#endif

	public class HR_EmpBankNo:ReadOnlyBase<HR_EmpBankNo>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string EmpCode
        {
            get ;
            set ;
        }

		
        public string BankNo
        {
            get ;
            set ;
        }

		
        public string BankCode
        {
            get ;
            set ;
        }

		
        public string MobileTel
        {
            get ;
            set ;
        }

		
        public bool Flag
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_EmpBankNo Create()
        {
            return EF.DataPortal.Create<HR_EmpBankNo>();
        }

		public static HR_EmpBankNo Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBankNo, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBankNo>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBankNo>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_EmpBankNos))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_EmpBankNos:ReadOnlyListBase<HR_EmpBankNos,HR_EmpBankNo>
    {
        #region Factory Methods

        public static HR_EmpBankNos Fetch()
        {
            return EF.DataPortal.Fetch<HR_EmpBankNos>();
        }

		public static HR_EmpBankNos Fetch(System.Linq.Expressions.Expression<Func<HR_EmpBankNo, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_EmpBankNo>(exp,values);
            return EF.DataPortal.Fetch<HR_EmpBankNos>(lambda);
		}

		public static HR_EmpBankNos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_EmpBankNos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_EmpBankNos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_EmpBankNo, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_EmpBankNos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_EmpBankNo>(exp,values)});
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
