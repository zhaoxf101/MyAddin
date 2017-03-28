using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_CustomerGrp))]
#if Dev
    [RunLocal]
#endif

	public class Sys_CustomerGrp:ReadOnlyBase<Sys_CustomerGrp>
    {
        #region Business Methods

		
        public string CustGrpCode
        {
            get ;
            set ;
        }

		
        public string CustGrpName
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

		public static Sys_CustomerGrp Create()
        {
            return EF.DataPortal.Create<Sys_CustomerGrp>();
        }

		public static Sys_CustomerGrp Fetch(System.Linq.Expressions.Expression<Func<Sys_CustomerGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_CustomerGrp>(exp,values);
            return EF.DataPortal.Fetch<Sys_CustomerGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_CustomerGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_CustomerGrps:ReadOnlyListBase<Sys_CustomerGrps,Sys_CustomerGrp>
    {
        #region Factory Methods

        public static Sys_CustomerGrps Fetch()
        {
            return EF.DataPortal.Fetch<Sys_CustomerGrps>();
        }

		public static Sys_CustomerGrps Fetch(System.Linq.Expressions.Expression<Func<Sys_CustomerGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_CustomerGrp>(exp,values);
            return EF.DataPortal.Fetch<Sys_CustomerGrps>(lambda);
		}

		public static Sys_CustomerGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_CustomerGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_CustomerGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_CustomerGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_CustomerGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_CustomerGrp>(exp,values)});
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
