using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_AuthOrgFld))]
#if Dev
    [RunLocal]
#endif

	public class EF_AuthOrgFld:ReadOnlyBase<EF_AuthOrgFld>
    {
        #region Business Methods

		
        public string OrgField
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

		public static EF_AuthOrgFld Create()
        {
            return EF.DataPortal.Create<EF_AuthOrgFld>();
        }

		public static EF_AuthOrgFld Fetch(System.Linq.Expressions.Expression<Func<EF_AuthOrgFld, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_AuthOrgFld>(exp,values);
            return EF.DataPortal.Fetch<EF_AuthOrgFld>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_AuthOrgFlds))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_AuthOrgFlds:ReadOnlyListBase<EF_AuthOrgFlds,EF_AuthOrgFld>
    {
        #region Factory Methods

        public static EF_AuthOrgFlds Fetch()
        {
            return EF.DataPortal.Fetch<EF_AuthOrgFlds>();
        }

		public static EF_AuthOrgFlds Fetch(System.Linq.Expressions.Expression<Func<EF_AuthOrgFld, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_AuthOrgFld>(exp,values);
            return EF.DataPortal.Fetch<EF_AuthOrgFlds>(lambda);
		}

		public static EF_AuthOrgFlds Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_AuthOrgFlds>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_AuthOrgFlds Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_AuthOrgFld, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_AuthOrgFlds>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_AuthOrgFld>(exp,values)});
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
