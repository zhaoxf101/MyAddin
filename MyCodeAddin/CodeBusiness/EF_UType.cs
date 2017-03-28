using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_UType))]
#if Dev
    [RunLocal]
#endif

	public class EF_UType:ReadOnlyBase<EF_UType>
    {
        #region Business Methods

		
        public string UType
        {
            get ;
            set ;
        }

		
        public string UTypeName
        {
            get ;
            set ;
        }

		
        public bool IsInter
        {
            get ;
            set ;
        }

		
        public bool IsEmp
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_UType Create()
        {
            return EF.DataPortal.Create<EF_UType>();
        }

		public static EF_UType Fetch(System.Linq.Expressions.Expression<Func<EF_UType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_UType>(exp,values);
            return EF.DataPortal.Fetch<EF_UType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_UTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_UTypes:ReadOnlyListBase<EF_UTypes,EF_UType>
    {
        #region Factory Methods

        public static EF_UTypes Fetch()
        {
            return EF.DataPortal.Fetch<EF_UTypes>();
        }

		public static EF_UTypes Fetch(System.Linq.Expressions.Expression<Func<EF_UType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_UType>(exp,values);
            return EF.DataPortal.Fetch<EF_UTypes>(lambda);
		}

		public static EF_UTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_UTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_UTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_UType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_UTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_UType>(exp,values)});
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
