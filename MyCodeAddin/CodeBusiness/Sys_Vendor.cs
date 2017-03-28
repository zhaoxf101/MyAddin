using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_Vendor))]
#if Dev
    [RunLocal]
#endif

	public class Sys_Vendor:ReadOnlyBase<Sys_Vendor>
    {
        #region Business Methods

		
        public string VendorCode
        {
            get ;
            set ;
        }

		
        public string VendorName
        {
            get ;
            set ;
        }

		
        public string VendGrpCode
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

		public static Sys_Vendor Create()
        {
            return EF.DataPortal.Create<Sys_Vendor>();
        }

		public static Sys_Vendor Fetch(System.Linq.Expressions.Expression<Func<Sys_Vendor, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_Vendor>(exp,values);
            return EF.DataPortal.Fetch<Sys_Vendor>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_Vendors))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_Vendors:ReadOnlyListBase<Sys_Vendors,Sys_Vendor>
    {
        #region Factory Methods

        public static Sys_Vendors Fetch()
        {
            return EF.DataPortal.Fetch<Sys_Vendors>();
        }

		public static Sys_Vendors Fetch(System.Linq.Expressions.Expression<Func<Sys_Vendor, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_Vendor>(exp,values);
            return EF.DataPortal.Fetch<Sys_Vendors>(lambda);
		}

		public static Sys_Vendors Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_Vendors>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_Vendors Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_Vendor, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_Vendors>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_Vendor>(exp,values)});
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
