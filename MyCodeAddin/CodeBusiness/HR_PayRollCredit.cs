using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_PayRollCredit))]
#if Dev
    [RunLocal]
#endif

	public class HR_PayRollCredit:ReadOnlyBase<HR_PayRollCredit>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string CustCode
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string IncDetCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_PayRollCredit Create()
        {
            return EF.DataPortal.Create<HR_PayRollCredit>();
        }

		public static HR_PayRollCredit Fetch(System.Linq.Expressions.Expression<Func<HR_PayRollCredit, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_PayRollCredit>(exp,values);
            return EF.DataPortal.Fetch<HR_PayRollCredit>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_PayRollCredits))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_PayRollCredits:ReadOnlyListBase<HR_PayRollCredits,HR_PayRollCredit>
    {
        #region Factory Methods

        public static HR_PayRollCredits Fetch()
        {
            return EF.DataPortal.Fetch<HR_PayRollCredits>();
        }

		public static HR_PayRollCredits Fetch(System.Linq.Expressions.Expression<Func<HR_PayRollCredit, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_PayRollCredit>(exp,values);
            return EF.DataPortal.Fetch<HR_PayRollCredits>(lambda);
		}

		public static HR_PayRollCredits Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_PayRollCredits>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_PayRollCredits Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_PayRollCredit, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_PayRollCredits>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_PayRollCredit>(exp,values)});
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
