using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Customer))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Customer:ReadOnlyBase<Sys_Customer>
    {
        #region Business Methods

		
        public string CustCode
        {
            get ;
            set ;
        }

		
        public string CustName
        {
            get ;
            set ;
        }

		
        public string CustGrpCode
        {
            get ;
            set ;
        }

		
        public bool OneTimeX
        {
            get ;
            set ;
        }

		
        public bool RelPartyX
        {
            get ;
            set ;
        }

		
        public bool IsDelete
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

		public static Sys_Customer Create()
        {
            return EF.DataPortal.Create<Sys_Customer>();
        }

		public static Sys_Customer Fetch(System.Linq.Expressions.Expression<Func<Sys_Customer, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Customer>(exp,values);
            return EF.DataPortal.Fetch<Sys_Customer>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Customers))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Customers:ReadOnlyListBase<Sys_Customers,Sys_Customer>
    {
        #region Factory Methods

        public static Sys_Customers Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Customers>();
        }

		public static Sys_Customers Fetch(System.Linq.Expressions.Expression<Func<Sys_Customer, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Customer>(exp,values);
            return EF.DataPortal.Fetch<Sys_Customers>(lambda);
		}

		public static Sys_Customers Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Customers>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Customers Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Customer, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Customers>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Customer>(exp,values)});
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
