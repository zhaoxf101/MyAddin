using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjMemberType))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjMemberType:ReadOnlyBase<PM_ProjMemberType>
    {
        #region Business Methods

		
        public string ProjMemberTypeCode
        {
            get ;
            set ;
        }

		
        public string ProjMemberTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ProjMemberType Create()
        {
            return EF.DataPortal.Create<PM_ProjMemberType>();
        }

		public static PM_ProjMemberType Fetch(System.Linq.Expressions.Expression<Func<PM_ProjMemberType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjMemberType>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjMemberType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjMemberTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjMemberTypes:ReadOnlyListBase<PM_ProjMemberTypes,PM_ProjMemberType>
    {
        #region Factory Methods

        public static PM_ProjMemberTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjMemberTypes>();
        }

		public static PM_ProjMemberTypes Fetch(System.Linq.Expressions.Expression<Func<PM_ProjMemberType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjMemberType>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjMemberTypes>(lambda);
		}

		public static PM_ProjMemberTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjMemberTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjMemberTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjMemberType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjMemberTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjMemberType>(exp,values)});
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
