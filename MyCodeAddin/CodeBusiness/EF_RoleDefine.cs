using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_RoleDefine))]
#if Dev
    [RunLocal]
#endif

	public class EF_RoleDefine:ReadOnlyBase<EF_RoleDefine>
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

		
        public string UIType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string Single
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

		public static EF_RoleDefine Create()
        {
            return EF.DataPortal.Create<EF_RoleDefine>();
        }

		public static EF_RoleDefine Fetch(System.Linq.Expressions.Expression<Func<EF_RoleDefine, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleDefine>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleDefine>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_RoleDefines))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_RoleDefines:ReadOnlyListBase<EF_RoleDefines,EF_RoleDefine>
    {
        #region Factory Methods

        public static EF_RoleDefines Fetch()
        {
            return EF.DataPortal.Fetch<EF_RoleDefines>();
        }

		public static EF_RoleDefines Fetch(System.Linq.Expressions.Expression<Func<EF_RoleDefine, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleDefine>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleDefines>(lambda);
		}

		public static EF_RoleDefines Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_RoleDefines>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_RoleDefines Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_RoleDefine, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_RoleDefines>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_RoleDefine>(exp,values)});
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
