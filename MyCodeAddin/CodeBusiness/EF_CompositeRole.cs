using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_CompositeRole))]
#if Dev
    [RunLocal]
#endif

	public class EF_CompositeRole:ReadOnlyBase<EF_CompositeRole>
    {
        #region Business Methods

		
        public string RoleName
        {
            get ;
            set ;
        }

		
        public string ChildRole
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_CompositeRole Create()
        {
            return EF.DataPortal.Create<EF_CompositeRole>();
        }

		public static EF_CompositeRole Fetch(System.Linq.Expressions.Expression<Func<EF_CompositeRole, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_CompositeRole>(exp,values);
            return EF.DataPortal.Fetch<EF_CompositeRole>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_CompositeRoles))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_CompositeRoles:ReadOnlyListBase<EF_CompositeRoles,EF_CompositeRole>
    {
        #region Factory Methods

        public static EF_CompositeRoles Fetch()
        {
            return EF.DataPortal.Fetch<EF_CompositeRoles>();
        }

		public static EF_CompositeRoles Fetch(System.Linq.Expressions.Expression<Func<EF_CompositeRole, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_CompositeRole>(exp,values);
            return EF.DataPortal.Fetch<EF_CompositeRoles>(lambda);
		}

		public static EF_CompositeRoles Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_CompositeRoles>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_CompositeRoles Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_CompositeRole, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_CompositeRoles>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_CompositeRole>(exp,values)});
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
