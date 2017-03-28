using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_RoleMenus))]
#if Dev
    [RunLocal]
#endif

	public class EF_RoleMenus:ReadOnlyBase<EF_RoleMenus>
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

		
        public int ObjectId
        {
            get ;
            set ;
        }

		
        public int ParentId
        {
            get ;
            set ;
        }

		
        public int SortOrder
        {
            get ;
            set ;
        }

		
        public bool Folder
        {
            get ;
            set ;
        }

		
        public string TCode
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string Flags
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_RoleMenus Create()
        {
            return EF.DataPortal.Create<EF_RoleMenus>();
        }

		public static EF_RoleMenus Fetch(System.Linq.Expressions.Expression<Func<EF_RoleMenus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleMenus>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleMenus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_RoleMenuss))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_RoleMenuss:ReadOnlyListBase<EF_RoleMenuss,EF_RoleMenus>
    {
        #region Factory Methods

        public static EF_RoleMenuss Fetch()
        {
            return EF.DataPortal.Fetch<EF_RoleMenuss>();
        }

		public static EF_RoleMenuss Fetch(System.Linq.Expressions.Expression<Func<EF_RoleMenus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleMenus>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleMenuss>(lambda);
		}

		public static EF_RoleMenuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_RoleMenuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_RoleMenuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_RoleMenus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_RoleMenuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_RoleMenus>(exp,values)});
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
