using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_VendorCLT))]
#if Dev
    [RunLocal]
#endif

	public class Sys_VendorCLT:ReadOnlyBase<Sys_VendorCLT>
    {
        #region Business Methods

		
        public string Client
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

		public static Sys_VendorCLT Create()
        {
            return EF.DataPortal.Create<Sys_VendorCLT>();
        }

		public static Sys_VendorCLT Fetch(System.Linq.Expressions.Expression<Func<Sys_VendorCLT, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_VendorCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_VendorCLT>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_VendorCLTs))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_VendorCLTs:ReadOnlyListBase<Sys_VendorCLTs,Sys_VendorCLT>
    {
        #region Factory Methods

        public static Sys_VendorCLTs Fetch()
        {
            return EF.DataPortal.Fetch<Sys_VendorCLTs>();
        }

		public static Sys_VendorCLTs Fetch(System.Linq.Expressions.Expression<Func<Sys_VendorCLT, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_VendorCLT>(exp,values);
            return EF.DataPortal.Fetch<Sys_VendorCLTs>(lambda);
		}

		public static Sys_VendorCLTs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_VendorCLTs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_VendorCLTs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_VendorCLT, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_VendorCLTs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_VendorCLT>(exp,values)});
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
