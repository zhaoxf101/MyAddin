using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_IncDetType))]
#if Dev
    [RunLocal]
#endif

	public class FI_IncDetType:ReadOnlyBase<FI_IncDetType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string IncDetTypeCode
        {
            get ;
            set ;
        }

		
        public string IncDetTypeName
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string Memo
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

		public static FI_IncDetType Create()
        {
            return EF.DataPortal.Create<FI_IncDetType>();
        }

		public static FI_IncDetType Fetch(System.Linq.Expressions.Expression<Func<FI_IncDetType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_IncDetType>(exp,values);
            return EF.DataPortal.Fetch<FI_IncDetType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_IncDetTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_IncDetTypes:ReadOnlyListBase<FI_IncDetTypes,FI_IncDetType>
    {
        #region Factory Methods

        public static FI_IncDetTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_IncDetTypes>();
        }

		public static FI_IncDetTypes Fetch(System.Linq.Expressions.Expression<Func<FI_IncDetType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_IncDetType>(exp,values);
            return EF.DataPortal.Fetch<FI_IncDetTypes>(lambda);
		}

		public static FI_IncDetTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_IncDetTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_IncDetTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_IncDetType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_IncDetTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_IncDetType>(exp,values)});
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
