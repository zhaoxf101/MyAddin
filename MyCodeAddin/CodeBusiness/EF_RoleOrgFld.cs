using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_RoleOrgFld))]
#if Dev
    [RunLocal]
#endif

	public class EF_RoleOrgFld:ReadOnlyBase<EF_RoleOrgFld>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string RoleName
        {
            get ;
            set ;
        }

		
        public string Active
        {
            get ;
            set ;
        }

		
        public int Counter
        {
            get ;
            set ;
        }

		
        public string OrgField
        {
            get ;
            set ;
        }

		
        public string Low
        {
            get ;
            set ;
        }

		
        public string High
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_RoleOrgFld Create()
        {
            return EF.DataPortal.Create<EF_RoleOrgFld>();
        }

		public static EF_RoleOrgFld Fetch(System.Linq.Expressions.Expression<Func<EF_RoleOrgFld, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleOrgFld>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleOrgFld>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_RoleOrgFlds))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_RoleOrgFlds:ReadOnlyListBase<EF_RoleOrgFlds,EF_RoleOrgFld>
    {
        #region Factory Methods

        public static EF_RoleOrgFlds Fetch()
        {
            return EF.DataPortal.Fetch<EF_RoleOrgFlds>();
        }

		public static EF_RoleOrgFlds Fetch(System.Linq.Expressions.Expression<Func<EF_RoleOrgFld, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleOrgFld>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleOrgFlds>(lambda);
		}

		public static EF_RoleOrgFlds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_RoleOrgFlds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_RoleOrgFlds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_RoleOrgFld, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_RoleOrgFlds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_RoleOrgFld>(exp,values)});
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
