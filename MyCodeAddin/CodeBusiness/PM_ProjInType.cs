using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_ProjInType))]
#if Dev
    [RunLocal]
#endif

	public class PM_ProjInType:ReadOnlyBase<PM_ProjInType>
    {
        #region Business Methods

		
        public string ProjInTypeCode
        {
            get ;
            set ;
        }

		
        public string ProjInTypeName
        {
            get ;
            set ;
        }

		
        public string Memo
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_ProjInType Create()
        {
            return EF.DataPortal.Create<PM_ProjInType>();
        }

		public static PM_ProjInType Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInType>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_ProjInTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_ProjInTypes:ReadOnlyListBase<PM_ProjInTypes,PM_ProjInType>
    {
        #region Factory Methods

        public static PM_ProjInTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_ProjInTypes>();
        }

		public static PM_ProjInTypes Fetch(System.Linq.Expressions.Expression<Func<PM_ProjInType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_ProjInType>(exp,values);
            return EF.DataPortal.Fetch<PM_ProjInTypes>(lambda);
		}

		public static PM_ProjInTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_ProjInTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_ProjInTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_ProjInType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_ProjInTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_ProjInType>(exp,values)});
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
