using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PayList))]
#if Dev
    [RunLocal]
#endif

	public class FI_PayList:ReadOnlyBase<FI_PayList>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string VouchNo
        {
            get ;
            set ;
        }

		
        public string LineNR
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string PayType
        {
            get ;
            set ;
        }

		
        public string PAccCode
        {
            get ;
            set ;
        }

		
        public string PAccount
        {
            get ;
            set ;
        }

		
        public string PBankId
        {
            get ;
            set ;
        }

		
        public string RAccount
        {
            get ;
            set ;
        }

		
        public string RBankId
        {
            get ;
            set ;
        }

		
        public bool IsProxy
        {
            get ;
            set ;
        }

		
        public string ProxyId
        {
            get ;
            set ;
        }

		
        public string AAccount
        {
            get ;
            set ;
        }

		
        public string ABankId
        {
            get ;
            set ;
        }

		
        public decimal Amt
        {
            get ;
            set ;
        }

		
        public bool IsSucc1
        {
            get ;
            set ;
        }

		
        public bool IsSucc2
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PayList Create()
        {
            return EF.DataPortal.Create<FI_PayList>();
        }

		public static FI_PayList Fetch(System.Linq.Expressions.Expression<Func<FI_PayList, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PayList>(exp,values);
            return EF.DataPortal.Fetch<FI_PayList>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PayLists))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PayLists:ReadOnlyListBase<FI_PayLists,FI_PayList>
    {
        #region Factory Methods

        public static FI_PayLists Fetch()
        {
            return EF.DataPortal.Fetch<FI_PayLists>();
        }

		public static FI_PayLists Fetch(System.Linq.Expressions.Expression<Func<FI_PayList, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PayList>(exp,values);
            return EF.DataPortal.Fetch<FI_PayLists>(lambda);
		}

		public static FI_PayLists Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PayLists>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PayLists Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PayList, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PayLists>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PayList>(exp,values)});
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
