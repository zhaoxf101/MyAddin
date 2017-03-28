using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(Sys_GrpSet))]
#if Dev
    [RunLocal]
#endif

	public class Sys_GrpSet:ReadOnlyBase<Sys_GrpSet>
    {
        #region Business Methods

		
        public string GrpClass
        {
            get ;
            set ;
        }

		
        public string GrpName
        {
            get ;
            set ;
        }

		
        public bool Uniqe
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

		public static Sys_GrpSet Create()
        {
            return EF.DataPortal.Create<Sys_GrpSet>();
        }

		public static Sys_GrpSet Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpSet, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpSet>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpSet>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(Sys_GrpSets))]
#if Dev
    [RunLocal]
#endif
	
	public class Sys_GrpSets:ReadOnlyListBase<Sys_GrpSets,Sys_GrpSet>
    {
        #region Factory Methods

        public static Sys_GrpSets Fetch()
        {
            return EF.DataPortal.Fetch<Sys_GrpSets>();
        }

		public static Sys_GrpSets Fetch(System.Linq.Expressions.Expression<Func<Sys_GrpSet, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<Sys_GrpSet>(exp,values);
            return EF.DataPortal.Fetch<Sys_GrpSets>(lambda);
		}

		public static Sys_GrpSets Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<Sys_GrpSets>(new Paging { Page=page,RowCount=rowCount});
        }

        public static Sys_GrpSets Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<Sys_GrpSet, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<Sys_GrpSets>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<Sys_GrpSet>(exp,values)});
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
