using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillInfo))]
#if Dev
    [RunLocal]
#endif

	public class SM_TuitionBillInfo:ReadOnlyBase<SM_TuitionBillInfo>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TuitionBillNo
        {
            get ;
            set ;
        }

		
        public string BusType
        {
            get ;
            set ;
        }

		
        public string AllotBusTypeCode
        {
            get ;
            set ;
        }

		
        public bool IsReturn
        {
            get ;
            set ;
        }

		
        public string TuitionBillText
        {
            get ;
            set ;
        }

		
        public string StartTime
        {
            get ;
            set ;
        }

		
        public string EndTime
        {
            get ;
            set ;
        }

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public bool Appoved
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

		
        public string Description
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

		
        public string VouchText
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

		public static SM_TuitionBillInfo Create()
        {
            return EF.DataPortal.Create<SM_TuitionBillInfo>();
        }

		public static SM_TuitionBillInfo Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillInfo, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillInfo>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillInfo>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(SM_TuitionBillInfos))]
#if Dev
    [RunLocal]
#endif
	
	public class SM_TuitionBillInfos:ReadOnlyListBase<SM_TuitionBillInfos,SM_TuitionBillInfo>
    {
        #region Factory Methods

        public static SM_TuitionBillInfos Fetch()
        {
            return EF.DataPortal.Fetch<SM_TuitionBillInfos>();
        }

		public static SM_TuitionBillInfos Fetch(System.Linq.Expressions.Expression<Func<SM_TuitionBillInfo, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<SM_TuitionBillInfo>(exp,values);
            return EF.DataPortal.Fetch<SM_TuitionBillInfos>(lambda);
		}

		public static SM_TuitionBillInfos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillInfos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static SM_TuitionBillInfos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<SM_TuitionBillInfo, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<SM_TuitionBillInfos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<SM_TuitionBillInfo>(exp,values)});
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
