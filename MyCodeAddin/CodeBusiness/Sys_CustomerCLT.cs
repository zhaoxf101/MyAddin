using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_CustomerCLT))]
#if Dev
    [RunLocal]
#endif

	public class Sys_CustomerCLT:ReadOnlyBase<Sys_CustomerCLT>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string CustCode
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public bool InternalX
        {
            get ;
            set ;
        }

		
        public string PersonId
        {
            get ;
            set ;
        }

		
        public string BankCardNo
        {
            get ;
            set ;
        }

		
        public string UnitedBankId
        {
            get ;
            set ;
        }

		
        public bool IsToPub
        {
            get ;
            set ;
        }

		
        public string BankName
        {
            get ;
            set ;
        }

		
        public string AccountName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
        public bool Active
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

		
		#endregion

		#region Factory Methods

		public static Sys_CustomerCLT Create()
        {
            return EF.DataPortal.Create<Sys_CustomerCLT>();
        }

		public static Sys_CustomerCLT Fetch(System.Linq.Expressions.Expression<Func<Sys_CustomerCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_CustomerCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_CustomerCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_CustomerCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_CustomerCLTs:ReadOnlyListBase<Sys_CustomerCLTs,Sys_CustomerCLT>
    {
        #region Factory Methods

        public static Sys_CustomerCLTs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_CustomerCLTs>();
        }

		public static Sys_CustomerCLTs Fetch(System.Linq.Expressions.Expression<Func<Sys_CustomerCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_CustomerCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_CustomerCLTs>(lambda);
		}

		public static Sys_CustomerCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_CustomerCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_CustomerCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_CustomerCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_CustomerCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_CustomerCLT>(exp,values)});
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
