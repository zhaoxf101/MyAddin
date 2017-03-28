using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_RelParyGrp))]
#if Dev
    [RunLocal]
#endif

	public class Sys_RelParyGrp:ReadOnlyBase<Sys_RelParyGrp>
    {
        #region Business Methods

		
        public string RelPartyGrpCode
        {
            get ;
            set ;
        }

		
        public string RelPartyGrpName
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

		public static Sys_RelParyGrp Create()
        {
            return EF.DataPortal.Create<Sys_RelParyGrp>();
        }

		public static Sys_RelParyGrp Fetch(System.Linq.Expressions.Expression<Func<Sys_RelParyGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_RelParyGrp>(exp,values);
            return EF.DataPortal.Fetch<Sys_RelParyGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_RelParyGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_RelParyGrps:ReadOnlyListBase<Sys_RelParyGrps,Sys_RelParyGrp>
    {
        #region Factory Methods

        public static Sys_RelParyGrps Fetch()
        {
            return EF.DataPortal.Fetch<Sys_RelParyGrps>();
        }

		public static Sys_RelParyGrps Fetch(System.Linq.Expressions.Expression<Func<Sys_RelParyGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_RelParyGrp>(exp,values);
            return EF.DataPortal.Fetch<Sys_RelParyGrps>(lambda);
		}

		public static Sys_RelParyGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_RelParyGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_RelParyGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_RelParyGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_RelParyGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_RelParyGrp>(exp,values)});
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
