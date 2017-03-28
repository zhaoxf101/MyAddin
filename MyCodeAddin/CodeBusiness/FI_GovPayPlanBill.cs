using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlanBill))]
#if Dev
    [RunLocal]
#endif

	public class FI_GovPayPlanBill:ReadOnlyBase<FI_GovPayPlanBill>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BillNo
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string IncConfTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsAdj
        {
            get ;
            set ;
        }

		
        public string RemType
        {
            get ;
            set ;
        }

		
        public string BillText
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool Appovel
        {
            get ;
            set ;
        }

		
        public string AccDateTime
        {
            get ;
            set ;
        }

		
        public bool GenVouX
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string VouchText
        {
            get ;
            set ;
        }

		
        public string Year
        {
            get ;
            set ;
        }

		
        public string GovPlayCode
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

		
        public string CheckUser
        {
            get ;
            set ;
        }

		
        public DateTime? CheckDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_GovPayPlanBill Create()
        {
            return EF.DataPortal.Create<FI_GovPayPlanBill>();
        }

		public static FI_GovPayPlanBill Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlanBill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlanBill>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlanBill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_GovPayPlanBills))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_GovPayPlanBills:ReadOnlyListBase<FI_GovPayPlanBills,FI_GovPayPlanBill>
    {
        #region Factory Methods

        public static FI_GovPayPlanBills Fetch()
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanBills>();
        }

		public static FI_GovPayPlanBills Fetch(System.Linq.Expressions.Expression<Func<FI_GovPayPlanBill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_GovPayPlanBill>(exp,values);
            return EF.DataPortal.Fetch<FI_GovPayPlanBills>(lambda);
		}

		public static FI_GovPayPlanBills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanBills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_GovPayPlanBills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_GovPayPlanBill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_GovPayPlanBills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_GovPayPlanBill>(exp,values)});
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
