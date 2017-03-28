using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PayMsg))]
#if Dev
    [RunLocal]
#endif

	public class FI_PayMsg:ReadOnlyBase<FI_PayMsg>
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

		
        public string RowId
        {
            get ;
            set ;
        }

		
        public string PAccount
        {
            get ;
            set ;
        }

		
        public string PAccName
        {
            get ;
            set ;
        }

		
        public string PBankName
        {
            get ;
            set ;
        }

		
        public string PUnitedBankId
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string RAccount
        {
            get ;
            set ;
        }

		
        public string RAccName
        {
            get ;
            set ;
        }

		
        public string RBankName
        {
            get ;
            set ;
        }

		
        public string RUnitedBankId
        {
            get ;
            set ;
        }

		
        public bool SysIOFlg
        {
            get ;
            set ;
        }

		
        public bool IsPublic
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public string MsgBillNo
        {
            get ;
            set ;
        }

		
        public string ErrorMsg
        {
            get ;
            set ;
        }

		
        public string UseText
        {
            get ;
            set ;
        }

		
        public string ReqText1
        {
            get ;
            set ;
        }

		
        public string ReqText2
        {
            get ;
            set ;
        }

		
        public bool IsBankBack
        {
            get ;
            set ;
        }

		
        public bool IsHandle
        {
            get ;
            set ;
        }

		
        public string HandleMsgId
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PayMsg Create()
        {
            return EF.DataPortal.Create<FI_PayMsg>();
        }

		public static FI_PayMsg Fetch(System.Linq.Expressions.Expression<Func<FI_PayMsg, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PayMsg>(exp,values);
            return EF.DataPortal.Fetch<FI_PayMsg>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PayMsgs))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PayMsgs:ReadOnlyListBase<FI_PayMsgs,FI_PayMsg>
    {
        #region Factory Methods

        public static FI_PayMsgs Fetch()
        {
            return EF.DataPortal.Fetch<FI_PayMsgs>();
        }

		public static FI_PayMsgs Fetch(System.Linq.Expressions.Expression<Func<FI_PayMsg, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PayMsg>(exp,values);
            return EF.DataPortal.Fetch<FI_PayMsgs>(lambda);
		}

		public static FI_PayMsgs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PayMsgs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PayMsgs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PayMsg, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PayMsgs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PayMsg>(exp,values)});
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
