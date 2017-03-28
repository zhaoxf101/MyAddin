using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_AuthType))]
#if Dev
    [RunLocal]
#endif

	public class EF_AuthType:ReadOnlyBase<EF_AuthType>
    {
        #region Business Methods

		
        public string AClass
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

		public static EF_AuthType Create()
        {
            return EF.DataPortal.Create<EF_AuthType>();
        }

		public static EF_AuthType Fetch(System.Linq.Expressions.Expression<Func<EF_AuthType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_AuthType>(exp,values);
            return EF.DataPortal.Fetch<EF_AuthType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_AuthTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_AuthTypes:ReadOnlyListBase<EF_AuthTypes,EF_AuthType>
    {
        #region Factory Methods

        public static EF_AuthTypes Fetch()
        {
            return EF.DataPortal.Fetch<EF_AuthTypes>();
        }

		public static EF_AuthTypes Fetch(System.Linq.Expressions.Expression<Func<EF_AuthType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_AuthType>(exp,values);
            return EF.DataPortal.Fetch<EF_AuthTypes>(lambda);
		}

		public static EF_AuthTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_AuthTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_AuthTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_AuthType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_AuthTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_AuthType>(exp,values)});
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
