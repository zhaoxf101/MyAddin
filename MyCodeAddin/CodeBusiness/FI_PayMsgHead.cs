using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PayMsgHead))]
#if Dev
    [RunLocal]
#endif

	public class FI_PayMsgHead:ReadOnlyBase<FI_PayMsgHead>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string MsgId
        {
            get ;
            set ;
        }

		
        public bool IsSend
        {
            get ;
            set ;
        }

		
        public bool IsBankMsg
        {
            get ;
            set ;
        }

		
        public string State
        {
            get ;
            set ;
        }

		
        public bool IsProxy
        {
            get ;
            set ;
        }

		
        public string BKCode
        {
            get ;
            set ;
        }

		
        public string ParkVouchNo
        {
            get ;
            set ;
        }

		
        public string ProxyMsgId
        {
            get ;
            set ;
        }

		
        public string TranCode
        {
            get ;
            set ;
        }

		
        public string SendUser
        {
            get ;
            set ;
        }

		
        public DateTime? SendDateTime
        {
            get ;
            set ;
        }

		
        public DateTime? ReturnDateTime
        {
            get ;
            set ;
        }

		
        public string ReturnCode
        {
            get ;
            set ;
        }

		
        public string ReutrnMeg
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

		
        public bool IsNotice
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PayMsgHead Create()
        {
            return EF.DataPortal.Create<FI_PayMsgHead>();
        }

		public static FI_PayMsgHead Fetch(System.Linq.Expressions.Expression<Func<FI_PayMsgHead, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PayMsgHead>(exp,values);
            return EF.DataPortal.Fetch<FI_PayMsgHead>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PayMsgHeads))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PayMsgHeads:ReadOnlyListBase<FI_PayMsgHeads,FI_PayMsgHead>
    {
        #region Factory Methods

        public static FI_PayMsgHeads Fetch()
        {
            return EF.DataPortal.Fetch<FI_PayMsgHeads>();
        }

		public static FI_PayMsgHeads Fetch(System.Linq.Expressions.Expression<Func<FI_PayMsgHead, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PayMsgHead>(exp,values);
            return EF.DataPortal.Fetch<FI_PayMsgHeads>(lambda);
		}

		public static FI_PayMsgHeads Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PayMsgHeads>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PayMsgHeads Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PayMsgHead, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PayMsgHeads>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PayMsgHead>(exp,values)});
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
