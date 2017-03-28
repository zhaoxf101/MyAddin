using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_UserRoles))]
#if Dev
    [RunLocal]
#endif

	public class EF_UserRoles:ReadOnlyBase<EF_UserRoles>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BName
        {
            get ;
            set ;
        }

		
        public string RoleName
        {
            get ;
            set ;
        }

		
        public DateTime? ValidFrom
        {
            get ;
            set ;
        }

		
        public DateTime? ValidTo
        {
            get ;
            set ;
        }

		
        public DateTime? ChgDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_UserRoles Create()
        {
            return EF.DataPortal.Create<EF_UserRoles>();
        }

		public static EF_UserRoles Fetch(System.Linq.Expressions.Expression<Func<EF_UserRoles, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_UserRoles>(exp,values);
            return EF.DataPortal.Fetch<EF_UserRoles>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_UserRoless))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_UserRoless:ReadOnlyListBase<EF_UserRoless,EF_UserRoles>
    {
        #region Factory Methods

        public static EF_UserRoless Fetch()
        {
            return EF.DataPortal.Fetch<EF_UserRoless>();
        }

		public static EF_UserRoless Fetch(System.Linq.Expressions.Expression<Func<EF_UserRoles, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_UserRoles>(exp,values);
            return EF.DataPortal.Fetch<EF_UserRoless>(lambda);
		}

		public static EF_UserRoless Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_UserRoless>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_UserRoless Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_UserRoles, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_UserRoless>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_UserRoles>(exp,values)});
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
