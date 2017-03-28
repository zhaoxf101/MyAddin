using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpType))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpType:ReadOnlyBase<FI_ExpType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpTypeCode
        {
            get ;
            set ;
        }

		
        public string ExpTypeName
        {
            get ;
            set ;
        }

		
        public string ExpGroup
        {
            get ;
            set ;
        }

		
        public bool IsAutoProj
        {
            get ;
            set ;
        }

		
        public bool IsProjWF
        {
            get ;
            set ;
        }

		
        public string ProjCode
        {
            get ;
            set ;
        }

		
        public string TaskCode
        {
            get ;
            set ;
        }

		
        public string WorkFlowId
        {
            get ;
            set ;
        }

		
        public bool IsEco
        {
            get ;
            set ;
        }

		
        public bool IsRes
        {
            get ;
            set ;
        }

		
        public string AccCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpType Create()
        {
            return EF.DataPortal.Create<FI_ExpType>();
        }

		public static FI_ExpType Fetch(System.Linq.Expressions.Expression<Func<FI_ExpType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpType>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpTypes:ReadOnlyListBase<FI_ExpTypes,FI_ExpType>
    {
        #region Factory Methods

        public static FI_ExpTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpTypes>();
        }

		public static FI_ExpTypes Fetch(System.Linq.Expressions.Expression<Func<FI_ExpType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpType>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpTypes>(lambda);
		}

		public static FI_ExpTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpType>(exp,values)});
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
