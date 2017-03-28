using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(HR_ExpBus))]
#if Dev
    [RunLocal]
#endif

	public class HR_ExpBus:ReadOnlyBase<HR_ExpBus>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpBusCode
        {
            get ;
            set ;
        }

		
        public string ExpBusText
        {
            get ;
            set ;
        }

		
        public string ExpTypeCode
        {
            get ;
            set ;
        }

		
        public string WorkFlowID
        {
            get ;
            set ;
        }

		
        public decimal ExpAmt
        {
            get ;
            set ;
        }

		
        public string Period
        {
            get ;
            set ;
        }

		
        public string BarCode
        {
            get ;
            set ;
        }

		
        public bool Cancelled
        {
            get ;
            set ;
        }

		
        public bool Approved
        {
            get ;
            set ;
        }

		
        public bool IsOffset
        {
            get ;
            set ;
        }

		
        public bool IsSubmit
        {
            get ;
            set ;
        }

		
        public string Description
        {
            get ;
            set ;
        }

		
        public bool GenVouX
        {
            get ;
            set ;
        }

		
        public string ExpBusUser
        {
            get ;
            set ;
        }

		
        public string AccDateTime
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

		
        public string ExpStatus
        {
            get ;
            set ;
        }

		
        public string EttItemCode
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
        public string EndPeriod
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static HR_ExpBus Create()
        {
            return EF.DataPortal.Create<HR_ExpBus>();
        }

		public static HR_ExpBus Fetch(System.Linq.Expressions.Expression<Func<HR_ExpBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<HR_ExpBus>(exp,values);
            return EF.DataPortal.Fetch<HR_ExpBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(HR_ExpBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class HR_ExpBuss:ReadOnlyListBase<HR_ExpBuss,HR_ExpBus>
    {
        #region Factory Methods

        public static HR_ExpBuss Fetch()
        {
            return EF.DataPortal.Fetch<HR_ExpBuss>();
        }

		public static HR_ExpBuss Fetch(System.Linq.Expressions.Expression<Func<HR_ExpBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<HR_ExpBus>(exp,values);
            return EF.DataPortal.Fetch<HR_ExpBuss>(lambda);
		}

		public static HR_ExpBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<HR_ExpBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static HR_ExpBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<HR_ExpBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<HR_ExpBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<HR_ExpBus>(exp,values)});
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
