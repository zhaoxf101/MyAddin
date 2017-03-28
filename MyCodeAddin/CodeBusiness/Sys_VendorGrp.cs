using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_VendorGrp))]
#if Dev
    [RunLocal]
#endif

	public class Sys_VendorGrp:ReadOnlyBase<Sys_VendorGrp>
    {
        #region Business Methods

		
        public string VendGrpCode
        {
            get ;
            set ;
        }

		
        public string VendGrpName
        {
            get ;
            set ;
        }

		
        public bool OneTimeX
        {
            get ;
            set ;
        }

		
        public bool InternalX
        {
            get ;
            set ;
        }

		
        public string RangeNR
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

		public static Sys_VendorGrp Create()
        {
            return EF.DataPortal.Create<Sys_VendorGrp>();
        }

		public static Sys_VendorGrp Fetch(System.Linq.Expressions.Expression<Func<Sys_VendorGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_VendorGrp>(exp,values);
            return EF.DataPortal.Fetch<Sys_VendorGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_VendorGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_VendorGrps:ReadOnlyListBase<Sys_VendorGrps,Sys_VendorGrp>
    {
        #region Factory Methods

        public static Sys_VendorGrps Fetch()
        {
            return EF.DataPortal.Fetch<Sys_VendorGrps>();
        }

		public static Sys_VendorGrps Fetch(System.Linq.Expressions.Expression<Func<Sys_VendorGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_VendorGrp>(exp,values);
            return EF.DataPortal.Fetch<Sys_VendorGrps>(lambda);
		}

		public static Sys_VendorGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_VendorGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_VendorGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_VendorGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_VendorGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_VendorGrp>(exp,values)});
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
