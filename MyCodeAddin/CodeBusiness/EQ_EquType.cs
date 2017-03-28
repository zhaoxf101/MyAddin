using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EQ_EquType))]
#if Dev
    [RunLocal]
#endif

	public class EQ_EquType:ReadOnlyBase<EQ_EquType>
    {
        #region Business Methods

		
        public string EquTypeCode
        {
            get ;
            set ;
        }

		
        public string EquTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EQ_EquType Create()
        {
            return EF.DataPortal.Create<EQ_EquType>();
        }

		public static EQ_EquType Fetch(System.Linq.Expressions.Expression<Func<EQ_EquType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EQ_EquType>(exp,values);
            return EF.DataPortal.Fetch<EQ_EquType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EQ_EquTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class EQ_EquTypes:ReadOnlyListBase<EQ_EquTypes,EQ_EquType>
    {
        #region Factory Methods

        public static EQ_EquTypes Fetch()
        {
            return EF.DataPortal.Fetch<EQ_EquTypes>();
        }

		public static EQ_EquTypes Fetch(System.Linq.Expressions.Expression<Func<EQ_EquType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EQ_EquType>(exp,values);
            return EF.DataPortal.Fetch<EQ_EquTypes>(lambda);
		}

		public static EQ_EquTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EQ_EquTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EQ_EquTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EQ_EquType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EQ_EquTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EQ_EquType>(exp,values)});
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
