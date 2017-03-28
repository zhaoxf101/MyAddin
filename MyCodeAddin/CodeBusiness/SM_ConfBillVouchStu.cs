using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_ConfBillVouchStu))]
#if Dev
    [RunLocal]
#endif

	public class SM_ConfBillVouchStu:ReadOnlyBase<SM_ConfBillVouchStu>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ConfCode
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string AccYear
        {
            get ;
            set ;
        }

		
        public string AccPid
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string StudentNo
        {
            get ;
            set ;
        }

		
        public string TransactionDate
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static SM_ConfBillVouchStu Create()
        {
            return EF.DataPortal.Create<SM_ConfBillVouchStu>();
        }

		public static SM_ConfBillVouchStu Fetch(System.Linq.Expressions.Expression<Func<SM_ConfBillVouchStu, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfBillVouchStu>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfBillVouchStu>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_ConfBillVouchStus))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_ConfBillVouchStus:ReadOnlyListBase<SM_ConfBillVouchStus,SM_ConfBillVouchStu>
    {
        #region Factory Methods

        public static SM_ConfBillVouchStus Fetch()
        {
            return EF.DataPortal.Fetch<SM_ConfBillVouchStus>();
        }

		public static SM_ConfBillVouchStus Fetch(System.Linq.Expressions.Expression<Func<SM_ConfBillVouchStu, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_ConfBillVouchStu>(exp,values);
            return EF.DataPortal.Fetch<SM_ConfBillVouchStus>(lambda);
		}

		public static SM_ConfBillVouchStus Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_ConfBillVouchStus>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_ConfBillVouchStus Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_ConfBillVouchStu, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_ConfBillVouchStus>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_ConfBillVouchStu>(exp,values)});
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
