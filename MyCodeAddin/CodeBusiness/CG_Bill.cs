using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(CG_Bill))]
#if Dev
    [RunLocal]
#endif

	public class CG_Bill:ReadOnlyBase<CG_Bill>
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

		
        public string IntervalCode
        {
            get ;
            set ;
        }

		
        public string FeeItemCode
        {
            get ;
            set ;
        }

		
        public string BillTypeCode
        {
            get ;
            set ;
        }

		
        public string BillText
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public string UserGroup
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
        public string StartDate
        {
            get ;
            set ;
        }

		
        public string EndDate
        {
            get ;
            set ;
        }

		
        public bool IsSub
        {
            get ;
            set ;
        }

		
        public bool IsCancel
        {
            get ;
            set ;
        }

		
        public bool IsAppovel
        {
            get ;
            set ;
        }

		
        public string OrderNo
        {
            get ;
            set ;
        }

		
        public string AdjBillNo
        {
            get ;
            set ;
        }

		
        public string AdjOrdNo
        {
            get ;
            set ;
        }

		
        public bool IsAdd
        {
            get ;
            set ;
        }

		
        public string CreateUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreateDate
        {
            get ;
            set ;
        }

		
        public string ChangeUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangeDate
        {
            get ;
            set ;
        }

		
        public decimal BillAmt
        {
            get ;
            set ;
        }

		
        public bool IsSpecAmt
        {
            get ;
            set ;
        }

		
        public bool IsOnce
        {
            get ;
            set ;
        }

		
        public bool IsAdj
        {
            get ;
            set ;
        }

		
        public bool IsClose
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public bool IsOut
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static CG_Bill Create()
        {
            return EF.DataPortal.Create<CG_Bill>();
        }

		public static CG_Bill Fetch(System.Linq.Expressions.Expression<Func<CG_Bill, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<CG_Bill>(exp,values);
            return EF.DataPortal.Fetch<CG_Bill>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(CG_Bills))]
#if Dev
    [RunLocal]
#endif
	
	public class CG_Bills:ReadOnlyListBase<CG_Bills,CG_Bill>
    {
        #region Factory Methods

        public static CG_Bills Fetch()
        {
            return EF.DataPortal.Fetch<CG_Bills>();
        }

		public static CG_Bills Fetch(System.Linq.Expressions.Expression<Func<CG_Bill, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<CG_Bill>(exp,values);
            return EF.DataPortal.Fetch<CG_Bills>(lambda);
		}

		public static CG_Bills Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<CG_Bills>(new Paging { Page=page,RowCount=rowCount});
        }

        public static CG_Bills Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<CG_Bill, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<CG_Bills>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<CG_Bill>(exp,values)});
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
