using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_RoleAuthObj))]
#if Dev
    [RunLocal]
#endif

	public class EF_RoleAuthObj:ReadOnlyBase<EF_RoleAuthObj>
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

		
        public string Object
        {
            get ;
            set ;
        }

		
        public string Active
        {
            get ;
            set ;
        }

		
        public string Modiied
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_RoleAuthObj Create()
        {
            return EF.DataPortal.Create<EF_RoleAuthObj>();
        }

		public static EF_RoleAuthObj Fetch(System.Linq.Expressions.Expression<Func<EF_RoleAuthObj, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleAuthObj>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleAuthObj>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_RoleAuthObjs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_RoleAuthObjs:ReadOnlyListBase<EF_RoleAuthObjs,EF_RoleAuthObj>
    {
        #region Factory Methods

        public static EF_RoleAuthObjs Fetch()
        {
            return EF.DataPortal.Fetch<EF_RoleAuthObjs>();
        }

		public static EF_RoleAuthObjs Fetch(System.Linq.Expressions.Expression<Func<EF_RoleAuthObj, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_RoleAuthObj>(exp,values);
            return EF.DataPortal.Fetch<EF_RoleAuthObjs>(lambda);
		}

		public static EF_RoleAuthObjs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_RoleAuthObjs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_RoleAuthObjs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_RoleAuthObj, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_RoleAuthObjs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_RoleAuthObj>(exp,values)});
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
