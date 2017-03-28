using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_RoleAuthFld))]
#if Dev
    [RunLocal]
#endif

	public class EF_RoleAuthFld:ReadOnlyBase<EF_RoleAuthFld>
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

		
        public string Object
        {
            get ;
            set ;
        }

		
        public string FieldName
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

		public static EF_RoleAuthFld Create()
        {
            return EF.DataPortal.Create<EF_RoleAuthFld>();
        }

		public static EF_RoleAuthFld Fetch(System.Linq.Expressions.Expression<Func<EF_RoleAuthFld, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleAuthFld>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleAuthFld>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_RoleAuthFlds))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_RoleAuthFlds:ReadOnlyListBase<EF_RoleAuthFlds,EF_RoleAuthFld>
    {
        #region Factory Methods

        public static EF_RoleAuthFlds Fetch()
        {
            return EF.DataPortal.Fetch<EF_RoleAuthFlds>();
        }

		public static EF_RoleAuthFlds Fetch(System.Linq.Expressions.Expression<Func<EF_RoleAuthFld, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleAuthFld>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleAuthFlds>(lambda);
		}

		public static EF_RoleAuthFlds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_RoleAuthFlds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_RoleAuthFlds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_RoleAuthFld, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_RoleAuthFlds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_RoleAuthFld>(exp,values)});
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
