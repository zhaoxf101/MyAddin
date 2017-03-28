using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_UnitGrp))]
#if Dev
    [RunLocal]
#endif

	public class Sys_UnitGrp:ReadOnlyBase<Sys_UnitGrp>
    {
        #region Business Methods

		
        public string UnitGrp
        {
            get ;
            set ;
        }

		
        public string DText
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

		public static Sys_UnitGrp Create()
        {
            return EF.DataPortal.Create<Sys_UnitGrp>();
        }

		public static Sys_UnitGrp Fetch(System.Linq.Expressions.Expression<Func<Sys_UnitGrp, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_UnitGrp>(exp,values);
            return EF.DataPortal.Fetch<Sys_UnitGrp>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_UnitGrps))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_UnitGrps:ReadOnlyListBase<Sys_UnitGrps,Sys_UnitGrp>
    {
        #region Factory Methods

        public static Sys_UnitGrps Fetch()
        {
            return EF.DataPortal.Fetch<Sys_UnitGrps>();
        }

		public static Sys_UnitGrps Fetch(System.Linq.Expressions.Expression<Func<Sys_UnitGrp, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_UnitGrp>(exp,values);
            return EF.DataPortal.Fetch<Sys_UnitGrps>(lambda);
		}

		public static Sys_UnitGrps Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_UnitGrps>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_UnitGrps Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_UnitGrp, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_UnitGrps>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_UnitGrp>(exp,values)});
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
